using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class BM_Trung : BM_Base
    {
        public BM_Trung()
        {
            name = "Bánh mì Trứng";
            MainIngredient = "Trứng gà";
            sauce = "Tương ớt";
            price = 25000;
            toppings.Add("Dưa leo");
            toppings.Add("Ngò tây");
            toppings.Add("Pate");
        }
    }
}
