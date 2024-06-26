﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security.Claims;
using System.Threading.Tasks;
using Domain.Dtos;
using Domain.Dtos.User;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Web.Controllers;

[ExcludeFromCodeCoverage]
public class LoginController : BaseController<LoginController>
{
    private readonly ILoginService _service;
    private readonly IUserService _userService;
    public LoginController(IServiceProvider serviceProvider, ILogger<LoginController> logger) : 
       
        base(serviceProvider, logger)
    {
        _service = GetService<ILoginService>();
        _userService = GetService<IUserService>();
    }

    public IActionResult Index() => View();

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(LoginDto login)
    {
        try
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _service.Login(login);

            if (result.Authenticated == false)
                return StatusCode(StatusCodes.Status203NonAuthoritative, result.Message);

            await SignInUser(result.User, false);
            return RedirectToAction("Index", "Home");
        }
        catch (Exception exception)
        {
            LoggingExceptions(exception);
            return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
        }
    }

    /// <summary>  
    /// Sign In User method.  
    /// </summary>  
    /// <param name="username">Username parameter.</param>  
    /// <param name="isPersistent">Is persistent parameter.</param>  
    /// <returns>Returns - await task</returns>  
    private async Task SignInUser(UserResultDto user, bool isPersistent)
    {
        // Initialization.  
        var claims = new List<Claim>
        {
            // Setting
            new Claim(ClaimTypes.Sid, user.Id.ToString()),
            new Claim(ClaimTypes.Email, user.Email),
            new Claim(ClaimTypes.Name, user.Name)
        };

        var claimIdentities = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
        var mainClaim = new ClaimsPrincipal(claimIdentities);
        var authenticationManager = Request.HttpContext;

        // Sign In.  
        await authenticationManager
            .SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                mainClaim, new AuthenticationProperties() { IsPersistent = isPersistent }
            );
    }

    [HttpGet]
    public IActionResult LogOff()
    {
        try
        {
            // Setting.  
            var authenticationManager = Request.HttpContext;

            // Sign Out.  
            authenticationManager.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index");
        }
        catch (Exception exception)
        {
            LoggingExceptions(exception);
            return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
        }
    }

    [HttpGet("/Login/Register")]
    public IActionResult RegisterIndex() => View("Register");

    [HttpPost("/Login/Register")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Register(UserCreateDto userCreateDto)
    {
        try
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = await _userService.CreateAsync(userCreateDto);

            if (user == null)
                return BadRequest(ModelState);

            await SignInUser(user, false);
            
            return RedirectToAction("Index", "Home");
        }
        catch (Exception exception)
        {
            LoggingExceptions(exception);
            return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
        }
    }
}
