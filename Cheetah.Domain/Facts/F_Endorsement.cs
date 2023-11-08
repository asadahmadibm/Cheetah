﻿namespace Cheetah.Domain.Facts;
public partial class F_Endorsement : SimpleClass
{
    [Column(Order = 100)]
    public long? RoleId { get; set; }
    public virtual D_Role? Role { get; set; }

    [Column(Order = 101)]
    public long? ScenarioId { get; set; }
    public virtual F_Scenario? Scenario { get; set; }

    [Column(Order = 102)]
    public long? EndorsementItemId { get; set; }
    [ForeignKey(nameof(EndorsementItemId))]
    public virtual F_EndorsementItem? EndorsementItem { get; set; }

    #region For Variables
    [Column(Order = 103)]
    public virtual long? ConditionId { get; set; }
    public virtual F_Condition? Condition { get; set; }
    #endregion

    [InverseProperty(nameof(F_EndorsementItem.Endorsement))]
    public virtual ICollection<F_EndorsementItem>? EndorsementItems { get; set; } = new HashSet<F_EndorsementItem>();
    
    public virtual ICollection<L_EndorsementUser>? Users { get; set; } = new HashSet<L_EndorsementUser>();
    public override void SetName()
    {
        //DisplayName = Scenario?.DisplayName + "," + SortIndex + "," + Role?.DisplayName;
        //Name = Scenario?.Name + "," + SortIndex + "," + Role?.Name;
    }

    #region Functions
    public F_Endorsement ShallowCopy()
    {
        return (F_Endorsement)this.MemberwiseClone();
    }
    #region Getter
    public Boolean IsRequestor()
    {
        return (RoleId == 100);
    }
    public Boolean IsRequestorManager()
    {
        return (RoleId == 101);
    }
    #endregion

    #endregion

}