﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace HouseAPI.Models
{
    public partial class DashBoardPosts
    {
        [Key]
        public int DashItemId { get; set; }
        public string DashTitle { get; set; }
        public string DashType { get; set; }
        public string DashBody { get; set; }
        public string DashIntendedFor { get; set; }
        public int? ResidentId { get; set; }
        public string ResidentName { get; set; }

        public DateTime? DashTime { get; set; }

        public virtual Residents Resident { get; set; }
    }
}
