using MvcSample.Data;
using MvcSample.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSample.Controllers
{
    public class SampleController : Controller
    {
        private MvcSampleContext db = new MvcSampleContext();


        // GET: Sample
        public ActionResult Index()
        {
            // DataTableの場合
            //var table = new DataTable();

            //var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            //var connection = new SqlConnection(connectionString);
            //connection.Open();

            //// 実行するSQLの準備
            //var command = new SqlCommand();
            //command.Connection = connection;
            //command.CommandText = @"SELECT * FROM USERS";

            //// SQLの実行
            ////command.ExecuteReader();
            //var adapter = new SqlDataAdapter(command);
            //adapter.Fill(table);


            //// データベースの接続終了
            //connection.Close();

            //var list1 = table.AsEnumerable().ToList<DataRow>();

            //return View(list1);

            // 一つずつデータを取得する方法 -------------------
            //UserDepart userDepart = new UserDepart();

            //userDepart.Users = db.Users.ToList();
            //userDepart.Department = db.Departments.ToList();

            //return View(userDepart);
            //----ここまで----------------------------


            // LINQでデータ取得
            var userData = from a in db.Users
                           join b in db.Departments
                             on a.DepartmentId equals b.DepartmentID
                           select new UserData
                           {
                               UserID = a.ID,
                               Name = a.Name,
                               DepartmentID = b.ID,
                               Department = b.DepartmentName
                           };

            if (userData.ToList().Count <= 0)
            {
                System.Console.WriteLine("NotData found");
            }

            return View(userData);


        }

        public ActionResult AjaxTest()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Test(string str1, string str2)
        {
            IDictionary<String, String> dic = new Dictionary<String, String>();
            dic.Add(str1, str2);
            return Json(dic);
        }

    }
}