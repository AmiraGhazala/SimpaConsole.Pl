using Simpa.Bl.ModelVm;
using Simpa.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpa.Bl.Interface
{
    public interface Icomment
    {
        List<Comments> GetAllComment();
        void CreateComment(Comments comment);
        Comments GetcommentId(int CommentId);
        void DeleteComment(int CommentId);
        void Updatecomment(CommentVm commentVm);
    }
}
