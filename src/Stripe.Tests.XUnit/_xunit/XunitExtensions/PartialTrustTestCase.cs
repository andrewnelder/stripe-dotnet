﻿using System.Threading;
using System.Threading.Tasks;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Stripe.Tests.XUnit._xunit.XunitExtensions
{
    public class PartialTrustTestCase : XunitTestCase
    {

        public PartialTrustTestCase() : base() {}

        public PartialTrustTestCase(IMessageSink diagnosticMessageSink, TestMethodDisplay defaultMethodDisplay, ITestMethod testMethod)
            : base(diagnosticMessageSink, defaultMethodDisplay, testMethod) { }

        public override Task<RunSummary> RunAsync(IMessageSink diagnosticMessageSink,
                                                  IMessageBus messageBus,
                                                  object[] constructorArguments,
                                                  ExceptionAggregator aggregator,
                                                  CancellationTokenSource cancellationTokenSource)
        {
            return new PartialTrustTestCaseRunner(this, DisplayName, SkipReason, constructorArguments, TestMethodArguments, messageBus, aggregator, cancellationTokenSource).RunAsync();
        }
    }
}
