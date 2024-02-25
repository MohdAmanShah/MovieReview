using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class Review
    {
        [Key]
        public Guid Id { get; set; }
        public DateOnly Date { get; set; }
        public List<String> DownloadLinks { get; set; }
        public string Body { get; set; }
        public int Upvotes { get; set; }
        public Movie Movie { get; set; }
    }
}
