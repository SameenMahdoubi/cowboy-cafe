using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public interface IOrderItem
    {
        double Price { get; }

        // Calories has been added as a nullable int because it is needed for some funcitonality in filtering the menu, but must be able ot have a null value.
        uint? Calories { get; }

        string Name { get; }
        List<string> SpecialInstructions { get; }


    }
}
