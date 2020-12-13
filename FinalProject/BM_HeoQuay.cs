using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class BM_HeoQuay : BM_Base
    {
        public BM_HeoQuay()
        {
            name = "Bánh mì Heo quay";
            MainIngredient = "Heo quay";
            sauce = "Sốt chua ngọt";
            price = 30000;
            toppings.Add("Dưa leo");
            toppings.Add("Ớt chuông");
            toppings.Add("");
        }
    }
}
