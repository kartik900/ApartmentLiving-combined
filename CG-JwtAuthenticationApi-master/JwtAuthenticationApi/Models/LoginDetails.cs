﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtAuthenticationApi.Models
{
    public class LoginDetails
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string LoginType { get; set; }

    }
}
