namespace Tomato.Models
{
    public static class LoginModel
    {
        public static string Email { get; set; }
        public static string Password { get; set; }
        public static bool RememberMe { get; set; } = false;
        public static bool IsAdmin { get; set; } = true;
    }
}
