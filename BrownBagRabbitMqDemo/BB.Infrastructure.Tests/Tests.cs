using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BB.Infrastructure.Receiver;
using NUnit.Framework;
using BB.Infrastructure.Sender;

namespace BB.Infrastructure.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CanInstantiateSender()
        {
            var result = new SendRequest();
            Assert.That(result,Is.Not.Null);
        }
        [Test]
        public void CanInstantiateReceiver()
        {
            var result = new Receive();
            Assert.That(result,Is.Not.Null);
        }
    }
}
