using ClipBoardTest.Common;
using OobayashiSama.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace OobayashiSama.DataAccess
{
    public class M_OBTaskDA
    {

        private DBManager _dbMan;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="dbMan">DB接続</param>
        public M_OBTaskDA(DBManager dbMan) 
        {
            _dbMan = dbMan;
        }

        /// <summary>
        /// ユーザのデータを全取得
        /// </summary>
        /// <returns>ユーザデータ</returns>
        public DataTable SelectAll() 
        {
            string storedName = "SelOB";
            DataTable getData = _dbMan.ReadTable(storedName);
            return getData;
        }

        // <summary>
        /// IDに準じた情報を取得
        /// </summary>
        /// <returns>ユーザデータ</returns>
        public DataTable SelectByID(int id)
        {
            string storedName = "SelOB";
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@ID", id));
            DataTable getData = _dbMan.ReadTable(storedName, paramList);
            return getData;
        }

        /// <summary>
        /// 名前に沿ってユーザのデータを取得
        /// </summary>
        /// <param name="name">ユーザ名</param>
        /// <returns>ユーザデータ</returns>
        public DataTable SelectFromName(string name)
        {
            string storedName = "SelOBLike";
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@Name", name));
            DataTable getData = _dbMan.ReadTable(storedName, paramList);
            return getData;
        }

        /// <summary>
        /// 特定のユーザのデータを消去
        /// </summary>
        /// <param name="id">識別ID</param>
        public void Delete(int id)
        {
            string storedName = "DelOB";
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@ID", id));
            _dbMan.WriteTable(storedName, paramList);
        }

        /// <summary>
        /// ユーザのデータを全消去
        /// </summary>
        public void DeleteAll()
        {
            string storedName = "DelOB";
            _dbMan.WriteTable(storedName);
        }

        /// <summary>
        /// データ登録
        /// </summary>
        /// <param name="insertModel">データモデル</param>
        public void Insert(UserModel insertModel) 
        {
            string storedName = "InsOB";
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@ID", insertModel.ID));
            paramList.Add(new SqlParameter("@Name", insertModel.Name));
            paramList.Add(new SqlParameter("@Position", insertModel.Position));
            paramList.Add(new SqlParameter("@DateTime", insertModel.UpdDate));
            _dbMan.WriteTable(storedName, paramList);

        }

        /// <summary>
        /// データ更新
        /// </summary>
        /// <param name="updateModel">データモデル</param>
        public void Update(UserModel updateModel)
        {
            string storedName = "UpdOB";
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@ID", updateModel.ID));
            paramList.Add(new SqlParameter("@Name", updateModel.Name));
            paramList.Add(new SqlParameter("@Position", updateModel.Position));
            paramList.Add(new SqlParameter("@DateTime", updateModel.UpdDate));
            _dbMan.WriteTable(storedName, paramList);

        }
    }
}