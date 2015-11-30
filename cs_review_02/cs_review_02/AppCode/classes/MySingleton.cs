using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_review_02
{
    public class MySingleton
    {
        static public int MyAdd(int x, int y)
        {
            return (x + y);
        }

        static public void MyAdd2(ref int res, int x, int y)
        {
            res += x + y;
        }

        static public void MyAdd3(ref int res, int x, int y)
        {
            res += x * y;
        }

        static public void AddNum1(out int res, ref int x, ref int y)
        {
            res = x + y;
            Console.WriteLine(res);
        }

        static public int MyDevide(int x, int y)
        {
            return x / y;
        }

    }
}
