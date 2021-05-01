using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72hr.Models
{
    public class CommentListItem
    {
        public int CommentId { get; set; }
        public string Title { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
    }
}
