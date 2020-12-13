using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class BM_BoTieuDen : BM_Base
    {
        public BM_BoTieuDen()
        {
            name = "Bánh mì Bò tiêu đen";
            MainIngredient = "Bò";
            sauce = "Sốt tiêu đen";
            price = 40000;
            toppings.Add("Ớt chuông");
            toppings.Add("Hành tây");
            toppings.Add("Tiêu hạt");
        }
    }
}
