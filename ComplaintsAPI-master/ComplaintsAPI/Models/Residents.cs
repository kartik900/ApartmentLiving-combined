﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ComplaintsAPI.Models
{
    public partial class Residents
    {
        public Residents()
        {
            Complaints = new HashSet<Complaints>();
            DashBoardPosts = new HashSet<DashBoardPosts>();
            FriendsAndFamily = new HashSet<FriendsAndFamily>();
            Payments = new HashSet<Payments>();
            Services = new HashSet<Services>();
            Visitors = new HashSet<Visitors>();
        }
        [Key]
        public int ResidentId { get; set; }
        public string ResidentName { get; set; }
        public int? ResidentHouseNo { get; set; }
        public string ResidentType { get; set; }
        public string ResidentMobileNo { get; set; }
        public string ResidentEmail { get; set; }
        public string ResidentPassword { get; set; }
        public string IsApproved { get; set; }
        public int? ResidentWallet { get; set; }

        public virtual HouseList ResidentHouseNoNavigation { get; set; }
        public virtual ICollection<Complaints> Complaints { get; set; }
        public virtual ICollection<DashBoardPosts> DashBoardPosts { get; set; }
        public virtual ICollection<FriendsAndFamily> FriendsAndFamily { get; set; }
        public virtual ICollection<Payments> Payments { get; set; }
        public virtual ICollection<Services> Services { get; set; }
        public virtual ICollection<Visitors> Visitors { get; set; }
    }
}
