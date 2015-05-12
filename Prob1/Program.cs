using System;
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
                new Creator2(),
                new Creator3(),
                new Creator4(),
                new Creator5(),
                new Creator6(),
                new Creator7(),
                new Creator8(),
                new Creator9(),
                new Creator10(),
            };

            foreach (var creator in creators)
            {
                var img = creator.Create(256);
                img.Write(creator.Name + ".pgm");
            }
        }
    }
}
