using System.Collections.Generic;
using UTB.SocSit.Yalynnyi.Ispaniuk.Application.Abstraction;
using UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Database;
using IdentUser = UTB.SocSit.Yalynnyi.Ispaniuk.Infrastructure.Identity.User;
using System.Security.Authentication.ExtendedProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using UTB.SocSit.Yalynnyi.Ispaniuk.Domain.Entities;

namespace UTB.SocSit.Yalynnyi.Ispaniuk.Application.Implementation
{
    public class UserService(SocSitDbContext socsitDbContext) : IUserService
    {
        SocSitDbContext _SocSitDbContext = socsitDbContext;
        private readonly SecurityIdentityService _securityService;

        public IList<IdentUser> SelectAll()
        {
            return _SocSitDbContext.Users.ToList(); ;
        }

        public IdentUser FindByName(string name)
        {
            return _SocSitDbContext.Users.FirstOrDefault(u => u.UserName == name);
        }

        public IdentUser FindById(int id)
        {
            return _SocSitDbContext.Users.FirstOrDefault(u => u.Id == id);
        }

        public List<IdentUser> FindFriends(int id)
        {
            List<IdentUser> friends = new List<IdentUser> { };
            var fol = _SocSitDbContext.Follows.Where(f => f.UserID == id).ToList();
            if(fol != null)
            {
                List<Follow> follows = fol;
                foreach (Follow follow in follows)
                {
                    friends.Add(FindById(follow.FollowerID));
                }
            }
            return friends;
        }

        public bool Delete(int id)
        {
            try
            {
                IdentUser userToDelete = _SocSitDbContext.Users.Find(id);
                if (userToDelete != null)
                {
                    var posts = _SocSitDbContext.Posts.Where(p => p.UserID == id).ToList();
                    _SocSitDbContext.Posts.RemoveRange(posts);
                    _SocSitDbContext.SaveChangesAsync();
                    _SocSitDbContext.Remove(userToDelete);
                    _SocSitDbContext.SaveChanges();
                    Console.WriteLine($"User with ID {id} deleted successfully");
                    return true;
                } else
                {
                    Console.WriteLine($"User with ID {id} not found");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while deleting user: {ex.Message}");
                return false;
            }
        }

        public bool Update(int id, IdentUser user)
        {
            try
            {
                IdentUser userToEdit = _SocSitDbContext.Users.Find(id);
                if (userToEdit != null)
                {
                    userToEdit = user;
                    _SocSitDbContext.SaveChanges();
                    Console.WriteLine($"User with ID {id} Updated successfully");
                    return true;
                }
                else
                {
                    Console.WriteLine($"User with ID {id} not found");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred while updating user: {ex.Message}");
                return false;
            }
        }
    }
}
