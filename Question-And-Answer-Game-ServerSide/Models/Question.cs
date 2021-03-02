using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Question_And_Answer_Game_ServerSide.Models
{
    public class Question
    {
        [Key]
        public int ID { get; set; }
        public string Text { get; set; }
    }
}
