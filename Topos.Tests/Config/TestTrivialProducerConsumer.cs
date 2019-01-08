﻿using System.Threading.Tasks;
using NUnit.Framework;
using Topos.Config;
using Topos.EventStore.InMem;

namespace Topos.Tests.Config
{
    [TestFixture]
    public class TestTrivialProducerConsumer : FixtureBase
    {
        [Test]
        public async Task ItWorks()
        {
            var eventStore = new InMemEventStore();

            var producer = Configure.Producer()
                .EventStore(e => e.UseInMemory(eventStore))
                .Create();

            var consumer = Configure.Consumer()
                .EventStore(e => e.UseInMemory(eventStore))
                .Start();

            Using(consumer);

            await producer.Send("HEJ MED DIG MIN VEN");
        }
    }
}