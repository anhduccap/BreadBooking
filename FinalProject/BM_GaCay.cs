using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class BM_GaCay : BM_Base
    {
        public BM_GaCay()
        {
            name = "Bánh mì Gà cay";
            MainIngredient = "Gà";
            sauce = "Tương ớt";
            price = 35000;
            toppings.Add("Dưa leo");
            toppings.Add("Ớt tươi");
            toppings.Add("Rau răm");
        }
    }
}
