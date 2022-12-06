
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab4
{
    public class Appointment
    {
        
        public int Id { get; set; }

        public int? Client { get; set; }

        public int? Product { get; set; }

        public int? Staff { get; set; }

        public int? Service { get; set; }

        public DateTime? Date { get; set; }

        public int? Salon { get; set; }
       
    }
}

