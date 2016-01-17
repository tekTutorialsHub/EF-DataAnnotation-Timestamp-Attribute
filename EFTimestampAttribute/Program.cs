using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTimestampAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            EFContext ctx = new EFContext();
            ctx.Employees.Where(e => e.EmployeeID == 0);

            Console.WriteLine("Press any key to close");
            Console.ReadKey();

        }
    }
}
