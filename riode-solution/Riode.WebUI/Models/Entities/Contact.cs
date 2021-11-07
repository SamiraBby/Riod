using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Riode.WebUI.Models.Entities
{
    public class Contact
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Answer { get; set; }
        public DateTime? AnswerDate { get; set; }
        public int?  AnsweredByUserID { get; set; }
    }
}
