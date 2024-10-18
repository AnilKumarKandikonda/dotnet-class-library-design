using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace database.Models
{
    [Table("tblServiceLocations")]
    public class ServiceLocation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SER_LOC_ID { get; set; }

        [Required]
        [Column(TypeName = "Varchar(200)")]
        public string? SER_LOC_NAME { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime SER_LOC_CREATED { get; set; }

        [Column(TypeName = "DECIMAL(13,8)")]
        public double? SER_LOC_LATITUDE { get; set; }

        [Column(TypeName = "DECIMAL(13,8)")]
        public double? SER_LOC_LONGITUDE { get; set; }

        [Required]
        [ForeignKey("USR_ID")]
        public Address? SER_LOC_ADDR_ID { get; set; }

        [Column(TypeName = "FLOAT(3)")]
        public float? SER_LOC_RATING { get; set; }

        [Required]
        [Column(TypeName = "Varchar(20)")]
        public string? SER_LOC_PHONE { get; set; }

        [Required]
        [Column(TypeName = "Varchar(100)")]
        public string? SER_LOC_EMAIL { get; set; }

        [Required]
        [Column(TypeName = "Varchar(100)")]
        public string? SER_LOC_MANAGER { get; set; }

        [Column(TypeName = "TEXT")]
        public string? SER_LOC_COMMENTS { get; set; }

        [Column(TypeName = "TEXT")]
        public string? SER_LOC_ANNOUNCEMENTS { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string? SER_LOC_OPENDAYS { get; set; }

        [Column(TypeName = "VARCHAR(150)")]
        public string? SER_LOC_OPENHOURS { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(255)")]
        public string? SER_LOC_IMAGE1 { get; set; }

        [Column(TypeName = "VARCHAR(255)")]
        public string? SER_LOC_IMAGE2 { get; set; }

        [Column(TypeName = "VARCHAR(255)")]
        public string? SER_LOC_IMAGE3 { get; set; }

        [Column(TypeName = "bit(1)")]
        public bool SER_LOCATION_ACTIVE { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(15)")]
        public string? SER_LOC_UNIQUE_ID { get; set; }

        [Column(TypeName = "bit(1)")]
        public bool SER_LOCATION_APPROVED { get; set; }

        [Column(TypeName = "TEXT")]
        public string? SER_LOC_ADMIN_COMMENTS { get; set; }

        public ServiceLocation() {
            SER_LOCATION_ACTIVE = false;
            SER_LOC_CREATED = DateTime.UtcNow;
        }

    }
}
