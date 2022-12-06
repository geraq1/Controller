using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{

    public class Salon
    {
        [Key]
        public int Id { get; set; }

        public string Address { get; set; }

        public decimal Rating { get; set; }

        public string Traffic { get; set; }

    }


}