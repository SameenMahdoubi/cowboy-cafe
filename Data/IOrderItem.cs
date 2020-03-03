﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public interface IOrderItem
    {
        double Price { get; }

        string Name { get; }
        List<string> SpecialInstructions { get; }


    }
}