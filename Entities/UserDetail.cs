﻿using System.ComponentModel.DataAnnotations;

namespace TechBankAPI.Entities
{
    public class UserDetail
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string AccountNumber {  get; set; } = string.Empty;
        public string RoutingNumber {  get; set; } = string.Empty;
        public bool isActiveAccount { get; set; }
    }
}
