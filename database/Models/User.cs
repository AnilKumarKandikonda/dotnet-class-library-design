using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace database.Models
{
    [Table("tblUsers")]
    public class User: IdentityUser
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int USR_ID { get; set; }

        [Required]
        [Column(TypeName = "Varchar(100)")]
        public string? USR_EMAIL { get; set; }

        [Required]
        [Column(TypeName = "Varchar(50)")]
        public string? USR_PASSWORD { get; set; }

        [Required]
        [Column(TypeName = "Varchar(100)")]
        public string? USR_FIRSTNAME { get; set; }

        [Required]
        [Column(TypeName = "Varchar(100)")]
        public string? USR_LASTNAME { get; set; }

        [Required]
        [Column(TypeName = "Varchar(20)")]
        public string? USR_PHONE { get; set; }

        [ForeignKey("CPY_ID")]
        public Company? USR_COMPNAY { get; set; }

        [ForeignKey("SER_LOC_ID")]
        public ServiceLocation? USR_SER_LOC_ID { get; set; }

        [Required]
        [Column(TypeName = "Varchar(100)")]
        public string? USR_EMAIL2 { get; set; }

        [Required]
        [Column(TypeName = "Varchar(100)")]
        public string? USR_EMAIL3 { get; set; }

        [Column(TypeName = "bit(1)")]
        public bool USR_EMAIL_FLAG { get; set; }

        [Column(TypeName = "bit(1)")]
        public bool USR_PHONE_FLAG { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime? USR_CREATED { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime? USR_LAST_LOGGED { get; set; }

        [Column(TypeName = "TEXT")]
        public string? USR_COMMENTS { get; set; }

        [Column(TypeName = "bit(1)")]
        public bool USR_PHONE_VERIFIED { get; set; }

        [Column(TypeName = "bit(1)")]
        public bool USR_EMAIL_VERIFIED { get; set; }

        [Column(TypeName = "char(36)")]
        public string USR_GUID { get; set; }

        [Required]
        [Column(TypeName = "TINYINT")]
        public UserType USR_IS_DRIVER { get; set; }


        public User()
        {
            USR_GUID = Guid.NewGuid().ToString();
            USR_EMAIL_FLAG = false;
            USR_PHONE_FLAG = false;
            USR_PHONE_VERIFIED = false;
            USR_EMAIL_VERIFIED = false;
            USR_CREATED = DateTime.UtcNow;
        }
    }

    public enum UserType : byte
    {
        Driver
    }
}
