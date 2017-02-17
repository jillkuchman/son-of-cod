﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SonOfCodSeafood.Models
{
    public class NewsletterMember
    {
        [Key]
        public int NewsletterMemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }

        public NewsletterMember()
        {

        }
    }
}
