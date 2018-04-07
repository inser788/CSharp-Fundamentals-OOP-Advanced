using System;
using NUnit.Framework;

namespace SkeletonTests
{
    public class AxeTests
    {

        [Test]

        public void AxeAfterAttack()
        {
            var axe=new Axe(10,10);
            var dummy=new Dummy(10,10);

            axe.Attack(dummy);

            Assert.That(axe.DurabilityPoints,Is.EqualTo(9));
        }

        [Test]

        public void BrokenAxe()
        {
            var axe = new Axe(5, 0);
            var dummy = new Dummy(10, 10);

            //axe.Attack(dummy);
            Assert.That(()=>axe.Attack(dummy),Throws.InvalidOperationException.With.Message.EqualTo("Axe is broken."));
        }

    }
}
