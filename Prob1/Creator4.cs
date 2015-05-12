using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessing;

namespace Prob1
{
    /// <summary>
    /// (4). (1)の画像に空間周波数2[Hz]、振幅80、横方向の余弦波成分の画像
    /// （濃度20～180）
    /// </summary>
    class Creator4 : Creator
    {
        public ImageProcessing.GlayImage Create(int n)
        {
            var res = new GlayImage(new Size(n, n));
            var offset = 100;
            for (var y = 0; y < res.Size.Height; ++y)
            {
                for (var x = 0; x < res.Size.Width; ++x)
                {
                    res[x, y] = (int)(offset + 80 * Math.Cos(x * Math.PI * 2 * 2 / res.Size.Width));
                }
            }
            return res;
        }

        public string Name
        {
            get { return "4"; }
        }
    }
}
