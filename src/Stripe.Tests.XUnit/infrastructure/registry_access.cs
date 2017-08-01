using Xunit;
using System;
using System.Net.Http;
using Stripe.Infrastructure;
using Xunit.Abstractions;

namespace Stripe.Tests.XUnit
{
#if NET45
    public class registry_access : MarshalByRefObject
    {

        private readonly ITestOutputHelper output;

        public registry_access(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void full_trust_registry()
        {
            HttpRequestMessage req = new HttpRequestMessage();
            Client clt = new Client(req);
            clt.ApplyUserAgent();
            output.WriteLine("ANDREW");
            output.WriteLine(req.Headers.UserAgent.ToString());
        }

        [PartialTrustFact]
        public void partial_trust_registry()
        {
            HttpRequestMessage req = new HttpRequestMessage();
            Client clt = new Client(req);
            clt.ApplyUserAgent();
            output.WriteLine("ANDREW");
            output.WriteLine(req.Headers.UserAgent.ToString());
        }
    }
#endif
}
