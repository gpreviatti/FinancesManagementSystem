﻿using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Dtos.Category;
using Domain.Dtos.Entrance;
using Domain.Dtos.Wallet;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.Mappers;
using Domain.Services;
using Moq;
using Xunit;

namespace Tests.Domain.Service;
public class EntranceServiceTest : BaseServiceTest
{
    private readonly Mock<IEntranceRepository> _repositoryMock;
    private readonly Mock<IWalletService> _walletServiceMock;
    private readonly Mock<ICategoryService> _categoryServiceMock;

    private readonly IEntranceService _service;

    public EntranceServiceTest()
    {
        _repositoryMock = new Mock<IEntranceRepository>();
        _walletServiceMock = new Mock<IWalletService>();
        _categoryServiceMock = new Mock<ICategoryService>();
        _service = new EntranceService(
            _repositoryMock.Object,
            _walletServiceMock.Object,
            _categoryServiceMock.Object
        );
    }

    #region Find and List Tests
    [Fact(DisplayName = "Should find an entrance by id")]
    [Trait("Service", "Entrance")]
    public async void ShouldFindByIdAsync()
    {
        // Arrange
        var entrance = new Entrance
        {
            Description = Faker.Lorem.Paragraph(),
            Observation = Faker.Lorem.Paragraph(),
            Value = Faker.RandomNumber.Next(100),
            CategoryId = Guid.NewGuid(),
            WalletId = Guid.NewGuid(),
            Ticker = "TEST",
            Type = 1
        };

        var entranceResultDto = entrance.MapperToResultDto();
                
        _repositoryMock
            .Setup(r => r.FindByIdAsync(_userAdminId, It.IsAny<bool>()).Result)
            .Returns(entrance);

        // Act
        var result = await _service.FindByIdAsync(_userAdminId);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(result.Description, entranceResultDto.Description);
        Assert.Equal(result.Observation, entranceResultDto.Observation);
        Assert.Equal(result.Value, entranceResultDto.Value);
        Assert.Equal(result.CategoryId, entranceResultDto.CategoryId);
        Assert.Equal(result.WalletId, entranceResultDto.WalletId);
        Assert.Equal(result.Type, entranceResultDto.Type);
    }

    [Fact(DisplayName = "Should find last five entrances with categories")]
    [Trait("Service", "Entrance")]
    public async void FindAsyncLastFiveEntrancesWithCategories()
    {
        // Arrange
        var walletsId = new List<Guid>
        {
            Guid.NewGuid(),
            Guid.NewGuid(),
            Guid.NewGuid(),
            Guid.NewGuid(),
            Guid.NewGuid(),
        };

        var listEntranceResultDto = new List<EntranceResultDto>
        {
            new (){ Id = new (), Description = Faker.Name.FullName()},
            new (){ Id = new (), Description = Faker.Name.FullName()},
            new (){ Id = new (), Description = Faker.Name.FullName()},
            new (){ Id = new (), Description = Faker.Name.FullName()},
            new (){ Id = new (), Description = Faker.Name.FullName()},
            new (){ Id = new (), Description = Faker.Name.FullName()},
            new (){ Id = new (), Description = Faker.Name.FullName()},
            new (){ Id = new (), Description = Faker.Name.FullName()},
            new (){ Id = new (), Description = Faker.Name.FullName()},
            new (){ Id = new (), Description = Faker.Name.FullName()}
        }.AsQueryable();

        // Act
        _walletServiceMock
            .Setup(w => w.FindAsyncWalletsUserIds(_userAdminId).Result)
            .Returns(walletsId);

        _repositoryMock
            .Setup(r => r.FindAllAsyncWithCategory(walletsId).Result)
            .Returns(listEntranceResultDto);

        var result = await _service.FindAsyncLastFiveEntrancesWithCategories(_userAdminId);

        // Assert
        Assert.NotNull(result);
        Assert.True(result.Count().Equals(5));
    }

    [Fact(DisplayName = "Should find a list of entrance types")]
    [Trait("Service", "Entrance")]
    public void ShouldFindEntranceTypes()
    {
        // Arrange

        // Act
        var result = _service.FindEntranceTypes();

        // Assert
        Assert.NotNull(result);
        Assert.True(result.FirstOrDefault().Name.Equals("Income"));
        Assert.True(result.Count.Equals(3));
    }

