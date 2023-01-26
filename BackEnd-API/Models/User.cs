using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd_API.Models
{
    [Table("user_medical")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_user { get; set; }
        public string first_name { get; set; }
        public string first_last_name { get; set; }
        public string second_last_name { get; set; }
        public string address_user { get; set; }
        public DateTime birth { get; set; }
        public string rol { get; set; }
    }
}
