﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TeknikServis.Model.ViewModels.AdminPanel
{
    public class LoginVm
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
