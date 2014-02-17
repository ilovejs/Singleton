using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Sandbox
{
    [TestFixture]
    public class SingletonClient
    {
        [Test]
        public void UseSingleton()
        {
            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;
            Assert.AreSame(s1,s2);
        }
    }
}
