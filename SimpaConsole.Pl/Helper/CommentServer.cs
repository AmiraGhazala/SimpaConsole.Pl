using Simpa.Bl.Interface;
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
    public class CommentServer
    {

        commentRepo CommentRepo = new commentRepo();
        CommentVm commentVm = new CommentVm();
        public void GetAllcomment()
        {
            foreach (var comment in CommentRepo.GetAllComment())
            {
                Console.WriteLine(comment.User.FName + comment.User.LName);

                Console.WriteLine(comment.date);

                Console.WriteLine(comment.Body);
            }
        }
        public void Create(CommentVm commentVm)
        {
            Comments comments = new Comments()
            {
                Body = commentVm.Body,
                UserId = commentVm.UserId,
                date = DateTime.Now
            };
            CommentRepo.CreateComment(comments);
        }
        public void CreateData()
        {
            Console.WriteLine("Hello");
            Console.Write($"Please Enter Body: ");
            commentVm.Body = Console.ReadLine();
            Console.Write("Enter id : ");
            commentVm.UserId = int.Parse(Console.ReadLine());

            Create(commentVm);
        }
        public void GetCommentId(int id)
        {
            Comments comments = CommentRepo.GetcommentId(id);
            CommentVm commentVm = new CommentVm()
            {
                Body = comments.Body,
                User = comments.User,
               //UserId = comments.UserId,
                date = comments.date
            };
            Console.WriteLine(Print(commentVm));
        }
        public string Print(CommentVm commentVm)
        {
            return $"{commentVm.User.FName} {commentVm.User.LName}\n{commentVm.date}\nBody :{commentVm.Body}\nIdUser : {commentVm.Id}";
        }
        public void Delete(int id)
        {
            CommentRepo.DeleteComment(id);
        }
        public void Edit()
        {
            Console.WriteLine("Hello");
            Console.Write($"Please Enter Id : ");
            commentVm.Id = int.Parse(Console.ReadLine());
            Console.Write($"Please Enter Body : ");
            commentVm.Body = Console.ReadLine();
            CommentRepo.Updatecomment(commentVm);
        }
    }
}