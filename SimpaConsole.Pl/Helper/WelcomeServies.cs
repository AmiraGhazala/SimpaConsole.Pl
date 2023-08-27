using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpaConsole.Pl.Helper
{
    public class WelcomeServies
    {
        public void WelcomeServie() 
        {
            string num;
            do
            {
                
                Console.WriteLine($"Hello\nclick 1 if you want work withUser\n" +
                $"click 2 if you want work withPost\n " +
                $"click 3 if you want work withComment\n" +
                $"lick 3 if you want work Exist" 

                );
                num = Console.ReadLine();
                switch (num)
                {
                    case "1":
                        Console.Clear();
                        WelcomeServie2();
                       
                        break;
                        case "2":
                            Console.Clear();

                        welcomservies3();
                        break;
                        case "3":
                            Console.Clear();
                        welcomservies4(); break;
                    default:
                        break;
                }
            } while (num!="4");
        }
        public void WelcomeServie2()
        {
            Servies servies = new Servies();
            string click;
            do
            {
                Console.WriteLine($"Hello\nclick 1 if you want AddUser\n" +
                                   $"click 2 if you want  RemoveUser\n " +
                                   $"click 3 if you want  Search\n" +
                                   $"click 4 if you want  update\n" +
                                   $"click 5 if you want  GetAllData\n" +
                                   $"click00 if you want exist"

                                   );
                click = Console.ReadLine();
                switch (click)
                {
                    case "1":
                        Console.Clear();
                        servies.CreateData();
                        break;
                        case "2":

                            Console.Clear();
                        Console.Write("Please enter number : ");
                        int id=int.Parse(Console.ReadLine());
                        servies.Delete(id);
                        break;
                        case "3":

                            Console.Clear();
                        Console.Write("Please enter number : ");
                        int userid = int.Parse(Console.ReadLine());
                        servies.GetUserById(userid);
                        break;
                        case "4":
                            Console.Clear();
                        servies.EditUser();
                        break;
                        case "5":
                            Console.Clear();
                             servies.GetAllUser();
                        break;
                    default:
                        break;
                }

            } while (click != "00");
        }
        public void welcomservies3()
        {
            PostServies postServies = new PostServies();
            string click;
            do
            {
                Console.WriteLine($"Hello\nclick 1 if you want AddPost\n" +
                                   $"click 2 if you want  RemovePost\n " +
                                   $"click 3 if you want  Search\n" +
                                   $"click 4 if you want  update\n" +
                                   $"click 5 if you want  GetAllData\n" +
                                   $"click00 if you want exist"

                                   );
                click = Console.ReadLine();
                switch (click)
                {
                    case "1":
                        Console.Clear();
                        postServies.CreateData();
                        break;
                    case "2":

                        Console.Clear();
                        Console.Write("Please enter number : ");
                        int id = int.Parse(Console.ReadLine());
                        postServies.Delete(id);
                        break;
                    case "3":

                        Console.Clear();
                        Console.Write("Please enter number : ");
                        int postid = int.Parse(Console.ReadLine());
                        postServies.GetPostById(postid);
                        break;
                    case "4":
                        Console.Clear();
                        postServies.EditPost();
                        break;
                    case "5":
                        Console.Clear();
                        postServies.GetAllPost();
                        break;
                    default:
                        break;
                }

            } while (click != "00");
        }
        public void welcomservies4()
        {
            CommentServer comment = new CommentServer();
            string click;
            do
            {
                Console.WriteLine($"Hello\nclick 1 if you want Addcomment\n" +
                                   $"click 2 if you want  RemoveCommentt\n " +
                                   $"click 3 if you want  Search\n" +
                                   $"click 4 if you want  update\n" +
                                   $"click 5 if you want  GetAllData\n" +
                                   $"click00 if you want exist"

                                   );
                click = Console.ReadLine();
                switch (click)
                {
                    case "1":
                        Console.Clear();
                        comment.CreateData();
                        break;
                    case "2":

                        Console.Clear();
                        Console.Write("Please enter number : ");
                        int id = int.Parse(Console.ReadLine());
                        comment.Delete(id);
                        break;
                    case "3":

                        Console.Clear();
                        Console.Write("Please enter number : ");
                        int commentid = int.Parse(Console.ReadLine());
                        comment.GetCommentId(commentid);
                        break;
                    case "4":
                        Console.Clear();
                        comment.Edit();
                        break;
                    case "5":
                        Console.Clear();
                        comment.GetAllcomment();
                        break;
                    default:
                        break;
                }

            } while (click != "00");
        }
    }
}