    [Fact(DisplayName = "Not Create entrace when wallet is null")]
    [Trait("Service", "Entrance")]
    public async void ShouldNotCreateEntranceWhenWalletIsNull()
    {
        // Arrange
        var entranceCreateDto = new EntranceCreateDto
        {
            Description = _fakerName,
            Observation = _fakerName,
            Ticker = "TEST",
            Type = 1,
            Value = 100
        };

        var entrance = entranceCreateDto.Mapper();
        entrance.Id = Guid.NewGuid();

        // Act
        _repositoryMock.Setup(m => m.CreateAsync(entrance));
                
        var result = await _service.CreateAsync(entranceCreateDto);

        // Assert
        Assert.Null(result);
    }

    [Fact(DisplayName = "Not Create entrace when category is null")]
    [Trait("Service", "Entrance")]
    public async void ShouldNotCreateEntranceWhenCategoryIsNull()
    {
        // Arrange
        var entranceCreateDto = new EntranceCreateDto
        {
            Description = _fakerName,
            Observation = _fakerName,
            Ticker = "TEST",
            Type = 1,
            Value = 100
        };

        var entrance = entranceCreateDto.Mapper();
        entrance.Id = Guid.NewGuid();

        // Act
        _repositoryMock.Setup(m => m.CreateAsync(entrance));
        var result = await _service.CreateAsync(entranceCreateDto);

        // Assert
        Assert.Null(result);
    }

    //[Fact(DisplayName = "List entrances and return datatables format")]
    //[Trait("Service", "Entrance")]
    //public async void ShouldListEntrancesAndReturnDatatablesFormat()
    //{
    //    try
    //    {
    //        // Arrange
    //        var walletsId = new List<Guid>
    //        {
    //            Guid.NewGuid(),
    //            Guid.NewGuid(),
    //            Guid.NewGuid(),
    //            Guid.NewGuid(),
    //            Guid.NewGuid(),
    //        };

    //        var listEntranceResultDto = new List<EntranceResultDto>
    //        {
    //            new () { Id = new (), Description = Faker.Name.FullName()},
    //            new () { Id = new (), Description = Faker.Name.FullName()},
    //            new () { Id = new (), Description = Faker.Name.FullName()},
    //            new () { Id = new (), Description = Faker.Name.FullName()},
    //            new () { Id = new (), Description = Faker.Name.FullName()},
    //            new () { Id = new (), Description = Faker.Name.FullName()},
    //            new () { Id = new (), Description = Faker.Name.FullName()},
    //            new () { Id = new (), Description = Faker.Name.FullName()},
    //            new () { Id = new (), Description = Faker.Name.FullName()},
    //            new () { Id = new (), Description = Faker.Name.FullName()}
    //        }.AsQueryable();

    //        var datatablesTenRows = new DatatablesModel<EntranceResultDto> 
    //        {
    //            Skip = 0,
    //            Length = "10"
    //        };

    //        // Act
    //        _walletServiceMock
    //            .Setup(w => w.FindAsyncWalletsUserIds(It.IsAny<Guid>()).Result);

    //        var resultDontHasWallets = await _service.FindAllAsyncWithCategoryDatatables(datatablesTenRows, _userAdminId);

    //        _walletServiceMock
    //            .Setup(w => w.FindAsyncWalletsUserIds(_userAdminId).Result)
    //            .Returns(walletsId);

    //        _repositoryMock
    //            .Setup(m => m.FindAllAsyncWithCategory(walletsId).Result);

    //        var resultDontHasEntrances = await _service.FindAllAsyncWithCategoryDatatables(datatablesTenRows, _userAdminId);

    //        _repositoryMock
    //            .Setup(m => m.FindAllAsyncWithCategory(walletsId).Result)
    //            .Returns(listEntranceResultDto);

    //        var result = await _service.FindAllAsyncWithCategoryDatatables(datatablesTenRows, _userAdminId);

    //        // Assert
    //        Assert.Null(resultDontHasWallets);

    //        Assert.Null(resultDontHasEntrances);

    //        Assert.NotNull(result);
    //        Assert.True(result.Data.Count().Equals(listEntranceResultDto.Count()));

    //        _repositoryMock.Verify(r => r.FindAllAsyncWithCategory(walletsId), Times.Exactly(2));
    //        _walletServiceMock.Verify(r => r.FindAsyncWalletsUserIds(_userAdminId), Times.Exactly(3));
    //    }
    //    catch (Exception e)
    //    {
    //        Debug.WriteLine(e);
    //        Assert.True(false);
    //    }
    //}

