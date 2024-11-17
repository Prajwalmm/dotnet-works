using System.ComponentModel.DataAnnotations;

namespace MyAuthDemoBackEnd.Models
{
    public class User
    {
        [Key]
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
