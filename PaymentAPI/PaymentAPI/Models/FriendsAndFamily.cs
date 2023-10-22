﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PaymentAPI.Models
{
    public partial class FriendsAndFamily
    {
        [Key]
        public int FaFid { get; set; }
        public string FaFname { get; set; }
        public int? ResidentId { get; set; }
        public string Relation { get; set; }

        public virtual Residents Resident { get; set; }
    }
}
