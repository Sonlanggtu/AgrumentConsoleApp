using MatthiWare.CommandLine.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppAgrs
{
    public class ParamOptions
    {
        [Name("u", "username"), Description("Tham số username")]
        public string UserName { set; get; }

        [Name("f", "fullname"), Description("Tham số fullname")]
        public string FullName { set; get; }

        [Name("af", "autoFillName"), Description("Khai báo thêm tham số này sẽ tự động đổ vào trường fullname")]
        public bool AutoFillName { set; get; }


        [Name("o", "Old"), Description("Khai báo tuổi")]
        public int Old { set; get; }

        //[Name("v", "version"), Description("Khai báo version")]
        //public string Version { set; get; }
    }
}
