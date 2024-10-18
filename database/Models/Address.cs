using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace database.Models
{
    [Table("tblAddress")]
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ADDR_ID { get; set; }

        [Required]
        [ForeignKey("USR_ID")]
        public User? ADDR_USR_ID { get; set; }

        [Required]
        [Column(TypeName = "Varchar(200)")]
        public string? ADDR_ADDRESS_LINE1 { get; set; }

        [Column(TypeName = "Varchar(200)")]
        public string? ADDR_ADDRESS_LINE2 { get; set; }

        [Required]
        [Column(TypeName = "Varchar(200)")]
        public string? ADDR_CITY { get; set; }

        [Required]
        [Column(TypeName = "Varchar(200)")]
        public string? ADDR_STATE { get; set; }

        [Required]
        [Column(TypeName = "Varchar(200)")]
        public string? ADDR_COUNTRY { get; set; }

        [Required]
        [Column(TypeName = "Varchar(10)")]
        public string? ADDR_POSTAL { get; set; }

        [Required]
        [Column(TypeName = "TINYINT")]
        public AddressType ADDR_TYPE { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime ADDR_UPDATED_DATE { get; set; }

        [ForeignKey("USR_ID")]
        public User? ADD_LAST_UPDATED { get; set; }

        public Address() {
            ADDR_UPDATED_DATE = DateTime.UtcNow;
        }

    }

    public enum AddressType: byte
    {
        Shipping,
        Billing,
    }
}
