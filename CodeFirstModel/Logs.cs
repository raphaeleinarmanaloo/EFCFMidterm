using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstModel
{
    public class Logs
    {
        [Key]
        public int Id { get; set; }
        public int ObjectId {get; set;}
        public char Value { get; set; }
        public DateTime ValueStamp { get; set; }
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }   
        public DateTime ModifiedDate { get; set; }  

    }
}
