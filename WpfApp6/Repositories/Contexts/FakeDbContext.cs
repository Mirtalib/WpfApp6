using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp6.Models;

namespace WpfApp6.Repositories.Contexts
{
    public class FakeDbContext
    {
        public static List<Car>? Cars { get; set; } = new()
        {
            new Car
            {
                Id = 1,
                Make ="BMW",
                Model = "X6",
                Year = 2022
            },            
            new Car
            {
                Id = 1,
                Make ="Vaz",
                Model = "2107",
                Year = 2010
            }, 
            new Car
            {
                Id = 1,
                Make ="Audi",
                Model = "R8",
                Year = 2022
            }
        };
    }
}
