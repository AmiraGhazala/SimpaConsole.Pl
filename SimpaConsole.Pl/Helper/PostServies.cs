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
    public class PostServies
    {
        PostRepo postRepo = new PostRepo();
        PostVm postVm = new PostVm();
        public void GetAllPost()
        {
            foreach (var Post in postRepo.GetAllPost())
            {
                Console.WriteLine(Post.User.FName+Post.User.LName);

                Console.WriteLine(Post.date);

                Console.WriteLine(Post.Body);
            }
        }
        public void CreateData()
        {
            Console.WriteLine("Hello");
            Console.Write($"Please Enter Body: ");
            postVm.Body = Console.ReadLine();
            Console.Write("Enter id : ");
            postVm.UserId=int.Parse(Console.ReadLine());
           
            Creat(postVm);
        }
        public void Creat(PostVm postVm)
        {
            Post post = new Post()
            {
                Body = postVm.Body,
                UserId = postVm.UserId,
                date = DateTime.Now
            };
            postRepo.CreatePost(post);
        }
        public void GetPostById(int id)
        {
            Post post = postRepo.GetPostId(id);
            PostVm postVm = new PostVm()
            {
                Body = post.Body,
                User=post.User,
                UserId = post.UserId,
                date=post.date
            };
            Console.WriteLine(Print(postVm));
        }
        public string Print(PostVm postVm)
        {
            return $"{postVm.User.FName} {postVm.User.LName}\n{postVm.date}\nBody :{postVm.Body}\nIdUser : {postVm.Id}";
        }
        public void Delete(int id)
        {
            postRepo.DeletePost(id);
        }
        public void EditPost()
        {
            Console.WriteLine("Hello");
            Console.Write($"Please Enter Id : ");
            postVm.Id = int.Parse(Console.ReadLine());
            Console.Write($"Please Enter Body : ");
            postVm.Body = Console.ReadLine();
            postRepo.UpdatePost(postVm);
        }
    }
}