    [Fact(DisplayName = "List entrace by id and return EntranceUpdateDto")]
    [Trait("Service", "Entrance")]
    public async void ShouldListEntranceById()
    {
        var entrance = new Entrance()
        {
            Id = new Guid(),
            Description = Faker.Name.FullName(),
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };

        _repositoryMock.Setup(m => m.FindByIdAsync(It.IsAny<Guid>(), It.IsAny<bool>()).Result).Returns(entrance);
        var result = await _service.FindByIdUpdateAsync(It.IsAny<Guid>());

        Assert.NotNull(result);
        Assert.Equal(entrance.Id, result.Id);
    }
    #endregion

    #region Setup View Models
    [Fact(DisplayName = "Should setup an entrance to view model")]
    [Trait("Service", "Entrance")]
    public async void ShouldSetupEntranceCreateViewModel()
    {
        // Arrange
        var walletsResultDto = new List<WalletResultDto>
        {
            new () {},
            new () {},
            new () {},
            new () {},
        };

        var categoryResultDto = new List<CategoryResultDto>
        {
            new () {},
            new () {},
            new () {},
        };

        // Act
        _walletServiceMock
            .Setup(w => w.FindAsyncWalletsUser(_userAdminId).Result)
            .Returns(walletsResultDto);

        _categoryServiceMock
            .Setup(c => c.FindAsyncNameAndIdUserCategories(_userAdminId).Result)
            .Returns(categoryResultDto);

        var result = await _service.SetupEntranceCreateViewModel(_userAdminId);

        // Assert
        Assert.NotNull(result);
        Assert.True(result.Wallets.Count().Equals(walletsResultDto.Count));
        Assert.True(result.Categories.Count().Equals(categoryResultDto.Count));
    }

    [Fact(DisplayName = "Should setup an entrance to view model")]
    [Trait("Service", "Entrance")]
    public async void ShouldSetupEntranceUpdateViewModel()
    {
        // Arrange
        var entranceId = Guid.NewGuid();

        var walletsResultDto = new List<WalletResultDto>
        {
            new () {},
            new () {},
            new () {},
            new () {},
        };

        var categoryResultDto = new List<CategoryResultDto>
        {
            new () {},
            new () {},
            new () {},
        };

        var entrance = new Entrance
        {
            Id = entranceId,
            Description = Faker.Lorem.Paragraph(),
            Observation = Faker.Lorem.Paragraph(),
            Value = Faker.RandomNumber.Next(100),
            CategoryId = Guid.NewGuid(),
            WalletId = Guid.NewGuid(),
            Ticker = "TEST",
            Type = 1
        };

        // Act
        _walletServiceMock
            .Setup(w => w.FindAsyncWalletsUser(_userAdminId).Result)
            .Returns(walletsResultDto);

        _categoryServiceMock
            .Setup(c => c.FindAsyncAllCommonAndUserCategories(_userAdminId).Result)
            .Returns(categoryResultDto);

        _repositoryMock
            .Setup(r => r.FindByIdAsync(entranceId, It.IsAny<bool>()).Result)
            .Returns(entrance);

        var result = await _service.SetupEntranceUpdateViewModel(_userAdminId, entranceId);

        // Assert
        Assert.NotNull(result);
        Assert.NotNull(result.Entrance);
        Assert.Equal(walletsResultDto.Count, result.Wallets.Count());
        Assert.Equal(categoryResultDto.Count, result.Categories.Count());
        Assert.Equal(3, result.EntranceTypes.Count());
    }
    #endregion

    [Fact(DisplayName = "Create entrance")]
    [Trait("Service", "Entrance")]
    public async void ShouldCreateEntrance()
    {
        // Arrange
        var categoryId = Guid.NewGuid();
        var walletId = Guid.NewGuid();
            
        var entranceCreateDto = new EntranceCreateDto
        {
            Description = _fakerName,
            Observation = _fakerName,
            Ticker = "TEST",
            Type = 1,
            Value = 100,
            CategoryId = categoryId,
            WalletId = walletId
        };

        var entrance = entranceCreateDto.Mapper();
        entrance.Id = Guid.NewGuid();

        var wallet = new WalletResultDto()
        {
            Id = Guid.NewGuid(),
            Name = _fakerName,
            CloseDate = _fakerDate,
            DueDate = _fakerDate,
            CurrentValue = 200,
            Description = _fakerName,
            CreatedAt = _fakerDate,
            UpdatedAt = _fakerDate
        };

        var categoryResultDto = new CategoryResultDto
        {
            Id = categoryId,
            Name = _fakerName
        };

        // Act
        _walletServiceMock
            .Setup(w => w.UpdateWalletValue(walletId, It.IsAny<int>(), It.IsAny<double>()).Result)
            .Returns(wallet);

        _categoryServiceMock
            .Setup(c => c.FindByIdAsync(categoryId).Result)
            .Returns(categoryResultDto);

        _repositoryMock.Setup(m => m.CreateAsync(entrance).Result).Returns(entrance);
        var result = await _service.CreateAsync(entranceCreateDto);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(entrance.Description, result.Description);
        Assert.Equal(entrance.Observation, result.Observation);
        Assert.Equal(entrance.Ticker, result.Ticker);
        Assert.Equal(entrance.Type, result.Type);
        Assert.Equal(entrance.Value, result.Value);
    }

