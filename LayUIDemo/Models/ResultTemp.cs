using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LayUIDemo.Models
{
    public class ResultTemp<T>
    {
        public int code { get; set; }
        public string msg { get; set; }
        public long count { get; set; }
        public List<T> data { get; set; }
        public ResultTemp(List<T> data)
        {
            count = data.Count;
            this.data = data;
        }
        public static ResultTemp<T> OK(List<T> data, int totalAmount)
        {
            return new ResultTemp<T>(data) { code = (int)ResultEnum.Success, count = totalAmount, msg = "" };
        }
    }
}