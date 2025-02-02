﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities;
using UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Database.Seeding;
using UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Database
{
    public class SocSitDbContext : IdentityDbContext<Identity.User, Role, int>
    {
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Follow> Follows { get; set; }
        public DbSet<Media> Media { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Reaction> Reactions { get; set; }
        public DbSet<Identity.User> Users { get; set; }
        public SocSitDbContext(DbContextOptions<SocSitDbContext> options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Comment_init comment = new Comment_init();
            modelBuilder.Entity<Comment>().HasData(comment.GetComments());
            Follow_init follow = new Follow_init();
            modelBuilder.Entity<Follow>().HasData(follow.GetFollows());
            Media_init media = new Media_init();
            modelBuilder.Entity<Media>().HasData(media.GetMedia());
            Post_init post = new Post_init();
            modelBuilder.Entity<Post>().HasData(post.GetPosts());
            Reaction_init reaction = new Reaction_init();
            modelBuilder.Entity<Reaction>().HasData(reaction.GetReactions());
            User_init user = new User_init();
            modelBuilder.Entity<Identity.User>().HasData(user.GetUsers());
            Role_init role = new Role_init();
            modelBuilder.Entity<Role>().HasData(role.GetRoles());
        }
    }
}
