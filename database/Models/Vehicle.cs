using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace database.Models
{
    [Table("tblVehicle")]
    public class Vehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VEH_ID { get; set; }

        [Required]
        [ForeignKey("CPY_ID")]
        public Company? VEH_CPY_ID { get; set; }

        [Required]
        [Column(TypeName = "Varchar(50)")]
        public string? VEH_UNIQUE_ID { get; set; }

        [Required]
        [Column(TypeName = "Varchar(50)")]
        public string? VEH_IMEI { get; set; }

        [Column(TypeName = "Varchar(50)")]
        public string? VEH_VIN { get; set; }

        [Column(TypeName = "Varchar(50)")]
        public string? VEH_NETWORK { get; set; }

        [Column(TypeName = "Varchar(100)")]
        public string? VEH_MAKE { get; set; }

        [Required]
        [Column(TypeName = "Varchar(100)")]
        public string? VEH_MODEL { get; set; }

        [Required]
        [Column(TypeName = "Varchar(10)")]
        public string? VEH_YEAR { get; set; }

        [Column(TypeName = "Varchar(50)")]
        public string? VEH_COLOR { get; set; }

        [Required]
        [Column(TypeName = "Varchar(100)")]
        public string? VEH_LICENSE { get; set; }

        [ForeignKey("USR_ID")]
        public User? VEH_USR_DRIVER { get; set; }

        [Column(TypeName = "bit(1)")]
        public bool VEH_IGN_ON { get; set; }

        [Column(TypeName = "INT(10)")]
        public int? VEH_SPEED { get; set; }

        [Column(TypeName = "DECIMAL(13,8)")]
        public double? VEH_LATITUDE { get; set; }

        [Column(TypeName = "DECIMAL(13,8)")]
        public double? VEH_LONGITUDE { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime? VEH_GPS_DATETIME { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime? VEH_EVT_DATETIME { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime? VEH_IGN_OFF_DATETIME { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime? VEH_LAST_IGN_DATETIME { get; set; }

        [Column(TypeName = "INT(10)")]
        public int? VEH_FUEL_LEVEL { get; set; }

        [Column(TypeName = "INT(10)")]
        public int? VEH_BATTERY_LEVEL { get; set; }

        [Column(TypeName = "bit(1)")]
        public bool VEH_ACTIVE { get; set; }

        public Vehicle() {
            if (VEH_FUEL_LEVEL < 0) { VEH_FUEL_LEVEL = 0; }
            else if (VEH_FUEL_LEVEL > 100) { VEH_FUEL_LEVEL = 0; }
            if (VEH_BATTERY_LEVEL < 0) { VEH_BATTERY_LEVEL = 0; }
            else if (VEH_BATTERY_LEVEL > 100) { VEH_BATTERY_LEVEL = 0; }
            VEH_ACTIVE = false;
        }

    }
}
