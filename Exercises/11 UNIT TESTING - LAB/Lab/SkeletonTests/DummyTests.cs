using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace SkeletonTests
{
    public class DummyTests
    {

        [Test]

        public void CanAttackDummy()
        {
            var dummy = new Dummy(10, 20);
            dummy.TakeAttack(5);
            Assert.That(() => dummy.Health, Is.EqualTo(4));

        }
    }
}
