﻿using System;
using System.Collections.Generic;

namespace DbWebAPI.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
