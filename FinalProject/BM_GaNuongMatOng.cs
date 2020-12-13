using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class BM_GaNuongMatOng : BM_Base
    {
        public BM_GaNuongMatOng()
        {
            name = "Bánh mì Gà nướng mật ong";
            MainIngredient = "Gà";
            sauce = "Tương ớt";
            price = 35000;
            toppings.Add("Dưa leo");
            toppings.Add("Ngò tây");
            toppings.Add("");
        }
    }
}
