using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyabusuC.Common
{
    //言葉関連
   public class Word
    {
        //ユニコードによる文字のバイト数の取得
        //半角であるかのチェック
        public static bool LenB(string moji)
        {
            return moji.Length != Encoding.GetEncoding("shift_jis").GetByteCount(moji);
        }
        //全角であるかのチェック
        public static bool LenC(string moji)
        {
            return moji.Length * 2 != Encoding.GetEncoding("shift_jis").GetByteCount(moji);
        }
    }
}