    [Fact(DisplayName = "Update entrance")]
    [Trait("Service", "Entrance")]
    public async void ShouldUpdateEntrance()
    {
        // Arrange
        var entranceId = Guid.NewGuid();
        var categoryId = Guid.NewGuid();
        var walletId = Guid.NewGuid();
        var entranceUpdateDto = new EntranceUpdateDto
        {
            Id = entranceId,
            Description = _fakerName,
            Observation = _fakerName,
            Ticker = "TEST",
            Type = 1,
            Value = 100,
            CategoryId = categoryId,
            WalletId = walletId
        };

        var entrance = entranceUpdateDto.Mapper();

        var categoryResultDto = new CategoryResultDto
        {
            Id = categoryId,
            Name = _fakerName
        };

        var wallet = new WalletResultDto()
        {
            Id = Guid.NewGuid(),
            Name = _fakerName,
            CloseDate = _fakerDate,
            DueDate = _fakerDate,
            CurrentValue = 200,
            Description = _fakerName,
            CreatedAt = _fakerDate,
            UpdatedAt = _fakerDate
        };

        // Act
        _repositoryMock
            .Setup(r => r.FindByIdAsync(entranceId, It.IsAny<bool>()).Result)
            .Returns(entrance);

        _walletServiceMock
            .Setup(w => w.UpdateWalletValue(walletId, It.IsAny<int>(), It.IsAny<double>()).Result)
            .Returns(wallet);

        _categoryServiceMock
            .Setup(c => c.FindByIdAsync(categoryId).Result)
            .Returns(categoryResultDto);

        _repositoryMock
            .Setup(m => m.UpdateAsync(It.IsAny<Entrance>()))
            .ReturnsAsync(1);

        var result = await _service.UpdateAsync(entranceUpdateDto);

        _repositoryMock.Setup(m => m.SaveChangesAsync().Result);

        var resultEntranceNotSaved = await _service.UpdateAsync(entranceUpdateDto);

        _categoryServiceMock
            .Setup(c => c.FindByIdAsync(categoryId).Result);
        var resultCategoryNotFound = await _service.UpdateAsync(entranceUpdateDto);

        _walletServiceMock
            .Setup(w => w.UpdateWalletValue(walletId, It.IsAny<int>(), It.IsAny<double>()).Result);
        var resultNotUpdateWallet = await _service.UpdateAsync(entranceUpdateDto);

        _repositoryMock
            .Setup(r => r.FindByIdAsync(entranceId, It.IsAny<bool>()).Result);
        
        var resultEntranceNotFound = await _service.UpdateAsync(entranceUpdateDto);

        // Assert
        Assert.NotNull(result);
        Assert.Null(resultEntranceNotFound);
        Assert.Null(resultNotUpdateWallet);
        Assert.Null(resultCategoryNotFound);
        
        _repositoryMock.Verify(r => r.FindByIdAsync(entranceId, It.IsAny<bool>()), Times.Exactly(5));
        
        _walletServiceMock.Verify(r => r.UpdateWalletValue(walletId, It.IsAny<int>(), It.IsAny<double>()), Times.Exactly(4));
        
        _categoryServiceMock.Verify(r => r.FindByIdAsync(categoryId), Times.Exactly(3));
        
        _repositoryMock.Verify(r => r.UpdateAsync(It.IsAny<Entrance>()), Times.Exactly(2));
    }

    [Fact(DisplayName = "Delete entrace")]
    [Trait("Service", "Entrance")]
    public async void ShouldDeleteEntrance()
    {
        _repositoryMock.Setup(m => m.DeleteAsync(It.IsAny<Guid>())).ReturnsAsync(true);
        var result = await _service.DeleteAsync(Guid.NewGuid());

        Assert.True(result);

    }

    [Fact(DisplayName = "Not Delete entrace")]
    [Trait("Service", "Entrance")]
    public async void ShouldNotDeleteEntrance()
    {
        _repositoryMock.Setup(m => m.DeleteAsync(It.IsAny<Guid>())).ReturnsAsync(false);
        var result = await _service.DeleteAsync(Guid.NewGuid());

        Assert.False(result);
    }
}
