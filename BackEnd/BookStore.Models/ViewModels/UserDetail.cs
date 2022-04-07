using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Models.ViewModels
{
    public class UserDetail
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RoleName { get; set; }
    }
}
