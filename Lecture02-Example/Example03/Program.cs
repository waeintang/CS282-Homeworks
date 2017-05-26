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
            Console.WriteLine(sql);
        }
    }
}
