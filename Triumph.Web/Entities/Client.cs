﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Triumph.Web.Entities
{
    public class Client
    {
        [Key]
        public int ClientID { get; set; }
        [Display(Name = "Business")]
        public string BusinessName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Display(Name = "Business ID")]
        public string DisplayName { get; set; }

        [Display(Name = "Name")]
        public string FullName
        {
            get { return (FirstName + " " + LastName); }
        }

        public string Notes { get; set; }
    }
}
