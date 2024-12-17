﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebApiWithRoleAuthentication.Models;

namespace WebApiWithRoleAuthentication.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connString = "Server=DESKTOP-R0GDUHD; Database=RolesTesting; Trusted_Connection=True; MultipleActiveResultSets=true; TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connString);
        }
    }
}
