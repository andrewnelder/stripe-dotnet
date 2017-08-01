using System;
using Xunit;
using Xunit.Sdk;

namespace Stripe.Tests.XUnit
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    [XunitTestCaseDiscoverer("Stripe.Tests.XUnit._xunit.XunitExtensions.PartialTrustFactDiscoverer", "Stripe.Tests.XUnit")]
    public class PartialTrustFactAttribute : FactAttribute { }
}
