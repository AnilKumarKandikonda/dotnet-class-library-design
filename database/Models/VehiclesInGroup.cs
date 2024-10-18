using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace database.Models
{
    [Table("tblGrpVehicles")]
    public class VehiclesInGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [ForeignKey("VEH_ID")]
        public Vehicle? GRP_USR_ID { get; set; }

        [ForeignKey("GRP_ID")]
        public VehicleGroup? GRP_GROUP_ID { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime GRP_VEH_ASSIGNED { get; set; }

        [ForeignKey("USR_ID")]
        public User? GRP_ASSIGED_USR { get; set; }

        public VehiclesInGroup()
        {
            GRP_VEH_ASSIGNED = DateTime.UtcNow;
        }
    }
}
