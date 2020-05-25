using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DAL
{
    public class UserRepository:IUserRepository
    {
        //private List<User> users;
        DataContext context;

        public UserRepository(DataContext _context)
        {
            context = _context;
            //users = new List<User>();
            //users.Add(new User() { Id = 1, Name = "Peeters" });
            //users.Add(new User() { Id = 2, Name = "Simons" });
            //users.Add(new User() { Id = 3, Name = "Dierckx" });
        }

        public List<User> Get()
        {
            return context.Users.ToList();
        }

        public User FindById(int id)
        {
            return context.Users.Where(u => u.Id == id).Single();
        }

        public void Save(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}
