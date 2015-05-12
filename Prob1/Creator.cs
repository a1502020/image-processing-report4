using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessing;

namespace Prob1
{
    /// <summary>
    /// 正方形の画像を生成するインターフェース。
    /// </summary>
    interface Creator
    {
        /// <summary>
        /// 画像を生成する。
        /// </summary>
        /// <param name="n">1辺の長さ</param>
        /// <returns>生成した画像</returns>
        GlayImage Create(int n);

        /// <summary>
        /// 画像生成の名前
        /// </summary>
        string Name { get; }
    }
}
