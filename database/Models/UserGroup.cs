using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace database.Models
{
    [Table("tblUsrGroup")]
    public class UserGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GRP_ID { get; set; }

        [Required]
        [Column(TypeName = "Varchar(100)")]
        public string? GRP_NAME { get; set; }

        [Column(TypeName = "Varchar(255)")]
        public string? GRP_DESCRIPTION { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime GRP_CREATED { get; set; }

        [ForeignKey("USR_ID")]
        public User? GRP_UPDATED { get; set; }

        public UserGroup() { 
            GRP_CREATED = DateTime.UtcNow;
        }
    }
}
