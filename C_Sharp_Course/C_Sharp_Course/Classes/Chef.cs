using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Course.Classes
{
    class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes Chicken.");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes Salad.");
        }

        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes BBQ Ribs.");
        }
    }
}
