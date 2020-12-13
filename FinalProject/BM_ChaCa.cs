using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class BM_ChaCa : BM_Base
    {
        public BM_ChaCa()
        {
            name = "Bánh mì Chả cá";
            MainIngredient = "Chả Cá";
            sauce = "Nước tương";
            price = 30000;
            toppings.Add("Rau răm");
            toppings.Add("Cà rốt");
            toppings.Add("");
        }
    }
}
