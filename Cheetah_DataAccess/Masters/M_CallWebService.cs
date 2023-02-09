namespace Cheetah_DataAccess.Masters
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Parameters;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("M_CallWebService", Schema ="Masters")]
    public partial class M_CallWebService : BasePSClass
    {
        //Passed

        #region Basic Prop
        [StringLength(500)]
        public string? CWS_URL { get; set; }

        [Column(TypeName = "ntext")]
        public string? CWS_JsonInputBody { get; set; }

        public bool? CWS_WSResult { get; set; }
        #endregion

        #region Relations 
        
        #region ParameterList
        public virtual P_ParameterList? CWS_ParameterList { get; set; } 
        #endregion


        #endregion
    }
}
