using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public Customer()
        {
            rentals = new HashSet<Rental>();
        }
        public int Id { get; set; }
        public int Userid { get; set; }
        public string CompanyName { get; set; }

        //Nav
        public User user { get; set; }
        public ICollection<Rental> rentals { get; set; }

    }
}
