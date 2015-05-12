using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessing;

namespace Prob1
{
    /// <summary>
    /// (9). (1)の画像に空間周波数4[Hz]、振幅30、横方向と空周波数32[Hz]、
    /// 振幅30、縦方向との正弦波成分の画像（濃度40～180）
    /// </summary>
    class Creator9 : Creator
    {
        public GlayImage Create(int n)
        {
            var res = new GlayImage(new Size(n, n));
            var offset = 100;
            for (var y = 0; y < res.Size.Height; ++y)
            {
                for (var x = 0; x < res.Size.Width; ++x)
                {
                    res[x, y] = (int)(offset
                        + 30 * Math.Sin(x * Math.PI * 2 * 4 / res.Size.Width)
                        + 30 * Math.Sin(y * Math.PI * 2 * 4 / res.Size.Height)
                        );
                }
            }
            return res;
        }

        public string Name
        {
            get { return "9"; }
        }
    }
}
