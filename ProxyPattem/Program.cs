using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattem
{
     /// <summary>
     /// 代理模式
     /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ISubject realSubject = new RealSubject();
            realSubject.GetSomething();
            realSubject.DoSomething();

            ISubject proSubject = new ProxySubject();
            proSubject.GetSomething();
            proSubject.DoSomething();
        }
    }
}
