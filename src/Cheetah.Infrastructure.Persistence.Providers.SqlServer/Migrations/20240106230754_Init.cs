﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cheetah.Infrastructure.Persistence.Providers.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Dimentions");

            migrationBuilder.EnsureSchema(
                name: "Facts");

            migrationBuilder.EnsureSchema(
                name: "Links");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "D_CaseState",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 930, DateTimeKind.Unspecified).AddTicks(5061), new TimeSpan(0, -8, 0, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 930, DateTimeKind.Unspecified).AddTicks(5254), new TimeSpan(0, -8, 0, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("a349e660-f60f-4c9c-b0a5-383eba81b209")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_CaseState", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "D_Entity",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 930, DateTimeKind.Unspecified).AddTicks(6838), new TimeSpan(0, -8, 0, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 930, DateTimeKind.Unspecified).AddTicks(6964), new TimeSpan(0, -8, 0, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("5a951242-95c3-4f9c-a021-acef78c3a582")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Display = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Entity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "D_Operand",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(224), new TimeSpan(0, -8, 0, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(339), new TimeSpan(0, -8, 0, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("94c990e4-4381-4c50-abdc-6abb6b600a8f")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Operand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "D_Position",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(1813), new TimeSpan(0, -8, 0, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(1949), new TimeSpan(0, -8, 0, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("433b0bb2-e683-40a1-91b4-fc62e9eaf051")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Position", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "D_Process",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(3370), new TimeSpan(0, -8, 0, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(3532), new TimeSpan(0, -8, 0, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("3ae783c5-fd58-40cb-bf81-e22077edc5b2")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    ERP = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    RemoveRequestorApproval = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ShowSupport = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Process", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "D_Role",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(4962), new TimeSpan(0, -8, 0, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(5085), new TimeSpan(0, -8, 0, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("0fc224a9-2e3c-4784-b5d2-0a9fbbad8eba")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Independent = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    FixedRole = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "D_TagType",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(8259), new TimeSpan(0, -8, 0, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(8377), new TimeSpan(0, -8, 0, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("d9f0b267-edbf-4842-8aa5-29b54af80741")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_TagType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "D_UserInformation",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 932, DateTimeKind.Unspecified).AddTicks(1971), new TimeSpan(0, -8, 0, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 932, DateTimeKind.Unspecified).AddTicks(2083), new TimeSpan(0, -8, 0, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("95d44cfa-9e8e-4347-920f-3a612d784227")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NotifByEmail = table.Column<bool>(type: "bit", nullable: true),
                    NotifByMessenger = table.Column<bool>(type: "bit", nullable: true),
                    NotifByCell = table.Column<bool>(type: "bit", nullable: true),
                    ContactEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ContactMessenger = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ContactCell = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    UserPicture = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    NationalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InternalPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(215)", maxLength: 215, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_UserInformation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "D_WorkItemState",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 932, DateTimeKind.Unspecified).AddTicks(5948), new TimeSpan(0, -8, 0, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 932, DateTimeKind.Unspecified).AddTicks(6143), new TimeSpan(0, -8, 0, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("aaa90c59-b184-4777-bdbd-a1d660eb5fde")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_WorkItemState", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "F_Attachment",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 933, DateTimeKind.Unspecified).AddTicks(6591), new TimeSpan(0, -8, 0, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 933, DateTimeKind.Unspecified).AddTicks(6788), new TimeSpan(0, -8, 0, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("1b788d6c-b2fb-4b90-8733-a96e59e560c6")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValue: ""),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Attachment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "F_Scenario",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 935, DateTimeKind.Unspecified).AddTicks(3186), new TimeSpan(0, -8, 0, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 935, DateTimeKind.Unspecified).AddTicks(3332), new TimeSpan(0, -8, 0, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("8ffd2ed3-c180-4dac-acdf-6648f871fc66")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Scenario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "L_RolePosition",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 936, DateTimeKind.Unspecified).AddTicks(8604), new TimeSpan(0, -8, 0, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 936, DateTimeKind.Unspecified).AddTicks(8827), new TimeSpan(0, -8, 0, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("078a8c60-9b1d-4393-8df3-ac2b290173ab")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_RolePosition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_RolePosition_D_Position_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Position",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_RolePosition_D_Role_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Role",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "D_Tag",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(6631), new TimeSpan(0, -8, 0, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 931, DateTimeKind.Unspecified).AddTicks(6757), new TimeSpan(0, -8, 0, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("9ede2b65-043f-47e7-85e1-808e5503cbad")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    TagTypeId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Tag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_Tag_D_TagType_TagTypeId",
                        column: x => x.TagTypeId,
                        principalSchema: "Dimentions",
                        principalTable: "D_TagType",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "D_User",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 932, DateTimeKind.Unspecified).AddTicks(180), new TimeSpan(0, -8, 0, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 932, DateTimeKind.Unspecified).AddTicks(336), new TimeSpan(0, -8, 0, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("da5d262f-e155-4c1b-abf2-0b568f7b15a7")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    Domain = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    EnabledForAssignation = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    DelegateEnabled = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    CreatedCasesSkipAssigRules = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    IDPersonel = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    LDAPDescription = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DelegateId = table.Column<long>(type: "bigint", nullable: true),
                    UserInformationId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_D_User_D_UserInformation_UserInformationId",
                        column: x => x.UserInformationId,
                        principalSchema: "Dimentions",
                        principalTable: "D_UserInformation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_D_User_D_User_DelegateId",
                        column: x => x.DelegateId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_D_User_D_User_Parent_Id",
                        column: x => x.Parent_Id,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "L_ProcessScenario",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 936, DateTimeKind.Unspecified).AddTicks(5459), new TimeSpan(0, -8, 0, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 936, DateTimeKind.Unspecified).AddTicks(5684), new TimeSpan(0, -8, 0, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("95bb99dc-3477-4d61-8731-20c05237741a")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_ProcessScenario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_ProcessScenario_D_Process_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Process",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_ProcessScenario_F_Scenario_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_Scenario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    IU_UserId = table.Column<long>(type: "bigint", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_D_User_IU_UserId",
                        column: x => x.IU_UserId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_Case",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 933, DateTimeKind.Unspecified).AddTicks(9310), new TimeSpan(0, -8, 0, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 934, DateTimeKind.Unspecified).AddTicks(211), new TimeSpan(0, -8, 0, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("dcaca89a-3e19-43f2-9dd2-65a28f0172a0")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    RequestorId = table.Column<long>(type: "bigint", nullable: true),
                    CreatorId = table.Column<long>(type: "bigint", nullable: true),
                    CaseStateId = table.Column<long>(type: "bigint", nullable: true),
                    ProcessId = table.Column<long>(type: "bigint", nullable: true),
                    SelectedScenarioId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Case", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_Case_D_CaseState_CaseStateId",
                        column: x => x.CaseStateId,
                        principalSchema: "Dimentions",
                        principalTable: "D_CaseState",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Case_D_Process_ProcessId",
                        column: x => x.ProcessId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Process",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Case_D_User_CreatorId",
                        column: x => x.CreatorId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Case_D_User_RequestorId",
                        column: x => x.RequestorId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Case_F_Scenario_SelectedScenarioId",
                        column: x => x.SelectedScenarioId,
                        principalSchema: "Facts",
                        principalTable: "F_Scenario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "L_UserPosition",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 937, DateTimeKind.Unspecified).AddTicks(4141), new TimeSpan(0, -8, 0, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 937, DateTimeKind.Unspecified).AddTicks(4364), new TimeSpan(0, -8, 0, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("3b9d8c5b-ca2b-4412-b4b4-6d3c6eedd8f2")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_UserPosition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_UserPosition_D_Position_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Position",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_UserPosition_D_User_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "D_Location",
                schema: "Dimentions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 930, DateTimeKind.Unspecified).AddTicks(8554), new TimeSpan(0, -8, 0, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 930, DateTimeKind.Unspecified).AddTicks(8690), new TimeSpan(0, -8, 0, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("fa2d50f5-7c6a-4c95-adf6-28f0282d3f4d")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    EndorsementItemId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_D_Location", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "L_UserLocation",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 937, DateTimeKind.Unspecified).AddTicks(1096), new TimeSpan(0, -8, 0, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 937, DateTimeKind.Unspecified).AddTicks(1779), new TimeSpan(0, -8, 0, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("34c0a2ea-1327-4988-85e9-2769f1afe8d5")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_UserLocation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_UserLocation_D_Location_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Location",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_UserLocation_D_User_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_Condition",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 934, DateTimeKind.Unspecified).AddTicks(3314), new TimeSpan(0, -8, 0, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 934, DateTimeKind.Unspecified).AddTicks(4238), new TimeSpan(0, -8, 0, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("c4c238b5-08e8-4119-8ce3-545bef8e6efc")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    TagId = table.Column<long>(type: "bigint", nullable: true),
                    OperandId = table.Column<long>(type: "bigint", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScenarioId = table.Column<long>(type: "bigint", nullable: true),
                    CaseId = table.Column<long>(type: "bigint", nullable: true),
                    EndorsementItemId = table.Column<long>(type: "bigint", nullable: true),
                    D_UserId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Condition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_Condition_D_Operand_OperandId",
                        column: x => x.OperandId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Operand",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Condition_D_Tag_TagId",
                        column: x => x.TagId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Tag",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Condition_D_User_D_UserId",
                        column: x => x.D_UserId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Condition_F_Case_CaseId",
                        column: x => x.CaseId,
                        principalSchema: "Facts",
                        principalTable: "F_Case",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Condition_F_Scenario_ScenarioId",
                        column: x => x.ScenarioId,
                        principalSchema: "Facts",
                        principalTable: "F_Scenario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_Endorsement",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 934, DateTimeKind.Unspecified).AddTicks(7129), new TimeSpan(0, -8, 0, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 934, DateTimeKind.Unspecified).AddTicks(7350), new TimeSpan(0, -8, 0, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("39f7a327-55dc-47a7-93e4-263349016877")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    RoleId = table.Column<long>(type: "bigint", nullable: true),
                    ScenarioId = table.Column<long>(type: "bigint", nullable: true),
                    EndorsementItemId = table.Column<long>(type: "bigint", nullable: true),
                    ConditionId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_Endorsement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_Endorsement_D_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Role",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Endorsement_F_Condition_ConditionId",
                        column: x => x.ConditionId,
                        principalSchema: "Facts",
                        principalTable: "F_Condition",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_Endorsement_F_Scenario_ScenarioId",
                        column: x => x.ScenarioId,
                        principalSchema: "Facts",
                        principalTable: "F_Scenario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_EndorsementItem",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 935, DateTimeKind.Unspecified).AddTicks(413), new TimeSpan(0, -8, 0, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 935, DateTimeKind.Unspecified).AddTicks(608), new TimeSpan(0, -8, 0, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("8e3e1344-bc34-414a-a710-13e67b623886")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    CaseStateId = table.Column<long>(type: "bigint", nullable: true),
                    EndorsementId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_EndorsementItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_EndorsementItem_D_CaseState_CaseStateId",
                        column: x => x.CaseStateId,
                        principalSchema: "Dimentions",
                        principalTable: "D_CaseState",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_EndorsementItem_F_Endorsement_EndorsementId",
                        column: x => x.EndorsementId,
                        principalSchema: "Facts",
                        principalTable: "F_Endorsement",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "F_WorkItem",
                schema: "Facts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 935, DateTimeKind.Unspecified).AddTicks(6506), new TimeSpan(0, -8, 0, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 935, DateTimeKind.Unspecified).AddTicks(6744), new TimeSpan(0, -8, 0, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("603b6e0b-902f-429d-a6ca-c1d6363df6a5")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    EndorsementId = table.Column<long>(type: "bigint", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    CaseId = table.Column<long>(type: "bigint", nullable: true),
                    TagId = table.Column<long>(type: "bigint", nullable: true),
                    WorkItemStateId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_F_WorkItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_F_WorkItem_D_Tag_TagId",
                        column: x => x.TagId,
                        principalSchema: "Dimentions",
                        principalTable: "D_Tag",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_WorkItem_D_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_WorkItem_D_WorkItemState_WorkItemStateId",
                        column: x => x.WorkItemStateId,
                        principalSchema: "Dimentions",
                        principalTable: "D_WorkItemState",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_WorkItem_F_Case_CaseId",
                        column: x => x.CaseId,
                        principalSchema: "Facts",
                        principalTable: "F_Case",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_F_WorkItem_F_Endorsement_EndorsementId",
                        column: x => x.EndorsementId,
                        principalSchema: "Facts",
                        principalTable: "F_Endorsement",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "L_EndorsementUser",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 936, DateTimeKind.Unspecified).AddTicks(2316), new TimeSpan(0, -8, 0, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 936, DateTimeKind.Unspecified).AddTicks(2540), new TimeSpan(0, -8, 0, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("c92d0e8a-3186-4fea-9f13-00b062c28f25")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_EndorsementUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_EndorsementUser_D_User_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Dimentions",
                        principalTable: "D_User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_EndorsementUser_F_Endorsement_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Facts",
                        principalTable: "F_Endorsement",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "L_EndorsementItemEndorsement",
                schema: "Links",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SortIndex = table.Column<long>(type: "bigint", nullable: true, defaultValue: 0L),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    DisplayName = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Description = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: true, defaultValue: ""),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 935, DateTimeKind.Unspecified).AddTicks(9222), new TimeSpan(0, -8, 0, 0, 0))),
                    LastModified = table.Column<DateTimeOffset>(type: "datetimeoffset", rowVersion: true, nullable: true, defaultValue: new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 936, DateTimeKind.Unspecified).AddTicks(3), new TimeSpan(0, -8, 0, 0, 0))),
                    GuidRecord = table.Column<Guid>(type: "uniqueidentifier", nullable: true, defaultValue: new Guid("3382c08d-e7f6-4c23-9886-293f66792592")),
                    EnableRecord = table.Column<bool>(type: "bit", nullable: true, defaultValue: true),
                    ERPCode = table.Column<long>(type: "bigint", nullable: true),
                    FirstId = table.Column<long>(type: "bigint", nullable: true),
                    SecondId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_L_EndorsementItemEndorsement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_L_EndorsementItemEndorsement_F_EndorsementItem_FirstId",
                        column: x => x.FirstId,
                        principalSchema: "Facts",
                        principalTable: "F_EndorsementItem",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_L_EndorsementItemEndorsement_F_Endorsement_SecondId",
                        column: x => x.SecondId,
                        principalSchema: "Facts",
                        principalTable: "F_Endorsement",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_CaseState",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModifiedBy", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 484, DateTimeKind.Unspecified).AddTicks(5342), new TimeSpan(0, -8, 0, 0, 0)), null, "در دست بررسی", 1L, true, new Guid("f9b55a52-85ac-4ff6-b1f9-8888ef08a1bc"), null, "Ongoing", 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 484, DateTimeKind.Unspecified).AddTicks(5349), new TimeSpan(0, -8, 0, 0, 0)), null, "منتظر بازنگری", 2L, true, new Guid("73e8937a-3109-4525-9657-b910a139cdbb"), null, "Editing", 2L },
                    { 3L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 484, DateTimeKind.Unspecified).AddTicks(5352), new TimeSpan(0, -8, 0, 0, 0)), null, "کامل شده", 3L, true, new Guid("a96b922c-816b-48f8-80c7-954d08a72625"), null, "Completed", 3L },
                    { 4L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 484, DateTimeKind.Unspecified).AddTicks(5355), new TimeSpan(0, -8, 0, 0, 0)), null, "عدم تایید", 4L, true, new Guid("05fbc29d-ac25-4098-b269-2eae688612bf"), null, "Rejected", 4L },
                    { 5L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 484, DateTimeKind.Unspecified).AddTicks(5358), new TimeSpan(0, -8, 0, 0, 0)), null, "ابطال شده", 5L, true, new Guid("ecf70062-cb86-40ff-b15c-2232c37f76e3"), null, "Aborted", 5L }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Entity",
                columns: new[] { "Id", "Created", "CreatedBy", "Display", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModifiedBy", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 101L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 485, DateTimeKind.Unspecified).AddTicks(5278), new TimeSpan(0, -8, 0, 0, 0)), null, false, "نوع تگ‌ها(Dimentions)", 101L, true, new Guid("2a25a773-dfab-4f8e-9e96-401e7b6e3f1f"), null, "D_TagType", 101L },
                    { 102L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4645), new TimeSpan(0, -8, 0, 0, 0)), null, false, "موقعیت‌ها(Dimentions)", 102L, true, new Guid("90d2730d-c665-479e-b303-4ec313ea8d83"), null, "D_Location", 102L },
                    { 103L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4686), new TimeSpan(0, -8, 0, 0, 0)), null, false, "عملگرها(Dimentions)", 103L, true, new Guid("4549c53f-1458-4201-bbfb-35b89fabc26a"), null, "D_Operand", 103L },
                    { 104L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4700), new TimeSpan(0, -8, 0, 0, 0)), null, true, "تگ‌ها(Dimentions)", 104L, true, new Guid("4c6865ba-f268-435f-8c9f-3cb178253f8e"), null, "D_Tag", 104L },
                    { 105L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4707), new TimeSpan(0, -8, 0, 0, 0)), null, false, "سمت‌ها(Dimentions)", 105L, true, new Guid("da342a97-bbb4-4b69-bbd6-d77bc63fa652"), null, "D_Position", 105L },
                    { 106L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4713), new TimeSpan(0, -8, 0, 0, 0)), null, false, "وضعیت فرآیندها(Dimentions)", 106L, true, new Guid("f8adba07-a42e-41f7-8fec-e2a8d0c46410"), null, "D_CaseState", 106L },
                    { 107L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4719), new TimeSpan(0, -8, 0, 0, 0)), null, true, "فرآیند‌ها(Dimentions)", 107L, true, new Guid("e7abda66-a062-458a-ad42-77348e03ab54"), null, "D_Process", 107L },
                    { 108L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4725), new TimeSpan(0, -8, 0, 0, 0)), null, true, "نقش‌ها(Dimentions)", 108L, true, new Guid("5ee01315-c82c-4fa7-b7e9-eda54e95524d"), null, "D_Role", 108L },
                    { 109L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4731), new TimeSpan(0, -8, 0, 0, 0)), null, true, "کاربران(Dimentions)", 109L, true, new Guid("1df5db69-4729-49a8-8b73-e501b6b892ea"), null, "D_User", 109L },
                    { 112L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4745), new TimeSpan(0, -8, 0, 0, 0)), null, false, "اطلاعات کاربرها(Facts)", 112L, true, new Guid("3d74d4bd-62e3-4f61-be9d-e09218e48b93"), null, "D_UserInformation", 112L },
                    { 200L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4751), new TimeSpan(0, -8, 0, 0, 0)), null, false, "تمام تاییدها(Facts)", 200L, true, new Guid("301f96d5-929e-4bea-b287-e5c862b58280"), null, "F_WorkItem", 200L },
                    { 202L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4758), new TimeSpan(0, -8, 0, 0, 0)), null, false, "ضمیمه‌ها(Facts)", 202L, true, new Guid("a69ae0f4-aba4-4fc6-9e7c-d111e1b28716"), null, "F_Attachment", 202L },
                    { 203L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4762), new TimeSpan(0, -8, 0, 0, 0)), null, false, "لیست تخصیص‌ها(Facts)", 203L, true, new Guid("f53264ef-2f7a-49a1-ad58-ed70b793bb5c"), null, "F_Endorsement", 203L },
                    { 204L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4767), new TimeSpan(0, -8, 0, 0, 0)), null, false, "لیست شرط‌ها(Facts)", 204L, true, new Guid("a18aa156-e321-4fb8-a219-0c8e77c12d60"), null, "F_Condition", 204L },
                    { 205L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4773), new TimeSpan(0, -8, 0, 0, 0)), null, false, "اطلاعات درخواست‌ها(Facts)", 205L, true, new Guid("ef39a25a-7bf4-4109-a097-b03502ca7169"), null, "F_Case", 205L },
                    { 206L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4779), new TimeSpan(0, -8, 0, 0, 0)), null, true, "سناریوها(Facts)", 206L, true, new Guid("e94d3ad8-bd71-48cb-a944-c1d074d72fe0"), null, "F_Scenario", 206L },
                    { 300L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4783), new TimeSpan(0, -8, 0, 0, 0)), null, false, "نقش-سمت(Links)", 300L, true, new Guid("9cbfb815-e694-4a66-90ce-fcfdded2d146"), null, "L_RolePosition", 300L },
                    { 301L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4821), new TimeSpan(0, -8, 0, 0, 0)), null, false, "فرآیند-سناریو(Links)", 301L, true, new Guid("07cd51bd-08b9-4778-92ff-cf971773ed1b"), null, "L_ProcessScenario", 301L },
                    { 302L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4828), new TimeSpan(0, -8, 0, 0, 0)), null, false, "کاربر-موقعیت(Links)", 302L, true, new Guid("396a8843-e13c-4400-bdde-e919edc33248"), null, "L_UserLocation", 302L },
                    { 303L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(4835), new TimeSpan(0, -8, 0, 0, 0)), null, false, "کاربر-سمت(Links)", 303L, true, new Guid("cf15f1e6-67eb-4b2e-8bd3-588078bbce1f"), null, "L_UserPosition", 303L }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Location",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "EndorsementItemId", "GuidRecord", "LastModifiedBy", "Name", "SortIndex" },
                values: new object[] { 1L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(5860), new TimeSpan(0, -8, 0, 0, 0)), null, "ÝÇÑÓ", 1L, true, null, new Guid("99a822eb-4af1-4baf-8603-b58646e8ccc0"), null, "Fars", 1L });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Operand",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModifiedBy", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(7810), new TimeSpan(0, -8, 0, 0, 0)), null, "مساوی", 1L, true, new Guid("e9b71743-1dc3-45ac-97b9-0700850954ba"), null, "=", 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(7820), new TimeSpan(0, -8, 0, 0, 0)), null, "مخالف", 2L, true, new Guid("1924e203-98dc-4be5-a01f-f8b4c7c2f8ee"), null, "!=", 2L },
                    { 3L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(7823), new TimeSpan(0, -8, 0, 0, 0)), null, "بزگتر از", 3L, true, new Guid("d8c56a1c-d13d-4539-bef0-0e12776f95b6"), null, ">", 3L },
                    { 4L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(7826), new TimeSpan(0, -8, 0, 0, 0)), null, "بزرگتر و مساوی", 4L, true, new Guid("71702447-b68f-44f2-ac91-f7cd090590f5"), null, ">=", 4L },
                    { 5L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(7830), new TimeSpan(0, -8, 0, 0, 0)), null, " کوچکتر از", 5L, true, new Guid("7a97012b-ff4a-4e9a-8876-693a1b2313cd"), null, "<", 5L },
                    { 6L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(7832), new TimeSpan(0, -8, 0, 0, 0)), null, "کوچکتر و مساوی", 6L, true, new Guid("acb7c691-b021-48ba-abd6-f2b497a555b3"), null, "<=", 6L }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Position",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModifiedBy", "Name", "SortIndex" },
                values: new object[] { 1L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(9086), new TimeSpan(0, -8, 0, 0, 0)), null, "کارشناس", 1L, true, new Guid("14142346-6da3-4eb3-8be8-df52f7baf63e"), null, "Expert", 1L });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Process",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERP", "ERPCode", "EnableRecord", "GuidRecord", "LastModifiedBy", "Name", "RemoveRequestorApproval", "ShowSupport", "SortIndex" },
                values: new object[] { 1L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 486, DateTimeKind.Unspecified).AddTicks(9846), new TimeSpan(0, -8, 0, 0, 0)), null, "فرآیند نمونه", true, 1L, true, new Guid("ed2773ae-cf8c-4442-a838-0533cea79e03"), null, "SampleProcess", true, true, 1L });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Role",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "FixedRole", "GuidRecord", "LastModifiedBy", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 100L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 487, DateTimeKind.Unspecified).AddTicks(826), new TimeSpan(0, -8, 0, 0, 0)), null, "درخواست کننده", 100L, true, true, new Guid("763e24a0-73c6-483d-87df-948b13f8e182"), null, "Requestor", 1L },
                    { 101L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 487, DateTimeKind.Unspecified).AddTicks(963), new TimeSpan(0, -8, 0, 0, 0)), null, "مدیر درخواست کننده", 101L, true, true, new Guid("3bac8a9c-a9a4-4a84-87db-fd27bf6efe16"), null, "RequestorManager", 2L }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_TagType",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModifiedBy", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 487, DateTimeKind.Unspecified).AddTicks(4675), new TimeSpan(0, -8, 0, 0, 0)), null, "عددی", 1L, true, new Guid("1a9e59e5-807f-42e2-84f2-d1529a0e2976"), null, "Numberic", 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 487, DateTimeKind.Unspecified).AddTicks(4713), new TimeSpan(0, -8, 0, 0, 0)), null, "دودویی", 2L, true, new Guid("70d16c68-e9a9-4593-8343-d230f0deb8a1"), null, "Boolean", 2L },
                    { 3L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 487, DateTimeKind.Unspecified).AddTicks(4724), new TimeSpan(0, -8, 0, 0, 0)), null, "تاریخ", 3L, true, new Guid("63c162f1-79d2-4fba-8515-6eccd25134bb"), null, "Date", 3L },
                    { 4L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 487, DateTimeKind.Unspecified).AddTicks(4728), new TimeSpan(0, -8, 0, 0, 0)), null, "حروف", 4L, true, new Guid("4e38ca8a-abad-49c7-95bc-f7007565f9e8"), null, "String", 4L }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_User",
                columns: new[] { "Id", "Created", "CreatedBy", "DelegateId", "DisplayName", "Domain", "ERPCode", "EnableRecord", "GuidRecord", "IDPersonel", "LDAPDescription", "LastModifiedBy", "Name", "Parent_Id", "SortIndex", "UserInformationId" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 487, DateTimeKind.Unspecified).AddTicks(8447), new TimeSpan(0, -8, 0, 0, 0)), null, null, "محمد شریفی", null, 1L, true, new Guid("bbc942bf-5bab-477d-baec-184ecd9d4a3c"), null, null, null, "m.sharifi", null, 1L, null },
                    { 2L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 487, DateTimeKind.Unspecified).AddTicks(8489), new TimeSpan(0, -8, 0, 0, 0)), null, null, "امین شریفی", null, 2L, true, new Guid("bc40a64b-1373-40b8-b0cc-e4e16eee5a35"), null, null, null, "a.sharifi", null, 2L, null }
                });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_WorkItemState",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModifiedBy", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 487, DateTimeKind.Unspecified).AddTicks(9847), new TimeSpan(0, -8, 0, 0, 0)), null, "صندوق ورودی", 1L, true, new Guid("83df011b-fbd7-4509-a37f-f73e0f111957"), null, "Inbox", 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 487, DateTimeKind.Unspecified).AddTicks(9855), new TimeSpan(0, -8, 0, 0, 0)), null, "ارسال شده", 2L, true, new Guid("67786412-44fd-4db3-bf37-84bdf5d788ac"), null, "Sent", 2L },
                    { 3L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 487, DateTimeKind.Unspecified).AddTicks(9859), new TimeSpan(0, -8, 0, 0, 0)), null, "خارج شده", 3L, true, new Guid("fed94a08-269c-4a84-844a-5cab9323799e"), null, "Exit", 3L },
                    { 4L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 487, DateTimeKind.Unspecified).AddTicks(9862), new TimeSpan(0, -8, 0, 0, 0)), null, "آینده", 4L, true, new Guid("2b4a263a-a43a-4152-89d6-71c08a6d25f7"), null, "Future", 4L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Scenario",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModifiedBy", "Name", "SortIndex" },
                values: new object[] { 1L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 484, DateTimeKind.Unspecified).AddTicks(3956), new TimeSpan(0, -8, 0, 0, 0)), null, "سناریو نمونه", 1L, true, new Guid("3e6cb777-9cee-4b75-b118-022fbde22b2f"), null, "SampleScenario", 1L });

            migrationBuilder.InsertData(
                schema: "Dimentions",
                table: "D_Tag",
                columns: new[] { "Id", "Created", "CreatedBy", "Description", "DisplayName", "ERPCode", "EnableRecord", "GuidRecord", "LastModifiedBy", "Name", "SortIndex", "TagTypeId" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 487, DateTimeKind.Unspecified).AddTicks(2699), new TimeSpan(0, -8, 0, 0, 0)), null, "عددی", "مرکز", 1L, true, new Guid("ccc900c8-4021-4589-ba87-ebb6df41669f"), null, "D_Location", 1L, 1L },
                    { 201L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 487, DateTimeKind.Unspecified).AddTicks(2994), new TimeSpan(0, -8, 0, 0, 0)), null, "دودویی", "تایید", 201L, true, new Guid("5e957543-c459-46ff-ad1c-8a642eaeef30"), null, "Approve", 2L, 2L },
                    { 202L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 487, DateTimeKind.Unspecified).AddTicks(2999), new TimeSpan(0, -8, 0, 0, 0)), null, "دودویی", "عدم تایید", 202L, true, new Guid("49ab9698-fcea-490b-a34d-c5606a7216c4"), null, "Reject", 3L, 2L },
                    { 203L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 487, DateTimeKind.Unspecified).AddTicks(3003), new TimeSpan(0, -8, 0, 0, 0)), null, "دودویی", "بازنگری", 203L, true, new Guid("aec2ebf6-3ecd-49d7-85b9-6dabc03522e7"), null, "Revise", 4L, 2L },
                    { 301L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 487, DateTimeKind.Unspecified).AddTicks(3011), new TimeSpan(0, -8, 0, 0, 0)), null, "عددی", "مبلغ", 301L, true, new Guid("348062ec-01fc-4ee2-9945-f191a2b714c7"), null, "Price", 5L, 1L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Endorsement",
                columns: new[] { "Id", "ConditionId", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "EndorsementItemId", "GuidRecord", "LastModifiedBy", "Name", "RoleId", "ScenarioId", "SortIndex" },
                values: new object[,]
                {
                    { 1L, null, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 484, DateTimeKind.Unspecified).AddTicks(375), new TimeSpan(0, -8, 0, 0, 0)), null, "ثبت درخواست", 1L, true, null, new Guid("be60350a-ad99-4385-b77f-f8b7b20454bd"), null, "Sample_Scenario__Requestor", 100L, 1L, 1L },
                    { 2L, null, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 484, DateTimeKind.Unspecified).AddTicks(619), new TimeSpan(0, -8, 0, 0, 0)), null, "بررسی درخواست", 2L, true, null, new Guid("6d59ef28-9acd-4ca3-ad99-e70f83602295"), null, "Sample_Scenario__RequestorManager", 101L, 1L, 2L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_ProcessScenario",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "FirstId", "GuidRecord", "LastModifiedBy", "Name", "SecondId", "SortIndex" },
                values: new object[] { 1L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 483, DateTimeKind.Unspecified).AddTicks(2876), new TimeSpan(0, -8, 0, 0, 0)), null, "فرآیند نمونه-سناریو نمونه", 1L, true, 1L, new Guid("25140dff-e8ac-4d99-8fb4-e940fb43dcd7"), null, "SampleProcess_SampleScenario", 1L, 1L });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_RolePosition",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "FirstId", "GuidRecord", "LastModifiedBy", "Name", "SecondId", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 483, DateTimeKind.Unspecified).AddTicks(4019), new TimeSpan(0, -8, 0, 0, 0)), null, "درخواست کننده-کارشناس", 1L, true, 100L, new Guid("6f93b1dc-6070-4d19-a782-efa6e71ab661"), null, "Requestor_Expert", 1L, 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 483, DateTimeKind.Unspecified).AddTicks(4063), new TimeSpan(0, -8, 0, 0, 0)), null, "مدیر درخواست کننده-کارشناس", 2L, true, 101L, new Guid("276c27cc-26eb-4719-9743-6d0476562b55"), null, "RequestorManager_Expert", 1L, 2L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_UserLocation",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "FirstId", "GuidRecord", "LastModifiedBy", "Name", "SecondId", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 483, DateTimeKind.Unspecified).AddTicks(4995), new TimeSpan(0, -8, 0, 0, 0)), null, "محمد شریفی-فارس", 1L, true, 1L, new Guid("77c104f2-0a5f-4ba9-a08a-7c57c01c91d3"), null, "m_sharifi__Fars", 1L, 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 483, DateTimeKind.Unspecified).AddTicks(5002), new TimeSpan(0, -8, 0, 0, 0)), null, "امین شریفی-فارس", 2L, true, 2L, new Guid("4cfcc293-799b-4907-9ba4-84e3540b5e26"), null, "a_sharifi__Fars", 1L, 2L }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_UserPosition",
                columns: new[] { "Id", "Created", "CreatedBy", "DisplayName", "ERPCode", "EnableRecord", "FirstId", "GuidRecord", "LastModifiedBy", "Name", "SecondId", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 483, DateTimeKind.Unspecified).AddTicks(5887), new TimeSpan(0, -8, 0, 0, 0)), null, "محمد شریفی-کارشناس", 1L, true, 1L, new Guid("3b7a419f-1640-4d1d-973c-af646791a23f"), null, "Requestor_Expert", 1L, 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 483, DateTimeKind.Unspecified).AddTicks(5893), new TimeSpan(0, -8, 0, 0, 0)), null, "امین شریفی-کارشناس", 2L, true, 2L, new Guid("91a54290-50bf-44fb-bf33-8e5936a38a84"), null, "RequestorManager_Expert", 1L, 2L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Condition",
                columns: new[] { "Id", "CaseId", "Created", "CreatedBy", "D_UserId", "DisplayName", "ERPCode", "EnableRecord", "EndorsementItemId", "GuidRecord", "LastModifiedBy", "Name", "OperandId", "ScenarioId", "SortIndex", "TagId", "Value" },
                values: new object[] { 1L, null, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 483, DateTimeKind.Unspecified).AddTicks(8069), new TimeSpan(0, -8, 0, 0, 0)), null, null, "مبلغ", 1L, true, null, new Guid("5b78510b-8713-4fc7-a0fb-605b1bd51eed"), null, "Price", 3L, 1L, 1L, 301L, "0" });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_EndorsementItem",
                columns: new[] { "Id", "CaseStateId", "Created", "CreatedBy", "ERPCode", "EnableRecord", "EndorsementId", "GuidRecord", "LastModifiedBy", "Name", "SortIndex" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 484, DateTimeKind.Unspecified).AddTicks(2689), new TimeSpan(0, -8, 0, 0, 0)), null, 1L, true, 1L, new Guid("348f1d82-f3a6-4dfc-b5c3-b2229db8096a"), null, "one", 1L },
                    { 2L, 3L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 484, DateTimeKind.Unspecified).AddTicks(2909), new TimeSpan(0, -8, 0, 0, 0)), null, 2L, true, 2L, new Guid("890ec66c-cbdc-47cc-a0ce-1d7134482a81"), null, "two", 1L },
                    { 3L, 2L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 484, DateTimeKind.Unspecified).AddTicks(2915), new TimeSpan(0, -8, 0, 0, 0)), null, 3L, true, 2L, new Guid("ead74cd3-0e98-4ee9-819e-b37444e13425"), null, "Three", 2L },
                    { 4L, 4L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 484, DateTimeKind.Unspecified).AddTicks(2918), new TimeSpan(0, -8, 0, 0, 0)), null, 4L, true, 2L, new Guid("aa43b198-8dfb-423d-b129-9afe99785438"), null, "Four", 3L }
                });

            migrationBuilder.InsertData(
                schema: "Facts",
                table: "F_Condition",
                columns: new[] { "Id", "CaseId", "Created", "CreatedBy", "D_UserId", "ERPCode", "EnableRecord", "EndorsementItemId", "GuidRecord", "LastModifiedBy", "Name", "OperandId", "ScenarioId", "SortIndex", "TagId", "Value" },
                values: new object[,]
                {
                    { 2L, null, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 483, DateTimeKind.Unspecified).AddTicks(8549), new TimeSpan(0, -8, 0, 0, 0)), null, null, 2L, true, 1L, new Guid("d82cc118-18c9-43da-bfd5-43c668cfda2c"), null, "One", 1L, null, 1L, 201L, "0" },
                    { 3L, null, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 483, DateTimeKind.Unspecified).AddTicks(8632), new TimeSpan(0, -8, 0, 0, 0)), null, null, 3L, true, 2L, new Guid("5a09b9af-01b0-45d1-8568-7519fcac0ca2"), null, "Two", 1L, null, 1L, 201L, "0" },
                    { 4L, null, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 483, DateTimeKind.Unspecified).AddTicks(8639), new TimeSpan(0, -8, 0, 0, 0)), null, null, 4L, true, 3L, new Guid("b1edb511-ee70-48cb-aff7-0c601033aa36"), null, "Three", 1L, null, 1L, 203L, "0" },
                    { 5L, null, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 483, DateTimeKind.Unspecified).AddTicks(8647), new TimeSpan(0, -8, 0, 0, 0)), null, null, 5L, true, 4L, new Guid("203bee86-9029-4e68-9651-aa91d6aef2ca"), null, "Four", 1L, null, 1L, 202L, "1" }
                });

            migrationBuilder.InsertData(
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                columns: new[] { "Id", "Created", "CreatedBy", "ERPCode", "EnableRecord", "FirstId", "GuidRecord", "LastModifiedBy", "Name", "SecondId", "SortIndex" },
                values: new object[,]
                {
                    { 1L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 482, DateTimeKind.Unspecified).AddTicks(8432), new TimeSpan(0, -8, 0, 0, 0)), null, 1L, true, 1L, new Guid("ec2d988d-ac03-4059-b9e6-d2f9df9c4028"), null, "One", 2L, 1L },
                    { 2L, new DateTimeOffset(new DateTime(2024, 1, 6, 15, 7, 52, 482, DateTimeKind.Unspecified).AddTicks(9193), new TimeSpan(0, -8, 0, 0, 0)), null, 2L, true, 3L, new Guid("aac263a7-6497-4a0b-b3ad-1cbb7b767603"), null, "Two", 1L, 2L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_IU_UserId",
                table: "AspNetUsers",
                column: "IU_UserId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_D_CaseState_Created",
                schema: "Dimentions",
                table: "D_CaseState",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_CaseState_EnableRecord",
                schema: "Dimentions",
                table: "D_CaseState",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_CaseState_ERPCode",
                schema: "Dimentions",
                table: "D_CaseState",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_CaseState_LastModified",
                schema: "Dimentions",
                table: "D_CaseState",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_CaseState_Name",
                schema: "Dimentions",
                table: "D_CaseState",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Entity_Created",
                schema: "Dimentions",
                table: "D_Entity",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Entity_Display",
                schema: "Dimentions",
                table: "D_Entity",
                column: "Display");

            migrationBuilder.CreateIndex(
                name: "IX_D_Entity_EnableRecord",
                schema: "Dimentions",
                table: "D_Entity",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Entity_ERPCode",
                schema: "Dimentions",
                table: "D_Entity",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Entity_LastModified",
                schema: "Dimentions",
                table: "D_Entity",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Entity_Name",
                schema: "Dimentions",
                table: "D_Entity",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_Created",
                schema: "Dimentions",
                table: "D_Location",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_EnableRecord",
                schema: "Dimentions",
                table: "D_Location",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_EndorsementItemId",
                schema: "Dimentions",
                table: "D_Location",
                column: "EndorsementItemId");

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_ERPCode",
                schema: "Dimentions",
                table: "D_Location",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_LastModified",
                schema: "Dimentions",
                table: "D_Location",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Location_Name",
                schema: "Dimentions",
                table: "D_Location",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_Created",
                schema: "Dimentions",
                table: "D_Operand",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_EnableRecord",
                schema: "Dimentions",
                table: "D_Operand",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_ERPCode",
                schema: "Dimentions",
                table: "D_Operand",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_LastModified",
                schema: "Dimentions",
                table: "D_Operand",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Operand_Name",
                schema: "Dimentions",
                table: "D_Operand",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_Created",
                schema: "Dimentions",
                table: "D_Position",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_EnableRecord",
                schema: "Dimentions",
                table: "D_Position",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_ERPCode",
                schema: "Dimentions",
                table: "D_Position",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_LastModified",
                schema: "Dimentions",
                table: "D_Position",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Position_Name",
                schema: "Dimentions",
                table: "D_Position",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_Created",
                schema: "Dimentions",
                table: "D_Process",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_EnableRecord",
                schema: "Dimentions",
                table: "D_Process",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_ERPCode",
                schema: "Dimentions",
                table: "D_Process",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_LastModified",
                schema: "Dimentions",
                table: "D_Process",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Process_Name",
                schema: "Dimentions",
                table: "D_Process",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_Created",
                schema: "Dimentions",
                table: "D_Role",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_EnableRecord",
                schema: "Dimentions",
                table: "D_Role",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_ERPCode",
                schema: "Dimentions",
                table: "D_Role",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_Independent",
                schema: "Dimentions",
                table: "D_Role",
                column: "Independent");

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_LastModified",
                schema: "Dimentions",
                table: "D_Role",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Role_Name",
                schema: "Dimentions",
                table: "D_Role",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_Created",
                schema: "Dimentions",
                table: "D_Tag",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_EnableRecord",
                schema: "Dimentions",
                table: "D_Tag",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_ERPCode",
                schema: "Dimentions",
                table: "D_Tag",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_LastModified",
                schema: "Dimentions",
                table: "D_Tag",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_Name",
                schema: "Dimentions",
                table: "D_Tag",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_Tag_TagTypeId",
                schema: "Dimentions",
                table: "D_Tag",
                column: "TagTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_D_TagType_Created",
                schema: "Dimentions",
                table: "D_TagType",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_TagType_EnableRecord",
                schema: "Dimentions",
                table: "D_TagType",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_TagType_ERPCode",
                schema: "Dimentions",
                table: "D_TagType",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_TagType_LastModified",
                schema: "Dimentions",
                table: "D_TagType",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_TagType_Name",
                schema: "Dimentions",
                table: "D_TagType",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_Created",
                schema: "Dimentions",
                table: "D_User",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_DelegateId",
                schema: "Dimentions",
                table: "D_User",
                column: "DelegateId");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_EnableRecord",
                schema: "Dimentions",
                table: "D_User",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_ERPCode",
                schema: "Dimentions",
                table: "D_User",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_LastModified",
                schema: "Dimentions",
                table: "D_User",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_Name",
                schema: "Dimentions",
                table: "D_User",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_User_Parent_Id",
                schema: "Dimentions",
                table: "D_User",
                column: "Parent_Id");

            migrationBuilder.CreateIndex(
                name: "IX_D_User_UserInformationId",
                schema: "Dimentions",
                table: "D_User",
                column: "UserInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_D_UserInformation_Created",
                schema: "Dimentions",
                table: "D_UserInformation",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_UserInformation_EnableRecord",
                schema: "Dimentions",
                table: "D_UserInformation",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_UserInformation_ERPCode",
                schema: "Dimentions",
                table: "D_UserInformation",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_UserInformation_LastModified",
                schema: "Dimentions",
                table: "D_UserInformation",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_UserInformation_Name",
                schema: "Dimentions",
                table: "D_UserInformation",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_WorkItemState_Created",
                schema: "Dimentions",
                table: "D_WorkItemState",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_WorkItemState_EnableRecord",
                schema: "Dimentions",
                table: "D_WorkItemState",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_WorkItemState_ERPCode",
                schema: "Dimentions",
                table: "D_WorkItemState",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_WorkItemState_LastModified",
                schema: "Dimentions",
                table: "D_WorkItemState",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_D_WorkItemState_Name",
                schema: "Dimentions",
                table: "D_WorkItemState",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_Created",
                schema: "Facts",
                table: "F_Attachment",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_EnableRecord",
                schema: "Facts",
                table: "F_Attachment",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_ERPCode",
                schema: "Facts",
                table: "F_Attachment",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_LastModified",
                schema: "Facts",
                table: "F_Attachment",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Attachment_Name",
                schema: "Facts",
                table: "F_Attachment",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_CaseStateId",
                schema: "Facts",
                table: "F_Case",
                column: "CaseStateId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_Created",
                schema: "Facts",
                table: "F_Case",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_CreatorId",
                schema: "Facts",
                table: "F_Case",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_EnableRecord",
                schema: "Facts",
                table: "F_Case",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_ERPCode",
                schema: "Facts",
                table: "F_Case",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_LastModified",
                schema: "Facts",
                table: "F_Case",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_Name",
                schema: "Facts",
                table: "F_Case",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_ProcessId",
                schema: "Facts",
                table: "F_Case",
                column: "ProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_RequestorId",
                schema: "Facts",
                table: "F_Case",
                column: "RequestorId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Case_SelectedScenarioId",
                schema: "Facts",
                table: "F_Case",
                column: "SelectedScenarioId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_CaseId",
                schema: "Facts",
                table: "F_Condition",
                column: "CaseId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_Created",
                schema: "Facts",
                table: "F_Condition",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_D_UserId",
                schema: "Facts",
                table: "F_Condition",
                column: "D_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_EnableRecord",
                schema: "Facts",
                table: "F_Condition",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_EndorsementItemId",
                schema: "Facts",
                table: "F_Condition",
                column: "EndorsementItemId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_ERPCode",
                schema: "Facts",
                table: "F_Condition",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_LastModified",
                schema: "Facts",
                table: "F_Condition",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_Name",
                schema: "Facts",
                table: "F_Condition",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_OperandId",
                schema: "Facts",
                table: "F_Condition",
                column: "OperandId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_ScenarioId",
                schema: "Facts",
                table: "F_Condition",
                column: "ScenarioId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Condition_TagId",
                schema: "Facts",
                table: "F_Condition",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_ConditionId",
                schema: "Facts",
                table: "F_Endorsement",
                column: "ConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_Created",
                schema: "Facts",
                table: "F_Endorsement",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_EnableRecord",
                schema: "Facts",
                table: "F_Endorsement",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_EndorsementItemId",
                schema: "Facts",
                table: "F_Endorsement",
                column: "EndorsementItemId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_ERPCode",
                schema: "Facts",
                table: "F_Endorsement",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_LastModified",
                schema: "Facts",
                table: "F_Endorsement",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_Name",
                schema: "Facts",
                table: "F_Endorsement",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_RoleId",
                schema: "Facts",
                table: "F_Endorsement",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_F_Endorsement_ScenarioId",
                schema: "Facts",
                table: "F_Endorsement",
                column: "ScenarioId");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementItem_CaseStateId",
                schema: "Facts",
                table: "F_EndorsementItem",
                column: "CaseStateId");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementItem_Created",
                schema: "Facts",
                table: "F_EndorsementItem",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementItem_EnableRecord",
                schema: "Facts",
                table: "F_EndorsementItem",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementItem_EndorsementId",
                schema: "Facts",
                table: "F_EndorsementItem",
                column: "EndorsementId");

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementItem_ERPCode",
                schema: "Facts",
                table: "F_EndorsementItem",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementItem_LastModified",
                schema: "Facts",
                table: "F_EndorsementItem",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_EndorsementItem_Name",
                schema: "Facts",
                table: "F_EndorsementItem",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_Created",
                schema: "Facts",
                table: "F_Scenario",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_EnableRecord",
                schema: "Facts",
                table: "F_Scenario",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_ERPCode",
                schema: "Facts",
                table: "F_Scenario",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_LastModified",
                schema: "Facts",
                table: "F_Scenario",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_Scenario_Name",
                schema: "Facts",
                table: "F_Scenario",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_CaseId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "CaseId");

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_Created",
                schema: "Facts",
                table: "F_WorkItem",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_EnableRecord",
                schema: "Facts",
                table: "F_WorkItem",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_EndorsementId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "EndorsementId");

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_ERPCode",
                schema: "Facts",
                table: "F_WorkItem",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_LastModified",
                schema: "Facts",
                table: "F_WorkItem",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_Name",
                schema: "Facts",
                table: "F_WorkItem",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_TagId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_UserId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_F_WorkItem_WorkItemStateId",
                schema: "Facts",
                table: "F_WorkItem",
                column: "WorkItemStateId");

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementItemEndorsement_Created",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementItemEndorsement_EnableRecord",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementItemEndorsement_ERPCode",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementItemEndorsement_FirstId",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementItemEndorsement_LastModified",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementItemEndorsement_Name",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementItemEndorsement_SecondId",
                schema: "Links",
                table: "L_EndorsementItemEndorsement",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementUser_Created",
                schema: "Links",
                table: "L_EndorsementUser",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementUser_EnableRecord",
                schema: "Links",
                table: "L_EndorsementUser",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementUser_ERPCode",
                schema: "Links",
                table: "L_EndorsementUser",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementUser_FirstId",
                schema: "Links",
                table: "L_EndorsementUser",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementUser_LastModified",
                schema: "Links",
                table: "L_EndorsementUser",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementUser_Name",
                schema: "Links",
                table: "L_EndorsementUser",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_EndorsementUser_SecondId",
                schema: "Links",
                table: "L_EndorsementUser",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_Created",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_EnableRecord",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_ERPCode",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_FirstId",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_LastModified",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_Name",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_ProcessScenario_SecondId",
                schema: "Links",
                table: "L_ProcessScenario",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_Created",
                schema: "Links",
                table: "L_RolePosition",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_EnableRecord",
                schema: "Links",
                table: "L_RolePosition",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_ERPCode",
                schema: "Links",
                table: "L_RolePosition",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_FirstId",
                schema: "Links",
                table: "L_RolePosition",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_LastModified",
                schema: "Links",
                table: "L_RolePosition",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_Name",
                schema: "Links",
                table: "L_RolePosition",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_RolePosition_SecondId",
                schema: "Links",
                table: "L_RolePosition",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_Created",
                schema: "Links",
                table: "L_UserLocation",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_EnableRecord",
                schema: "Links",
                table: "L_UserLocation",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_ERPCode",
                schema: "Links",
                table: "L_UserLocation",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_FirstId",
                schema: "Links",
                table: "L_UserLocation",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_LastModified",
                schema: "Links",
                table: "L_UserLocation",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_Name",
                schema: "Links",
                table: "L_UserLocation",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserLocation_SecondId",
                schema: "Links",
                table: "L_UserLocation",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserPosition_Created",
                schema: "Links",
                table: "L_UserPosition",
                column: "Created",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserPosition_EnableRecord",
                schema: "Links",
                table: "L_UserPosition",
                column: "EnableRecord",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserPosition_ERPCode",
                schema: "Links",
                table: "L_UserPosition",
                column: "ERPCode",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserPosition_FirstId",
                schema: "Links",
                table: "L_UserPosition",
                column: "FirstId",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserPosition_LastModified",
                schema: "Links",
                table: "L_UserPosition",
                column: "LastModified",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserPosition_Name",
                schema: "Links",
                table: "L_UserPosition",
                column: "Name",
                descending: new bool[0]);

            migrationBuilder.CreateIndex(
                name: "IX_L_UserPosition_SecondId",
                schema: "Links",
                table: "L_UserPosition",
                column: "SecondId",
                descending: new bool[0]);

            migrationBuilder.AddForeignKey(
                name: "FK_D_Location_F_EndorsementItem_EndorsementItemId",
                schema: "Dimentions",
                table: "D_Location",
                column: "EndorsementItemId",
                principalSchema: "Facts",
                principalTable: "F_EndorsementItem",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Condition_F_EndorsementItem_EndorsementItemId",
                schema: "Facts",
                table: "F_Condition",
                column: "EndorsementItemId",
                principalSchema: "Facts",
                principalTable: "F_EndorsementItem",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_F_Endorsement_F_EndorsementItem_EndorsementItemId",
                schema: "Facts",
                table: "F_Endorsement",
                column: "EndorsementItemId",
                principalSchema: "Facts",
                principalTable: "F_EndorsementItem",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_F_Case_D_User_CreatorId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Case_D_User_RequestorId",
                schema: "Facts",
                table: "F_Case");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_D_User_D_UserId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Condition_F_EndorsementItem_EndorsementItemId",
                schema: "Facts",
                table: "F_Condition");

            migrationBuilder.DropForeignKey(
                name: "FK_F_Endorsement_F_EndorsementItem_EndorsementItemId",
                schema: "Facts",
                table: "F_Endorsement");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "D_Entity",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "F_Attachment",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_WorkItem",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "L_EndorsementItemEndorsement",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_EndorsementUser",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_ProcessScenario",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_RolePosition",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_UserLocation",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "L_UserPosition",
                schema: "Links");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "D_WorkItemState",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_Location",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_Position",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_User",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_UserInformation",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "F_EndorsementItem",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "F_Endorsement",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "D_Role",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "F_Condition",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "D_Operand",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_Tag",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "F_Case",
                schema: "Facts");

            migrationBuilder.DropTable(
                name: "D_TagType",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_CaseState",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "D_Process",
                schema: "Dimentions");

            migrationBuilder.DropTable(
                name: "F_Scenario",
                schema: "Facts");
        }
    }
}
