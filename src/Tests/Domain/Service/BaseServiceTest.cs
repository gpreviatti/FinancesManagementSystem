﻿using System;

namespace Tests.Domain.Service;

public abstract class BaseServiceTest : BaseTest
{
    protected readonly string _fakerName = Faker.Name.FullName();

    protected readonly DateTime _fakerDate = DateTime.Now;
}
