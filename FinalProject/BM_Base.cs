using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public abstract class BM_Base
    {
        protected string name;
        protected string MainIngredient;
        protected List<string> toppings = new List<string>();
        protected string sauce;
        protected int price;

        public string getName()
        {
            return name;
        }
        public string getMainIngredient()
        {
            return MainIngredient;
        }
        public string getSauce()
        {
            return sauce;
        }
        public int getPrice()
        {
            return price;
        }
        public List<string> getToppings()
        {
            return toppings;
        }
    }
}
