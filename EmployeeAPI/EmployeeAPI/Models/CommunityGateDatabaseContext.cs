using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EmployeeAPI.Models
{
    public partial class CommunityGateDatabaseContext : DbContext
    {
        public CommunityGateDatabaseContext()
        {
        }

        public CommunityGateDatabaseContext(DbContextOptions<CommunityGateDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Complaints> Complaints { get; set; }
        public virtual DbSet<DashBoardPosts> DashBoardPosts { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<FriendsAndFamily> FriendsAndFamily { get; set; }
        public virtual DbSet<HouseList> HouseList { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<Residents> Residents { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<Visitors> Visitors { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }
    }
}
