using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattem
{
    /// <summary>
    ///  一个代理
    /// </summary>
    class ProxySubject : ISubject
    {
        private ISubject _RealSubject = new RealSubject();

        public bool GetSomething()
        {
            return this._RealSubject.GetSomething(); 
        }
        public void DoSomething()
        {
            this._RealSubject.DoSomething();
        }
    }
}
