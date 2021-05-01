
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72hr.Models.PostModel
{
    public class PostDetail
    {
        public int Id { get; set; }
        public string Title { get; set; }
       
        public List<PostCommentDetail> comments { get; set; }
    }
}
