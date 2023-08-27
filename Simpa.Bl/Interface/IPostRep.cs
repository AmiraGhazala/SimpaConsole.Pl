using Simpa.Bl.ModelVm;
using Simpa.DAL.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpa.Bl.Interface
{
    public interface IPostRep
    {
        List<Post> GetAllPost();
        void CreatePost(Post user);
        Post GetPostId(int PostId);
        void DeletePost(int PostId);
        void UpdatePost(PostVm postVm);
    }
}
