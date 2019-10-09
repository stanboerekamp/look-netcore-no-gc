﻿using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using System;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args, new DebugInProcessConfig());
            Console.ReadKey();
        }
    }
}
