using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace WebApplication1
{
    /// <summary>
    /// Handler1 的摘要说明
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            var obj = new List<object> { new { Id = "001", Name = "Pao" }, new { Id = "002", Name = "WaJueJi" } };
            context.Response.Write(new JavaScriptSerializer().Serialize(obj));
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}