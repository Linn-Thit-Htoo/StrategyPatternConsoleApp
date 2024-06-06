﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternConsoleApp
{
    public interface IPaymentStrategy
    {
        void ProcessPayment(decimal amount);
    }
}