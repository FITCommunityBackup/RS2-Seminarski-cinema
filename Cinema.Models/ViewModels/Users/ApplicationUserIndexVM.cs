﻿namespace Cinema.Models.ViewModels.Users
{
    public class ApplicationUserIndexVM
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public IdentityMasterModel Role { get; set; }
    }
}