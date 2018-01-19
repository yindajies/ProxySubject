using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProxyPattem
{ 
    /// <summary>
    ///  第三方封装的类和方法
    /// </summary>
    class RealSubject : ISubject
    {
        public RealSubject()
        {
            Thread.Sleep(2000);
            long IResult = 0;
            for (int i = 0; i < 10000; i++)
            {
                IResult += i;
            }
            Console.WriteLine("RealSubject被构造了");
        }
            
        public bool GetSomething()
        {
            Console.WriteLine("坐车去火车站看看余票信息");
            Thread.Sleep(1000);
            Console.WriteLine("显示有票");
            return true;
        }
        public void DoSomething()
        {
            Console.WriteLine("开始排队");
            Thread.Sleep(1000);
            Console.WriteLine("终于买到票了");
        }
    }
}