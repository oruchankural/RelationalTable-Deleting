﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Entities.Model
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }
        public string TicketCode { get; set; }

        virtual public Survey Survey { get; set; }
        virtual public Process Process { get; set; }
        virtual public Process Process2 { get; set; }


    }

}


