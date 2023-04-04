using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Win32;

namespace CoffeeShopRegistration.Models
{
    public class UserRegistration
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
