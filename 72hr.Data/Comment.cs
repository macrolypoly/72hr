using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72hr.Data
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        Guid AuthorId { get; set; }
        public virtual List<Reply> Replies { get; set; }
        [ForeignKey("PostId")]
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}
