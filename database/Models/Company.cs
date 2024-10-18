using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace database.Models
{
    [Table("tblComapny")]
    public class Company
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CPY_ID { get; set; }

        [Required]
        [Column(TypeName = "Varchar(150)")]
        public string? CPY_NAME { get; set; }

        [Required]
        [Column(TypeName = "Varchar(150)")]
        public string? CPY_LOCATION { get; set; }

        [Required]
        [Column(TypeName = "DECIMAL(13,8)")]
        public double? CPY_LATITUDE { get; set; }

        [Required]
        [Column(TypeName = "DECIMAL(13,8)")]
        public double? CPY_LONGITUDE { get; set; }

        [Required]
        [Column(TypeName = "Varchar(100)")]
        public double? CPY_EMAIL { get; set; }

        [Column(TypeName = "Varchar(100)")]
        public double? CPY_EMAIL2 { get; set; }

        [Required]
        [Column(TypeName = "Varchar(20)")]
        public double? CPY_PHONE { get; set; }

        [Column(TypeName = "Varchar(20)")]
        public double? CPY_PHONE2 { get; set; }

        [Column(TypeName = "Varchar(150)")]
        public double? CPY_TIMEZONE { get; set; }

        [Column(TypeName = "INT(15)")]
        public uint? CPY_SPEED_GRACE { get; set; }

        [Column(TypeName = "bit(1)")]
        public bool CPY_CONTRACTOR { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime? CPY_CREATED { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime? CPY_LAST_UPDATED { get; set; }


        public Company() {
            CPY_SPEED_GRACE = 0;
            CPY_CONTRACTOR = false;
            CPY_CREATED = DateTime.UtcNow;
        }

    }
}
