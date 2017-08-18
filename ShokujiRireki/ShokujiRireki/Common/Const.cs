using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShokujiRireki.Common
{
    //定数が宣言されているクラス
    public class Const
    {
        public const string COL_DATE = "日付";
        public const string COL_BREAKFAST = "朝食";
        public const string COL_LUNCH = "昼食";
        public const string COL_DINNER = "夕食";
        public const string COL_TOTAL_CAL = "1日のカロリー摂取量";
        public const string COL_NO = "No";
        public const string COL_FOODNAME = "FoodName";
        public const string COL_CAL = "CAL";
        public const string CLOSE_APPLICATION = "アプリケーションを終了します。よろしいですか?";
        public const string RETURN = "編集した内容を破棄しメイン画面に戻ります。よろしいですか？";
        public const string CHECK_CMB = "選択されていないコンボボックスがあります";
        //public const string CHECK_CMBMOJI = "コンボボックスの値に文字列が含まれています";
        public const string CHECK_CMBKIKAN = "不正な年月指定です";
        public const string CHECK_DATE = "今日より先の日付が指定されています。";
        public const string CHECK_HIDUKE = "既にその日付は登録されています。";
        public const string CHECK_INPUT = "未入力の場所があります";
        public const string CHECK_ZENKAKU = "全角文字が含まれています";
        public const string CHECK_LETTER_LENGTH = "文字数が不正です";
        public const string NOT_NUMBER = "カロリー数に数字でないものが含まれています";
        public const string NOT_UPDATED = "更新したデータはありません";
        public const string DATABASE_ERROR = "データベース関連でエラーが発生しました";
        public const string CONFIRM_REGISTRY = "入力された内容で登録しますか？";
        public const string CONFIRM_DELETE = "選択された商品を削除します。よろしいですか？";
        public const string CONFIRM = "確認";
        public const string NO_USER = "該当するユーザーは存在しません";
        public const string LOCKED_USER = "ログイン権限がありません。アプリケーションを終了します。";
        public const string LOCK_USER = "ロックしました。アプリケーションを終了します。";
        public const string UNMATCH_PASSWORD = "パスワードが一致しません";
        public const string ERROR = "予期せぬエラーが発生しました";

        public const string PARM_DATE = "@Date";
        public const string PARM_STRFROM = "@strFrom";
        public const string PARM_STRTO = "@strTo";
        public const string PARM_NO = "@No";
        public const string PARM_BREAKFAST = "@Breakfast";
        public const string PARM_LUNCH = "@Lunch";
        public const string PARM_DINNER = "@Dinner";
        public const string PARM_USER = "@User";
        public const string PARM_PASSWORD = "@Password";
        public const string PARM_FOODNAME = "@FoodName";
        public const string PARM_CAL = "@Cal";
        public const string PARM_DELFLG = "@Delflg";
    }
}
