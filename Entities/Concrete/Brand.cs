using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Brand : IEntity
    {
        public Brand()
        {
            cars = new HashSet<Car>();
        }
        public int Id { get; set; }
        public string BrandName { get; set; }

        //Navigation Property
        public ICollection<Car> cars { get; set; }
    }
}
