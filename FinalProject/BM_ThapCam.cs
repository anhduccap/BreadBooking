using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class BM_ThapCam : BM_Base
    {
        public BM_ThapCam()
        {
            name = "Bánh mì Thập cẩm";
            MainIngredient = "Heo quay + Trứng";
            sauce = "Sốt chua ngọt";
            price = 40000;
            toppings.Add("Dưa leo");
            toppings.Add("Chua ngọt");
            toppings.Add("Ngò tây");
        }
    }
}
