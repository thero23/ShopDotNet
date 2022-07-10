﻿using Microsoft.AspNetCore.Identity;

namespace InternetShop.Api.ViewModels.User
{
    public class UserViewModel : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Auth0Id { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string State { get; set; }
        public string Area { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
    }
}