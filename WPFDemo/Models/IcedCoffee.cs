using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
   public class IcedCoffee : Product
    {
      public  IcedCoffee(List<IMyAction> actionList, String imageSrc, String title) : base(actionList, imageSrc, title, ProductOrderState.Srart)
        {
            
        }
    }
}
