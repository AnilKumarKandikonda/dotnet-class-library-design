using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace database.Models
{
    [Table("tblGrpUsers")]
    public class UsersInGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [ForeignKey("USR_ID")]
        public User? GRP_USR_ID { get; set; }

        [ForeignKey("GRP_ID")]
        public UserGroup? GRP_GROUP_ID { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime GRP_USER_ASSIGNED { get; set; }

        [ForeignKey("USR_ID")]
        public User? GRP_ASSIGED_USR { get; set; }

        public UsersInGroup() { 
            GRP_USER_ASSIGNED = DateTime.UtcNow;
        }
    }
}
