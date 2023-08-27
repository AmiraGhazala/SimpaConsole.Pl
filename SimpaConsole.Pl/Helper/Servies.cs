using Simpa.Bl.ModelVm;
using Simpa.Bl.Reposeratry;
using Simpa.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpaConsole.Pl.Helper
{
    public class Servies
    {
        UserRepo userRepo = new UserRepo();
        UserVm userVm = new UserVm();
        public void GetAllUser()
        {
            foreach (var User in userRepo.GetAllUser())
            {
                Console.WriteLine(User.FName +" "+User.Email);
            }
        }
        public void  CreateData()
        {
            Console.WriteLine("Hello");
            Console.Write($"Please Enter First Name : ");
            userVm.FName = Console.ReadLine();
            Console.Write($"Please Enter Email: ");
            userVm.Email = Console.ReadLine();
            Console.Write($"Please Enter Password: ");
            userVm.Password = Console.ReadLine();
            Console.Write($"Please Enter User Name : ");
            userVm.UserName = Console.ReadLine();
            Creat(userVm);
        }
        public void Creat(UserVm userVm) 
        {
            User user = new User()
            {
                FName = userVm.FName,
                Email = userVm.Email,
                IsDeleted = false,
                Password = userVm.Password,
                LName = userVm.LName,
                UserName = userVm.UserName
            };
            userRepo.CreateUser(user);
        }
        public void GetUserById(int id)
        {
           User user= userRepo.GetUserId(id);
            UserVm userVm = new UserVm()
            {
                FName = user.FName,
                LName = user.LName,
                Email = user.Email,
                Password = user.Password,
                UserName = user.UserName

            };
            Console.WriteLine(Print(userVm));
        }
        public string Print(UserVm userVm)
        {
            return $"Name :{userVm.FName} {userVm.LName}\nEmail :{userVm.Email}\nPassword : {userVm.Password}\nUserName:{userVm.UserName}";
        }
        public void Delete(int id)
        {
            userRepo.DeleteUser(id);
        }
        public void EditUser()
        {
            Console.WriteLine("Hello");
            Console.Write($"Please Enter Id : ");
            userVm.Id =int.Parse( Console.ReadLine());
            Console.Write($"Please Enter First Name : ");
            userVm.FName = Console.ReadLine();
            Console.Write($"Please Enter Email: ");
            userVm.Email = Console.ReadLine();
            Console.Write($"Please Enter Password: ");
            userVm.Password = Console.ReadLine();
            Console.Write($"Please Enter User Name : ");
            userVm.UserName = Console.ReadLine();
            userRepo.UpdateUser(userVm);
        }
    }
}
