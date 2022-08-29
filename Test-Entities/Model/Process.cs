using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Entities.Model
{
    public class Process
    {
        [Key]
        public int ProcessId { get; set; }
        public string ProcessDescription { get; set; }

    }
}
