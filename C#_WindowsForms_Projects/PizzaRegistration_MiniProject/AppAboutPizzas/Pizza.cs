using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAboutPizzas
{
    public class Pizza
    {
        private int Id;
        private KindOfPizza kind;
        private static int nextPizzaId = 1010;
        List<string> Toppings;
        public int ID
        {
            get { return this.Id; }
        }

        public Pizza(KindOfPizza Kind)
        {
            this.kind = Kind;
            this.Id = nextPizzaId;
            nextPizzaId += 10;
            Toppings = new List<string>();
        }
        public bool AddTopping(String topping)
        {
            if (this.Toppings.Count < 4)
            {
                this.Toppings.Add(topping);
                return true;
            }
            return false;
        }
        public String GetInfo()
        {
            string Info = this.kind.ToString() + " ";
            if (this.Toppings.Count > 0)
            {
                Info += String.Join(" ,", this.Toppings);
            }
            else
            {
                Info += "with no toppings";
            }
            return Info;
        }

    }
}
