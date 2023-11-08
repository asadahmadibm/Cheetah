﻿using Cheetah.Domain.Dimentions;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Cheetah.Infrastructure.Persistence;

public partial class ApplicationDbContext : IdentityDbContext
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        //    private readonly RoleManager<IdentityRole> _roleManager;
        //_roleManager = roleManager;

        //    if (! _roleManager.RoleExistsAsync(nameof(RoleProperty.Admin)).GetAwaiter().GetResult())
        //    {
        //        _roleManager.CreateAsync(new IdentityRole(nameof(RoleProperty.Admin)));
        //    }

        //    if (!_roleManager.RoleExistsAsync(nameof(RoleProperty.User)).GetAwaiter().GetResult())
        //    {
        //        _roleManager.CreateAsync(new IdentityRole(nameof(RoleProperty.User)));
        //    }
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder
        //    .ConfigureWarnings(warnings => warnings.Ignore(CoreEventId.DetachedLazyLoadingWarning));
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        
        //builder.Entity<D_Entity>()
        //    .Property(e => e.Display)
        //    .HasDefaultValue(true)
        //    .HasColumnOrder(100);

        //builder.Entity<D_Location>()
        //    .Property(e => e.EndorsementItemId)
        //    .HasDefaultValue(true)
        //    .HasColumnOrder(110);

        foreach (var entityType in builder.Model.GetEntityTypes())
        {
            if (Enum.IsDefined(typeof(TableType), entityType.ClrType.Namespace.Split('.').Last()))
            {
                entityType.SetTableName(entityType.ClrType.Name);
                entityType.SetSchema(entityType.ClrType.Namespace.Split('.').Last());
            }
        }

        builder.ApplyBaseEntityConfiguration();

        //base.Database.EnsureDeleted();
        //base.Database.EnsureCreated();
        base.OnModelCreating(builder);

        builder.Seed();
    }

    #region Dimentions
    public virtual DbSet<D_Entity> D_Entities { get; set; }
    public virtual DbSet<D_Tag> D_Tags { get; set; }
    public virtual DbSet<D_Process> D_Processes { get; set; }
    public virtual DbSet<D_CaseState> D_CaseStates { get; set; }
    public virtual DbSet<D_Position> D_Positions { get; set; }
    public virtual DbSet<D_Location> D_Locations { get; set; }
    public virtual DbSet<D_Role> D_Roles { get; set; }
    public virtual DbSet<D_User> D_Users { get; set; }
    public virtual DbSet<D_Operand> D_Operands { get; set; }
    public virtual DbSet<D_WorkItemState> D_WorkItemStates { get; set; }

    #endregion

    #region Facts
    public virtual DbSet<F_Endorsement> F_Endorsements { get; set; }
    public virtual DbSet<F_Condition> F_Conditions { get; set; }
    public virtual DbSet<F_Case> F_Cases { get; set; }
    public virtual DbSet<F_WorkItem> F_WorkItems { get; set; }
    public virtual DbSet<F_Attachment> F_Attachments { get; set; }
    public virtual DbSet<F_Scenario> F_Scenarios { get; set; }
    public virtual DbSet<F_EndorsementItem> F_EndorsementItems { get; set; }

    #endregion

    #region Links
    public virtual DbSet<L_RolePosition> L_RolePositions { get; set; }
    public virtual DbSet<L_UserLocation> L_UserLocations { get; set; }
    public virtual DbSet<L_UserPosition> L_UserPositions { get; set; }
    public virtual DbSet<L_ProcessScenario> L_ProcessScenarios { get; set; }

    #endregion
    public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }
}