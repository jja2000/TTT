﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TTT.Models
{
    public class UserClass
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string LoggedIn { get; set; }
    }
}
