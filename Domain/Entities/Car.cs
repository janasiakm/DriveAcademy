using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Car : AuditableEntitycs

    {
        public int CarId { get; set; }
        public string Mark { get; set; }
        public string Model { get; set; }
        public string NrRej { get; set; }
        public int ProdYear { get; set; }


        public Car() { }

        public Car(int id, string mark, string model, string nrRej) 
        {
            (CarId, Mark, Model, NrRej) = (id, mark, model, nrRej);
        }

    }

    

}
