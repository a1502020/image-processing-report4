﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessing;

namespace Prob1
{
    class Program
    {
        static void Main(string[] args)
        {
            var creators = new List<Creator>()
            {
                new Creator1(),
            };

            foreach (var creator in creators)
            {
                var img = creator.Create(256);
                img.Write(creator.Name + ".pgm");
            }
        }
    }
}