﻿using NUnit.Framework;
using Topos.Tests.Contracts.Broker;

namespace Topos.Tests.InMem
{
    [TestFixture]
    public class InMemBasicProducerConsumerTest : BasicProducerConsumerTest<InMemBrokerFactory>
    {
        
    }
}