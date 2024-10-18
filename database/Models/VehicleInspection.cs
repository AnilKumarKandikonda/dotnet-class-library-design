using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace database.Models
{
    [Table("tblVehInspection")]
    public class VehicleInspection
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int INSPECTION_ID { get; set; }

        [Column(TypeName = "DECIMAL(13,8)")]
        public double? INSPECTION_LATITUDE { get; set; }

        [Column(TypeName = "DECIMAL(13,8)")]
        public double? INSPECTION_LONGITUDE { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime INSPECTION_CREATED { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime INSPECTION_COMPLETED { get; set; }

        [Column(TypeName = "Varchar(200)")]
        public string? INSPECTION_BY { get; set; }

        [Column(TypeName = "TEXT")]
        public string? INSPECTION_SIGNATURE { get; set; }

        [Column(TypeName = "TEXT")]
        public string? INSPECTION_COMMENTS { get; set; }

        [Column(TypeName = "FLOAT(10)")]
        public string? INSPECTION_PRICE { get; set; }

        [Column(TypeName = "FLOAT(10)")]
        public string? INSPECTION_TAX { get; set; }

        [Required]
        [ForeignKey("VEH_ID")]
        public Vehicle? INSPECTION_VEH_ID { get; set; }

        [Column(TypeName = "TEXT")]
        public string? INSPECTION_DETAILS { get; set; }

        public VehicleInspection() {
            INSPECTION_CREATED = DateTime.UtcNow;
        }

    }
}
