using Simpa.Bl.Interface;
using Simpa.Bl.ModelVm;
using Simpa.DAL.Databases;
using Simpa.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpa.Bl.Reposeratry
{
    public class UserRepo : IUser
    {
        #region field
        AppplicationDbContext db =new AppplicationDbContext();
        #endregion

        #region handel function
        public void CreateUser(User user)
        {
            try
            {
                db.users.Add(user);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }

        public void DeleteUser(int userId)
        {
            if (userId != null && userId != 0)
            {
                var user = db.users.Where(a => a.Id == userId).FirstOrDefault();
                if(user!=null)
                {
                    user.IsDeleted = true;
                    db.SaveChanges();
                }
            }
        }

        public List<User> GetAllUser()
        {
            var users = db.users.Where(a=>a.IsDeleted!=true).ToList();
            return users;
        }

        public User GetUserId(int userId)
        {
            if(userId!=null&&userId!=0)
            {
                var user = db.users.Where(a => a.Id == userId).FirstOrDefault();
                return user;
            }
            return null;
        }

        public void UpdateUser(UserVm user)
        {
            if (user.Id != null && user.Id != 0)
            {
                var Old = db.users.Where(a => a.Id == user.Id).FirstOrDefault();
                if (user != null)
                {
                    user.IsDeleted = true;
                    Old.FName = user.FName;
                    Old.LName = user.LName;
                    Old.UserName = user.UserName;
                    Old.Password = user.Password;
                    Old.Email = user.Email;

                    db.SaveChanges();
                }
            }
        }
        #endregion
    }
}
