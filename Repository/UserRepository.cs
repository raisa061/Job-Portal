using FinalProjetct.Data;
using FinalProjetct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjetct.Repository
{
    public class UserRepository
    {
        private UserContext context;

        public UserRepository(UserContext _context)
        {
            context = _context;
        }

        public List<User> GetAllUser()
        {
            var users = new List<User>();
            var data = context.User.ToList();
            if(data?.Any() == true)
            {
                foreach(var d in data)
                {
                    var user = new User()
                    {
                        Username = d.Username,
                        Firstname = d.Lastname,
                        Lastname = d.Lastname,
                        Email = d.Email,
                        Address = d.Address,
                        BirthDate = d.BirthDate
                    };

                    users.Add(user);
                   
                }

            }

            return data;

        }

        public void GetUserById(int id)
        {

        }

        public int AddUser(User model)
        {
            var user = new User()
            {
                Username = model.Username,
                Firstname = model.Lastname,
                Lastname = model.Lastname,
                Email = model.Email,
                Address = model.Address,
                BirthDate = model.BirthDate
            };
            context.User.Add(user);
            context.SaveChanges();

            return user.Id;
        }

        public void DeleteUser(int id)
        {

        }

        public void UpdateUser()
        {

        }
    }
}
