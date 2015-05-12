using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessing;

namespace Prob3
{
    class Program
    {
        static void Main(string[] args)
        {
            // "1" ～ "12"
            var names = new List<string>();
            for (var i = 1; i <= 12; ++i)
            {
                names.Add(i.ToString());
            }

            // ヒストグラム画像作成
            foreach (var name in names)
            {
                var img = new GlayImage(name + ".pgm");
                var hist = new Histgram(img);
                var histImg = hist.GetHistgramImage();
                histImg.Write(name + "_hist.pgm");
            }
        }
    }
}
