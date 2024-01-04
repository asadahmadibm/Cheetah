﻿global using Ardalis.GuardClauses;
global using AutoMapper;
global using Cheetah.Application.Business.Common.Interfaces;
global using Cheetah.Application.Business.Common.Models;
global using Cheetah.Application.Business.Repository;
global using Cheetah.Domain;
global using Cheetah.Domain.Common;
global using Cheetah.Domain.Constants;
global using Cheetah.Domain.Entities.Dimentions;
global using Cheetah.Domain.Entities.Facts;
global using Cheetah.Domain.Entities.Links;
global using Cheetah.Domain.Helper;
global using Cheetah.Infrastructure.Persistence.Data;
global using Cheetah.Infrastructure.Persistence.Data.Configurations;
global using Cheetah.Infrastructure.Persistence.Data.Interceptors;
global using FluentAssertions;
global using MediatR;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Identity;
global using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.ChangeTracking;
global using Microsoft.EntityFrameworkCore.Diagnostics;
global using Microsoft.EntityFrameworkCore.Metadata;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Logging;
global using Microsoft.IdentityModel.Tokens;
global using Serilog;
global using System.ComponentModel.DataAnnotations.Schema;
global using System.IdentityModel.Tokens.Jwt;
global using System.Reflection;
global using System.Security.Authentication;
global using System.Security.Claims;
global using System.Text;