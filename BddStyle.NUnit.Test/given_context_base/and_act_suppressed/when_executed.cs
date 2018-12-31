﻿using FluentAssertions;
using NUnit.Framework;

namespace BddStyle.NUnit.Test.given_context_base.and_act_suppressed
{
    public class when_executed : given_context_base.Context
    {
        [Test]
        public void then_calls_are_as_expected()
        {
            Calls.Should().BeEquivalentTo("Arrange", "ArrangeAsync");
        }
    }
}