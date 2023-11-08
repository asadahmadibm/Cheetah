﻿namespace Cheetah.Domain.Links;

[Index(nameof(FirstId), IsUnique = false, AllDescending = true)]
[Index(nameof(SecondId), IsUnique = false, AllDescending = true)]
public partial class L_ProcessScenario : SimpleLinkClass
{
    [Column(Order = 100)]
    [ForeignKey(nameof(FirstId))]
    public virtual D_Process? Process { get; set; }

    [Column(Order = 101)]
    [ForeignKey(nameof(SecondId))]
    public virtual F_Scenario? Scenario { get; set; }

    public L_ProcessScenario ShallowCopy()
    {
        return (L_ProcessScenario)this.MemberwiseClone();
    }
}