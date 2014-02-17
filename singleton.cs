using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Singleton
    {
        private static class SingletonHolder
        {
            //When type constructor is called, CLI wil handle memroy races, not need of 'volatile' keywords 
            internal static readonly Singleton instance = new Singleton();
        
            //empty static constructor for .Net 4+ - forces laziness!
            //only execute once
            static SingletonHolder() {}
        }
        
        
        //override public constructor
        private Singleton()
        {
            Console.WriteLine("Singleton constructor");
        }

        public static Singleton Instance { get { return SingletonHolder.instance; } }

        public static void SayHi()
        {
            Console.WriteLine("Hi there!");
        }
        public void DoSomeThing()
        {
            
        }
    }
}
