using MessagePack;
using Microsoft.Build.Framework;

namespace E_commerce.Models
{
    public class VMLogin
    {
        [Key("Id")]
        [Required]  
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        public string Password { get; set; }
        public bool  KeepLoggedIn { get; set; }
    }
}
