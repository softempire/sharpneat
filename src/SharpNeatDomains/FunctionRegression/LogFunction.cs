﻿/* ***************************************************************************
 * This file is part of SharpNEAT - Evolution of Neural Networks.
 * 
 * Copyright 2004-2016 Colin Green (sharpneat@gmail.com)
 *
 * SharpNEAT is free software; you can redistribute it and/or modify
 * it under the terms of The MIT License (MIT).
 *
 * You should have received a copy of the MIT License
 * along with SharpNEAT; if not, see https://opensource.org/licenses/MIT.
 */
using System;

// Disable comment warnings for trivial class.
#pragma warning disable 1591

namespace SharpNeat.Domains.FunctionRegression
{
    public class LogFunction : IFunction
    {
        public double GetValue(double[] args)
        {
            return 0.1 + (Math.Log(args[0]) * 0.17);
        }

        public int InputCount
        {
            get { return 1; }
        }
    }
}
