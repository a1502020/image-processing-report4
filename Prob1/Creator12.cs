using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessing;

namespace Prob1
{
    /// <summary>
    /// (12).周波数8[Hz]、振幅30の縦方向の方形波と周波数8[Hz]、
    /// 振幅30の横方向の方形波の合成画像（濃度40～160）
    /// </summary>
    class Creator12 : Creator
    {
        public GlayImage Create(int n)
        {
            var res = new GlayImage(new Size(n, n));
            var offset = 100;
            for (var y = 0; y < res.Size.Height; ++y)
            {
                for (var x = 0; x < res.Size.Width; ++x)
                {
                    var a = (x % (res.Size.Width / 8) < res.Size.Width / 8 / 2) ? -30 : 30;
                    var b = (y % (res.Size.Height / 8) < res.Size.Height / 8 / 2) ? -30 : 30;
                    res[x, y] = offset + a + b;
                }
            }
            return res;
        }

        public string Name
        {
            get { return "12"; }
        }
    }
}
