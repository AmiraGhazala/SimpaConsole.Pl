using Simpa.Bl.ModelVm;
using Simpa.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpa.Bl.Interface
{
    public interface IUser
    {
        List<User> GetAllUser();
        void CreateUser(User user);
        User GetUserId(int userId);
        void DeleteUser(int userId);
        void UpdateUser(UserVm user);
    }
}
