﻿namespace Life.API.Models
{
    public class UserModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string? PhoneNumber { get; set; }

        public bool TextUpdates { get; set; }

        public string Role { get; set; }
    }
}
