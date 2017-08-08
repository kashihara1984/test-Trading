using ClipBoardTest.Common;
using OobayashiSama.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Configuration;
using OobayashiSama.Model;
using System.Text;

namespace OobayashiSama.BusinessLogic
{
    public class UsersBL
    {
        /// <summary>
        /// データを取得・整形
        /// </summary>
        /// <param name="name">検索で指定した名前(ある場合)</param>
        /// <returns></returns>
        public DataTable GetUsers(string name = null) 
        {
            DataTable returnTable = new DataTable();
            returnTable.Columns.Add("番号");
            returnTable.Columns.Add("名前");
            returnTable.Columns.Add("役職");
            returnTable.Columns.Add("更新日");

            //ｵﾌﾞｼﾞｪｸﾄ生成=コネクション生成
            using (DBManager dbMan = new DBManager())
            {
                //データの取得処理を行なう
                M_OBTaskDA access = new M_OBTaskDA(dbMan);
                DataTable getData = new DataTable();
                if (string.IsNullOrEmpty(name))
                {
                    getData = access.SelectAll();
                }
                else 
                {
                    getData = access.SelectFromName(name);
                }

                foreach (DataRow row in getData.Rows) 
                {
                    DataRow returnRow = returnTable.NewRow();
                    returnRow["番号"] = row["ID"];
                    returnRow["名前"] = row["Name"];
                    returnRow["役職"] = row["Position"];
                    returnRow["更新日"] = row["DateTime"];

                    returnTable.Rows.Add(returnRow);
                }

                return returnTable;
            }


        }

        /// <summary>
        /// データを取得
        /// </summary>
        /// <param name="no">番号</param>
        /// <returns>取得データ</returns>
        public UserModel GetUser(int no)
        {
            DataTable returnTable = new DataTable();
            returnTable.Columns.Add("番号");
            returnTable.Columns.Add("名前");
            returnTable.Columns.Add("役職");
            returnTable.Columns.Add("更新日");

            //ｵﾌﾞｼﾞｪｸﾄ生成=コネクション生成
            using (DBManager dbMan = new DBManager())
            {
                //データの取得処理を行なう
                M_OBTaskDA access = new M_OBTaskDA(dbMan);
                DataTable getData = access.SelectByID(no);

                UserModel returnModel = new UserModel();
                returnModel.ID = (int)getData.Rows[0]["ID"];
                returnModel.Name = getData.Rows[0]["Name"].ToString();
                returnModel.Position = getData.Rows[0]["Position"].ToString();
                if (getData.Rows[0]["DateTime"] != DBNull.Value) 
                {
                    returnModel.UpdDate = (DateTime)getData.Rows[0]["DateTime"];
                }

                return returnModel;
            }
        }

        /// <summary>
        /// データの更新を行う
        /// </summary>
        /// <param name="model">更新対象データ</param>
        public void UpdUser(UserModel model)
        {
            //ｵﾌﾞｼﾞｪｸﾄ生成=コネクション生成
            using (DBManager dbMan = new DBManager())
            {
                //データの更新処理を行なう
                M_OBTaskDA access = new M_OBTaskDA(dbMan);
                access.Update(model);
            }
        }

        /// <summary>
        /// データの削除を行う
        /// </summary>
        /// <param name="no">削除キー(番号)</param>
        public void DelUser(int no) 
        { 
            //ｵﾌﾞｼﾞｪｸﾄ生成=コネクション生成
            using (DBManager dbMan = new DBManager())
            {
                //データの削除処理を行なう
                M_OBTaskDA access = new M_OBTaskDA(dbMan);
                access.Delete(no);
            }
        }

        /// <summary>
        /// CSVを反映する
        /// </summary>
        public void CSVImport() 
        { 
            //ｵﾌﾞｼﾞｪｸﾄ生成=コネクション生成
            using (DBManager dbMan = new DBManager())
            {
                //トランザクション開始
                dbMan.BeginTrans();
                M_OBTaskDA access = new M_OBTaskDA(dbMan);
                
                // Insertデータ格納用モデル
                UserModel model = new UserModel();

                try
                {
                    // 一旦全部消す
                    access.DeleteAll();

                    //StreamReaderでCSVファイルを読み込む
                    string fileName = ConfigurationManager.AppSettings["inPath"];
                    StreamReader objStRe = new StreamReader(fileName, System.Text.Encoding.Default);

                    //読み込める文字が無くなるまで繰り返し
                    while (objStRe.Peek() > 0)
                    {

                        //その後1行ずつ読み込み
                        string stBuf = objStRe.ReadLine();

                        //読み込んだものを,で区切る
                        string[] arrayData = stBuf.Split(',');

                        model.ID = int.Parse(arrayData[0]);
                        model.Name = arrayData[1];
                        model.Position = arrayData[2];
                        model.UpdDate = DateTime.Now;

                        access.Insert(model);
                    }

                    dbMan.Commit();
                }
                catch (Exception ex) 
                {
                    dbMan.RollBack();
                    throw ex;
                }

            }
        }

        /// <summary>
        /// CSVを作成する
        /// </summary>
        /// <param name="sourceTable">元になるテーブル</param>
        /// <returns>CSVのパス</returns>
        public string CSVCreate(DataTable sourceTable) 
        {
            string nowDate = DateTime.Now.ToString("yyyyMMdd_hhmmss");
            string filePath = string.Format(ConfigurationManager.AppSettings["outPath"], nowDate);

            // 無い場合は作る
            if (!File.Exists(filePath)) 
            {
                // 作ったらストリームは閉じる
                File.Create(filePath).Close();
            }

            using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.GetEncoding("shift_jis")))
            {
                int rowCount = sourceTable.Rows.Count;
                // 行
                for (int rowc = 0; rowc < rowCount; rowc++)
                {
                    // リストの初期化
                    List<String> strList = new List<String>();

                    // 列
                    for (int colc = 0; colc < sourceTable.Columns.Count; colc++)
                    {
                        strList.Add(sourceTable.Rows[rowc][colc].ToString());
                    }
                    String[] strArray = strList.ToArray(); // 配列へ変換

                    // CSV 形式に変換
                    String strCsvData = String.Join(",", strArray);

                    writer.WriteLine(strCsvData);
                }
            }

            return filePath;
        }
    }
}