using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Singleton
    {
        private static readonly object mutex = new object();
        private static volatile Singleton instance;
        private Singleton()
        {
        
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (mutex)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                        
                    }
                }
                return instance;
            }
        }

        public void DoSomeThing()
        {
            
        }
    }
}
