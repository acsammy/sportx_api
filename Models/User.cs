using System.ComponentModel.DataAnnotations;

namespace sportx_api.Models
{
    public class User
    {
        [Key]
        public int Id{ get; set; }
        public string Name{ get; set; }
        [EmailAddress]
        public string Email{ get; set; }
        public string Password{ get; set; }

    }
}