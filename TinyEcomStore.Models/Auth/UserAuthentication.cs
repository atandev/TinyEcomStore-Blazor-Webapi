﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyEcomStore.Models.Auth
{
    public class UserAuthentication
    {
        [Required(ErrorMessage = "Username is required.")]
        public string? UserName { get; set;}
        [Required(ErrorMessage = "Password is required.")]
        public string? Password { get; set;}
        public byte MembershipType { get; set;}
    }
}
