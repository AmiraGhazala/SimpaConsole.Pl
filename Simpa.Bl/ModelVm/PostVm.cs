using Simpa.DAL.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpa.Bl.ModelVm
{
    public class PostVm
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Min lenghth 2")]
        public string Body { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime date { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
