﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessing;

namespace Prob1
{
    /// <summary>
    /// (7). (1)の画像に空間周波数24[Hz]、振幅70、縦方向の余弦波成分の画像
    /// （濃度30～170 ）
    /// </summary>
    class Creator7 : Creator
    {
        public GlayImage Create(int n)
        {
            var res = new GlayImage(new Size(n, n));
            var offset = 100;
            for (var y = 0; y < res.Size.Height; ++y)
            {
                for (var x = 0; x < res.Size.Width; ++x)
                {
                    res[x, y] = (int)(offset + 70 * Math.Cos(y * Math.PI * 2 * 24 / res.Size.Width));
                }
            }
            return res;
        }

        public string Name
        {
            get { return "7"; }
        }
    }
}
