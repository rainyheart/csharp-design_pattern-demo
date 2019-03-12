using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src
{
    class Singleton
    {
        private static Singleton _Singleton = null;
        private static object SingletonLock = new object();
        public static Singleton CreateInstance()
        {
            if (_Singleton == null)
            {
                lock (SingletonLock)
                {
                    if (_Singleton == null)
                    {
                        Console.WriteLine("Singleton is created");
                        _Singleton = new Singleton();
                    }
                }
            }
            return _Singleton;
        }
    }
}
