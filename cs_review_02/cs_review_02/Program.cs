using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_review_02
{
    class Program
    {
        public delegate int PerformCalculation(int x, int y);
        public delegate void MyCal01(ref int res, int x, int y);

        static void Main(string[] args)
        {
            /* 
            // delegate 1
            DelegatePracetice dp = new DelegatePracetice();
            PerformCalculation pc1 = new PerformCalculation(dp.add);
            var sum = pc1(3, 5);
            Console.WriteLine(sum);

            PerformCalculation pc2 = new PerformCalculation(MySingleton.MyAdd);
            sum = pc2(3, 5);
            Console.WriteLine(sum);

            PerformCalculation pc3 = new PerformCalculation(pc1);
            pc3 += pc2;
            sum = pc3(3, 5);
            Console.WriteLine(sum);
            */

            /*
            // delegate 2
            MyCal01 mc1 = new MyCal01(MySingleton.MyAdd2);
            mc1 += MySingleton.MyAdd3;

            var res = 0;
            mc1(ref res, 3, 5);

            Console.WriteLine(res);

            res = 0;
            MyCal01 mc2;
            mc2 = new MyCal01(MySingleton.MyAdd2);
            mc2(ref res, 3, 5);
            Console.WriteLine(res);
            */

            /*
            // delegate 3
            SomeDelegates.MyDelegate1 md_times;
            md_times = (x, y) => { return x * y; };
            Console.WriteLine(md_times(2, 4));      // 8

            SomeDelegates.MyDelegate1 md_devide;
            md_devide = new SomeDelegates.MyDelegate1(MySingleton.MyDevide);
            Console.WriteLine(md_devide(8, 2));     // 4

            SomeDelegates.MyDelegate1 md_test_subscr;
            md_test_subscr = new SomeDelegates.MyDelegate1((x, y) => { return x % y; });
            Console.WriteLine(md_test_subscr(5, 3)); // 2
            */

            // delegate 4
            SomeDelegates.MyDelegate1 md4;
            md4 = MySingleton.MyAdd;
            md4 += (x, y) => { return x * y;};
            //md4 += MySingleton.MyAdd;

            Console.WriteLine(md4(3, 7)); // 10



            /*
            // delegate - event
            SomeEvents se = new SomeEvents();
            se.MyClick += new SomeDelegates.MyClickHandler((o, e) => { Console.WriteLine("clicked by James"); });

             * */


            /*
            // ref and out practice
            int res_ro;
            int x = 1, y = 2;
            MySingleton.AddNum1(out res, ref x, ref y);
            //Console.WriteLine(res_ro); // error; unassigned local variable
             * */


        }

        public void Controller()
        {
            
        }

    }
}
