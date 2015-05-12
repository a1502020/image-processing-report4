using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessing;

namespace Prob1
{
    /// <summary>
    /// (2). 画像の中心に大きさ画像サイズの1/4の大きさ
    /// (画像サイズ256の場合、64の正方形）：濃度値は200、他は濃度値0
    /// </summary>
    class Creator2 : Creator
    {
        public GlayImage Create(int n)
        {
            var res = new GlayImage(new Size(n, n));
            var min = n * 3 / 8;
            var max = n * 5 / 8 - 1;
            for (var y = 0; y < res.Size.Height; ++y)
            {
                for (var x = 0; x < res.Size.Width; ++x)
                {
                    if (x >= min && x <= max && y >= min && y <= max)
                    {
                        res[x, y] = 200;
                    }
                    else
                    {
                        res[x, y] = 0;
                    }
                }
            }
            return res;
        }

        public string Name
        {
            get { return "2"; }
        }
    }
}
