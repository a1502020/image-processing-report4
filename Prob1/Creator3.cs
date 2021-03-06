﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessing;

namespace Prob1
{
    /// <summary>
    /// (3). 画像の左側から右側へ濃度値が0→255に連続的に変化する画像
    /// </summary>
    class Creator3 : Creator
    {
        public ImageProcessing.GlayImage Create(int n)
        {
            var res = new GlayImage(new Size(n, n));
            for (var y = 0; y < res.Size.Height; ++y)
            {
                for (var x = 0; x < res.Size.Width; ++x)
                {
                    res[x, y] = x * 255 / res.Size.Width;
                }
            }
            return res;
        }

        public string Name
        {
            get { return "3"; }
        }
    }
}
