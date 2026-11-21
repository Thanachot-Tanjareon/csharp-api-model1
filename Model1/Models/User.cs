namespace Model1.Models
{
    public partial class User
    {
        public int UserID { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? Nickname { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Avatar { get; set; }
        public DateTime? CreateTime { get; set; }

        public int Count()
        {
            return 5;
        }

    }
}
