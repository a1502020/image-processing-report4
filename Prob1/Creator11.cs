using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessing;

namespace Prob1
{
    /// <summary>
    /// (11). (1)の画像に周波数16[Hz]、振幅50の縦方向の方形波画像（濃度50～150）
    /// </summary>
    class Creator11 : Creator
    {
        public GlayImage Create(int n)
        {
            var res = new GlayImage(new Size(n, n));
            var offset = 100;
            for (var y = 0; y < res.Size.Height; ++y)
            {
                for (var x = 0; x < res.Size.Width; ++x)
                {
                    if (y % (res.Size.Height / 16) < res.Size.Height / 16 / 2)
                    {
                        res[x, y] = offset - 50;
                    }
                    else
                    {
                        res[x, y] = offset + 50;
                    }
                }
            }
            return res;
        }

        public string Name
        {
            get { return "11"; }
        }
    }
}
