using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstModel
{
    public class ObjectValues
    {
        [Key]
        public int ObjectId { get; set; }
        public string? KeyValue { get; set; }
        public DateTime CreatedDate { get; set; }  
        public DateTime ModifiedDate { get; set; }

    }
}
