﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication1.ViewModels
{
    public class LoginVM
    {

        [Required]
        public string? Username { get; set;}
        [Required]
        public string? Password { get;set; }
   
        public bool RememberUserPassword { get; set; }


    }
}
