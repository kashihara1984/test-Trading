using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using KyabusuC.Common;

namespace KyabusuC.DataAceess
{
    class ThreeTeamAllPlayer
    {
        //Sql文専用クラス
        private DataTable dt = new DataTable();
        private DBmanager NBADB = DBmanager.CreateInstance();

        //チーム名の格納プロパティ
        public string ClassTeamName {private get; set; }

        //チーム選手全て取得
        public DataTable NBAAllSelect()
        {
            string sql = @"select 
                            UniformNumber,
                            Name,
                            Height,
                            BodyWeight,
                            StartingMember,
                            Position,
                            TeamID
                     　    from "
                             + Const.COL_TeamTable +
                          @" where
                            TeamID = @チーム名";
            SqlParameter classTeamName = new SqlParameter("@チーム名", ClassTeamName);
            List<SqlParameter> A_paras = new List<SqlParameter>();
            A_paras.Add(classTeamName);
            dt = NBADB.get(sql, A_paras);
            return dt;
        }
        //データ格納
        public string _number;
        public string _name;
        public string _height;
        public string _weight;
        public string _start;
        public string _position;
        //チーム選手の先発のみ取得
        public DataTable NBAAllStart()
        {
            string sql = @"select 
                            UniformNumber,
                            Name,
                            Height,
                            BodyWeight,
                            StartingMember,
                            Position,
                            TeamID
                     　    from "
                             + Const.COL_TeamTable +
                         @"  where
                            TeamID = @チーム名
                           and
                            StartingMember = @先発";
            SqlParameter classTeamName = new SqlParameter("@チーム名", ClassTeamName);
            SqlParameter classTeamPosition = new SqlParameter("@先発", 1);
            List<SqlParameter> S_paras = new List<SqlParameter>();
            S_paras.Add(classTeamName);
            S_paras.Add(classTeamPosition);
            dt = NBADB.get(sql, S_paras);
            return dt;
        }
        //チーム選手の2m以上のみ取得
        public DataTable NBAAllHeight()
        {
            string sql = @"select 
                            UniformNumber,
                            Name,
                            Height,
                            BodyWeight,
                            StartingMember,
                            Position,
                            TeamID
                     　    from "
                             + Const.COL_TeamTable +
                          @" where
                            TeamID = @チーム名
                           and
                            Height >= @身長";
            SqlParameter classTeamName = new SqlParameter("@チーム名", ClassTeamName);
            SqlParameter classTeamHeight = new SqlParameter("@身長", 200);
            List<SqlParameter> H_paras = new List<SqlParameter>();
            H_paras.Add(classTeamName);
            H_paras.Add(classTeamHeight);
            dt = NBADB.get(sql, H_paras);
            return dt;
        }
        //チーム選手のポジション別の取得
        public DataTable NBAAllPosition()
        {
            string sql = @"select 
                            UniformNumber,
                            Name,
                            Height,
                            BodyWeight,
                            StartingMember,
                            Position,
                            TeamID
                     　    from "
                             + Const.COL_TeamTable +
                          @" where
                            TeamID = @チーム名
                           and
                            Position = @ポジション";
            SqlParameter classTeamName = new SqlParameter("@チーム名", ClassTeamName);
            SqlParameter classTeamPosition = new SqlParameter("@ポジション", _position);
            List<SqlParameter> P_paras = new List<SqlParameter>();
            P_paras.Add(classTeamName);
            P_paras.Add(classTeamPosition);
            dt = NBADB.get(sql, P_paras);
            return dt;
        }
        //チーム選手の背番号の取得
        public DataTable NBAAllNumber()
        {
            string sql = @"select 
                            UniformNumber                           
                          from "
                           + Const.COL_TeamTable +
                         @"  where
                            TeamID = @チーム名";
            SqlParameter classTeamName = new SqlParameter("@チーム名", ClassTeamName);            
            List<SqlParameter> N_paras = new List<SqlParameter>();
            N_paras.Add(classTeamName);
            dt = NBADB.get(sql, N_paras);
            return dt;
        }
        //チーム選手の名前の取得
        public DataTable NBAAllName()
        {
            string sql = @"select 
                            Name                           
                     　    from  "
                             + Const.COL_TeamTable +
                          @"  where
                            TeamID = @チーム名";
            SqlParameter classTeamName = new SqlParameter("@チーム名", ClassTeamName);
            List<SqlParameter> N_paras = new List<SqlParameter>();
            N_paras.Add(classTeamName);
            dt = NBADB.get(sql, N_paras);
            return dt;
        }
        //登録
        public void NBAAllEntry()
        {
            string sql = @"insert into  " 
                             + Const.COL_TeamTable + 
                           @" values
                            (@背番号,
                             @名前, 
                             @身長, 
                             @体重,
                             @先発,
                             @ポジション,
                             @チーム名)";

            SqlParameter classTeamName = new SqlParameter("@チーム名", ClassTeamName);
            SqlParameter ClassNumber = new SqlParameter("@背番号", _number);
            SqlParameter className = new SqlParameter("@名前", _name);
            SqlParameter classHeight = new SqlParameter("@身長", _height);
            SqlParameter classWeight = new SqlParameter("@体重", _weight);
            SqlParameter classStart = new SqlParameter("@先発", _start);
            SqlParameter classPosition = new SqlParameter("@ポジション", _position);
            List<SqlParameter> N_paras = new List<SqlParameter>();
            N_paras.Add(classTeamName);
            N_paras.Add(ClassNumber);
            N_paras.Add(className);
            N_paras.Add(classHeight);
            N_paras.Add(classWeight);
            N_paras.Add(classStart);
            N_paras.Add(classPosition);
            NBADB.BeginTrans();//トランザクション
            NBADB.Execution(sql, N_paras);
        }
        //登録
        public void NBAAllUpdate()
        {
            string sql = @"update "
                            + Const.COL_TeamTable +
                         @" set
                             Name=@名前,
                             Height=@身長, 
                             BodyWeight= @体重, 
                             StartingMember=@先発,
                             Position=@ポジション
                            where
                             TeamID = @チーム名
                            and
                             UniformNumber=@背番号";

            SqlParameter classTeamName = new SqlParameter("@チーム名", ClassTeamName);
            SqlParameter ClassNumber = new SqlParameter("@背番号", _number);
            SqlParameter className = new SqlParameter("@名前", _name);
            SqlParameter classHeight = new SqlParameter("@身長", _height);
            SqlParameter classWeight = new SqlParameter("@体重", _weight);
            SqlParameter classStart = new SqlParameter("@先発", _start);
            SqlParameter classPosition = new SqlParameter("@ポジション", _position);
            List<SqlParameter> N_paras = new List<SqlParameter>();
            N_paras.Add(classTeamName);
            N_paras.Add(ClassNumber);
            N_paras.Add(className);
            N_paras.Add(classHeight);
            N_paras.Add(classWeight);
            N_paras.Add(classStart);
            N_paras.Add(classPosition);
            NBADB.BeginTrans();//トランザクション
            NBADB.Execution(sql, N_paras);
        }
        //削除
        public void TransMan()
        {
            string sql = @"delete from "                            
                           + Const.COL_TeamTable +
                         @" where
                            TeamID = @チーム名
                           and
                            Name = @名前";
            SqlParameter classTeamName = new SqlParameter("@チーム名", ClassTeamName);           
            SqlParameter className = new SqlParameter("@名前", _name);            
            List<SqlParameter> T_paras = new List<SqlParameter>();
            T_paras.Add(classTeamName);
            T_paras.Add(className);            
            NBADB.BeginTrans();//トランザクション
            NBADB.Execution(sql, T_paras);
        }
        //トランザクション(コミット)
        public void Bigin()
        {
            NBADB.BeginTrans();
        }
        //トランザクション(コミット)
        public void Decision()
        {
            NBADB.CommitTrans();
        }
        //トランザクション(ロールバック)
        public void Cancel()
        {
            NBADB.RollbackTrans();
        }



    }
}
