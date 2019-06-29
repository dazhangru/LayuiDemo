using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace LayUIDemo.Models
{
    public enum ResultEnum
    {
        [Description("参数错误")]
        InvalidParams = -3,
        [Description("无效的手机号")]
        InvalidPhone = -2,
        [Description("登录超时，请重新登录")]
        LoginOut = -1,
        [Description("系统错误")]
        Error = 0,
        [Description("成功")]
        Success = 1,
        [Description("没有数据")]
        NoData = 2
    }
}