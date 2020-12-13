using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class BM_GaSotNhat : BM_Base
    {
        public BM_GaSotNhat()
        {
            name = "Bánh mì Gà sốt Nhật";
            MainIngredient = "Gà";
            sauce = "Sốt Nhật";
            price = 35000;
            toppings.Add("Dưa leo");
            toppings.Add("Húng quế");
            toppings.Add("");
        }
    }
}
