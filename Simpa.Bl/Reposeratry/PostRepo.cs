using Microsoft.EntityFrameworkCore;
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
    public class PostRepo:IPostRep
    {
        #region field
        AppplicationDbContext db = new AppplicationDbContext();
        #endregion

        #region handel function
        public void CreatePost(Post post)
        {
            try
            {
                post.date = DateTime.Now;
                db.posts.Add(post);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        public void DeletePost(int postid)
        {
            if (postid != null && postid != 0)
            {
                var post = db.posts.Where(a => a.Id == postid).FirstOrDefault();
                if (post != null)
                {
                    post.IsDeleted = true;
                    db.SaveChanges();
                }
            }
        }

        public List<Post> GetAllPost()
        {
            var post = db.posts.Where(a => a.IsDeleted != true).Include(a=>a.User).ToList();
            return post;
        }

        public Post GetPostId(int postid)
        {
            if (postid != null && postid != 0)
            {
                var post = db.posts.Where(a => a.Id == postid).Include(a => a.User).FirstOrDefault();
                return post;
            }
            return null;
        }

        public void UpdatePost(PostVm postvm)
        {
            if (postvm.Id != null && postvm.Id != 0)
            {
                var Old = db.posts.Where(a => a.Id == postvm.Id).FirstOrDefault();
                if (postvm != null)
                {
                    Old.Body=postvm.Body;


                    db.SaveChanges();
                }
            }
        }
        #endregion
    }
}
