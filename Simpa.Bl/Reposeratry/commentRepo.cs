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
    public class commentRepo : Icomment
    {
        #region field
        AppplicationDbContext db = new AppplicationDbContext();
        #endregion
        #region handel function
        public void CreateComment(Comments comment)
        {
            try
            {
                comment.date = DateTime.Now;
                db.comments.Add(comment);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        public void DeleteComment(int CommentId)
        {
            if (CommentId != null && CommentId != 0)
            {
                var comment = db.posts.Where(a => a.Id == CommentId).FirstOrDefault();
                if (comment != null)
                {
                    comment.IsDeleted = true;
                    db.SaveChanges();
                }
            }
        }

        public List<Comments> GetAllComment()
        {
            var comment = db.comments.Where(a => a.IsDeleted != true).Include(a => a.User).ToList();
            return comment;
        }

        public Comments GetcommentId(int CommentId)
        {
            if (CommentId != null && CommentId != 0)
            {
                var comment = db.comments.Where(a => a.Id == CommentId).Include(a => a.User).FirstOrDefault();
                return comment;
            }
            return null;
        }

        public void Updatecomment(CommentVm commentVm)
        {
            if (commentVm.Id != null && commentVm.Id != 0)
            {
                var Old = db.comments.Where(a => a.Id == commentVm.Id).FirstOrDefault();
                if (commentVm != null)
                {
                    Old.Body = commentVm.Body;


                    db.SaveChanges();
                }
            }
        }
        #endregion
    }
}
