using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Database
{
    public class SocSitDbContext : DbContext
    {
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Down> Downs { get; set; }
        public DbSet<Follow> Follows { get; set; }
        public DbSet<Media> Media { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Up> Ups { get; set; }
        public DbSet<User> Users { get; set; }
        //public SocSitDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        //{

        //}
        public SocSitDbContext(DbContextOptions<SocSitDbContext> options): base(options)
        {
        }
    }
}
