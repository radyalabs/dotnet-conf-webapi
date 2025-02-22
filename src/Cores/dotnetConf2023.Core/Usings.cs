﻿global using FluentValidation;
global using dotnetConf2023.Core.Models;
global using dotnetConf2023.Domain.Entities;
global using dotnetConf2023.Domain.Entities.Enums;
global using dotnetConf2023.Domain.Exceptions;
global using dotnetConf2023.Domain.ValueObjects;
global using dotnetConf2023.Shared.Abstraction.Auth;
global using dotnetConf2023.Shared.Abstraction.Cache;
global using dotnetConf2023.Shared.Abstraction.Contexts;
global using dotnetConf2023.Shared.Abstraction.Databases;
global using dotnetConf2023.Shared.Abstraction.Encryption;
global using dotnetConf2023.Shared.Abstraction.Entities;
global using dotnetConf2023.Shared.Abstraction.Primitives;
global using dotnetConf2023.Shared.Abstraction.Storage;
global using dotnetConf2023.Shared.Abstraction.Time;
global using dotnetConf2023.Shared.Abstraction.Queries;
global using dotnetConf2023.Shared.Abstraction.Events;
global using dotnetConf2023.Shared.Abstraction.Models;
global using dotnetConf2023.Shared.Abstraction.Serialization;
global using dotnetConf2023.Shared.Infrastructure;
global using dotnetConf2023.Shared.Infrastructure.Auth;
global using dotnetConf2023.Shared.Infrastructure.Services;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.EntityFrameworkCore;
global using Mediator;