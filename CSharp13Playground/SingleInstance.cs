using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp13Playground
{
    public  class SingleInstance
    {
        private static  SingleInstance _instance;

        //private static object _instanceLock = new object();
        private static object _instanceLock = new Lock();
        private SingleInstance()
        {

        }
        public static SingleInstance Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_instanceLock)
                    {
                        _instance = new SingleInstance();
                    }
                }
                return _instance;
            }
        }

        public int GetCount() => 1;

    }
}
