﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMovie.Models
{
    public class User
    {
        public DateTime Birthday { get; set; }
        public string UserName { get; set; }
        public byte[] Password { get; set; }
        public string AvatarImagePath { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

    }
}