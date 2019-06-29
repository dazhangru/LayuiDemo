using LinqToDB;
using LinqToDB.Data;
using mall;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LayUIDemo.Models
{
    public partial class DBMall : DataConnection
    {
        //public mallDB():base("mall")
        //{
        //}
        public ITable<UserInfo> Userinfo => GetTable<UserInfo>();
    }
}