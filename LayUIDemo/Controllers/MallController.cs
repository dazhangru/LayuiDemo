using LayUIDemo.Models;
using mall;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayUIDemo.Controllers
{
    public class MallController : Controller
    {
        public ActionResult PartV()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }/// <summary>
         /// 获取用户列表
         /// </summary>
         /// <param name="userName"></param>
         /// <param name="PageSize"></param>
         /// <param name="page"></param>
         /// <returns></returns>
        public ActionResult GetUerList(string userName, int limit, int page)
        {
            Sql sql = new Sql();
            int totalAmount;
            try
            {
                using (var db = new LayUIDemo.Models.DBMall())
                {

                    if (!string.IsNullOrEmpty(userName))
                    {
                        //sql.Append("where UserName=@0", userName);
                        var query = from p in db.Userinfo
                                    where p.UserName == userName
                                    orderby p.CreateTime
                                    select p;
                        totalAmount = query.Count();
                        return Json(ResultTemp<UserInfo>.OK(query.Skip((page - 1) * limit).Take(limit).ToList(), totalAmount), JsonRequestBehavior.AllowGet);
                    }
                    // var result = db.Page<UserInfo>(page, limit, sql);
                    var result = from p in db.Userinfo
                                 orderby p.CreateTime
                                 select p;
                    totalAmount = result.Count();
                    return Json(ResultTemp<UserInfo>.OK(result.Skip((page - 1) * limit).Take(limit).ToList(), totalAmount), JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet]
        // GET: Mall
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(UserInfo userInfo)//
        {
            userInfo.CreateTime = DateTime.Now;

            try
            {
                using (var db = new mallDB())
                {
                    if (db.Exists<UserInfo>("username=@0", userInfo.UserName))
                    {
                        return Content("注册失败:用户名已经存在");
                    }
                    var userId = db.Insert(userInfo);
                    if ((int)(userId) > 0)
                    {
                        return Content("注册成功");
                    }
                    return Content("注册失败");
                }
            }
            catch (Exception e)
            {
                return Content("发生错误:" + e.Message);
            }
        }
        public ActionResult Main()
        {
            return View();
        }
    }
}