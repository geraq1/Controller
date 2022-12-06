using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab4
{
  
    public class Staff
    {
     
        public int Id { get; set; }

        public string Surname { get; set; }

        public string Name { get; set; }

        public string Patronymic { get; set; }

        public int? PhoneNumber { get; set; }

        public string Address { get; set; }

        public string Position { get; set; }
        public int? AppointmentId { get; set; }
     

    }
    
}
