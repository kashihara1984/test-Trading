using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace KyabusuC.DataAceess
{
    class T_BOS
    {
        //Sql文専用クラス(セルティックス)
        private DataTable dt = new DataTable();
        private DBmanager BOSDB = DBmanager.CreateInstance();
        //セルティックステーブル全て取得
        public DataTable BOSAllSelect()
        {
            string sql = @"select 
                            UniformNumber,
                            Name,
                            Height,
                            BodyWeight,
                            StartingMember,
                            Comment
                     　from 
                            T_セルティックス";

            dt = BOSDB.get(sql, null);
            return dt;
        }
        //背番号の値のみ取得
        public DataTable BOSUniformNumber()
        {
            string sql = @"select 
                            UniformNumber
                     　    from 
                            T_セルティックス";

            dt = BOSDB.get(sql, null);
            return dt;
        }
        //背番号,名前,身長,体重,先発又は控え,コメントの値を格納
        public string _number;
        public string _name;
        public string _height;
        public string _weight;
        public string _start;
        public string _comment;
        //キャバリアーズテーブルに追加登録(準備)
        public void BOSEntry()
        {
            string sql = @"insert into 
                            T_セルティックス 
                           values
                            (@背番号,
                             @名前, 
                             @身長, 
                             @体重,
                             @先発,
                             @コメント)";

            SqlParameter number = new SqlParameter("@背番号", _number);
            SqlParameter name = new SqlParameter("@名前", _name);
            SqlParameter height = new SqlParameter("@身長", _height);
            SqlParameter weight = new SqlParameter("@体重", _weight);
            SqlParameter start = new SqlParameter("@先発", _start);
            SqlParameter comment = new SqlParameter("@コメント", _comment);
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(number);
            paras.Add(name);
            paras.Add(height);
            paras.Add(weight);
            paras.Add(start);
            paras.Add(comment);
            BOSDB.BeginTrans();//トランザクション
            BOSDB.Execution(sql, paras);
        }
        //トランザクション(コミット)
        public void Decision()
        {
            BOSDB.CommitTrans();
        }
        //トランザクション(ロールバック)
        public void Cancel()
        {
            BOSDB.RollbackTrans();
        }
        //選手名のみを取得
        public DataTable BOSName()
        {
            string sql = @"select 
                            Name
                     　    from 
                            T_セルティックス";

            dt = BOSDB.get(sql, null);
            return dt;
        }
        //移籍画面の選手名格納
        public string TransMan;
        //選手データ削除
        public void Transfer()
        {
            string sql = @"delete from                            
                            T_セルティックス
                           where
                            Name = @名前";
            SqlParameter name = new SqlParameter("@名前", TransMan);
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(name);
            BOSDB.BeginTrans();//トランザクション
            BOSDB.Execution(sql, paras);
        }
        //選手データの更新
        public void Update()
        {
            string sql = @"update 
                            T_セルティックス 
                           set
                             Name=@名前,
                             Height=@身長, 
                             BodyWeight= @体重, 
                             StartingMember=@先発,
                             Comment=@コメント
                            where
                             UniformNumber=@背番号";

            SqlParameter number = new SqlParameter("@背番号", _number);
            SqlParameter name = new SqlParameter("@名前", _name);
            SqlParameter height = new SqlParameter("@身長", _height);
            SqlParameter weight = new SqlParameter("@体重", _weight);
            SqlParameter start = new SqlParameter("@先発", _start);
            SqlParameter comment = new SqlParameter("@コメント", _comment);
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(number);
            paras.Add(name);
            paras.Add(height);
            paras.Add(weight);
            paras.Add(start);
            paras.Add(comment);
            BOSDB.BeginTrans();//トランザクション
            BOSDB.Execution(sql, paras);
        }
        //先発セレクト
        public DataTable Starting()
        {
            string sql = @"select 
                            UniformNumber,
                            Name,
                            Height,
                            BodyWeight,
                            StartingMember,
                            Comment
                     　    from 
                            T_セルティックス
                           where
                            StartingMember = @先発";
            SqlParameter start = new SqlParameter("@先発", _start);
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(start);
            dt = BOSDB.get(sql, paras);
            return dt;
        }
        //2m以上セレクト
        public DataTable Heighting()
        {
            string sql = @"select 
                            UniformNumber,
                            Name,
                            Height,
                            BodyWeight,
                            StartingMember,
                            Comment
                     　    from 
                            T_セルティックス
                           where
                            Height >= @身長";
            SqlParameter height = new SqlParameter("@身長", _height);
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(height);
            dt = BOSDB.get(sql, paras);
            return dt;
        }
        //ポジション別セレクト
        public DataTable Positioning()
        {
            string sql = @"select 
                            UniformNumber,
                            Name,
                            Height,
                            BodyWeight,
                            StartingMember,
                            Comment
                     　    from 
                            T_セルティックス
                           where
                            Comment = @コメント";
            SqlParameter comment = new SqlParameter("@コメント", _comment);
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(comment);
            dt = BOSDB.get(sql, paras);
            return dt;
        }
    }
}
