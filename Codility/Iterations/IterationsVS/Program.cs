﻿using System;

namespace IterationsVS
{
    class Program
    {
        static void Main(string[] args)
        {
			int n = 4;
			for (int i = 0; i < n; i++)
			{

				for (int j = 0; j <= i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
    }
}
