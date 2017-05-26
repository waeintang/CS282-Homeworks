using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    class Program
    {
        static void Main(string[] args)
        {
            string html = @"<html>
                                <head> </head>
                            </html>";
            string sql = @"select * from table
                                      where id > 10"; // @ :可以換行
            string path ="c:\\xamp\\htdoc\\"; // c:\xamp\htdoc\    => 一定要打兩個斜線 \
            string path2 = @"c:\xamp\htdoc\"; // 加入 @ 的話 路經可以忽略 斜線 \
            Console.WriteLine(sql);
        }
    }
}
