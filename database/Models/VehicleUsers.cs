using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database.Models
{
    [Table("tblVehUsers")]
    public class VehicleUsers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VEH_USR_ID { get; set; }

        [ForeignKey("VEH_ID")]
        public Vehicle? VEH_ID { get; set; }

        [ForeignKey("USR_ID")]
        public User? USR_ID { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime ASSIGNED_DATE { get; set; }

        [ForeignKey("USR_ID")]
        public User? ASSIGNED_USER { get; set; }

        public VehicleUsers()
        {
            ASSIGNED_DATE = DateTime.UtcNow;
        }
    }
}
