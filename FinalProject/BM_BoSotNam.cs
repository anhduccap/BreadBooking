using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class BM_BoSotNam : BM_Base
    {
        public BM_BoSotNam()
        {
            name = "Bánh mì Bò sốt nấm";
            MainIngredient = "Bò";
            sauce = "Sốt nấm";
            price = 40000;
            toppings.Add("Nấm đùi gà");
            toppings.Add("Hành tây");
            toppings.Add("Ớt chuông");
        }
    }
}
