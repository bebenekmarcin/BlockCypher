using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlockCypher.Objects;
using Xunit;

namespace BlockCypher.Tests
{
    public class SendCryptoTests
    {
        [Fact]
        public void Send()
        {
            var b = new Blockcypher("f4dfb3efeb9d4e5ca036fbfab5d919c9", Endpoint.BtcTest3);

            var amountInSatoshi = Convert.ToInt64(0.0156813 * 100000000);

            var transaction = b.Send("mwv4fzSSxa5FTAGekECBbdLDk3tCLBxXJj",
                "mngqWGRMnsQHzRXPj7mtgb2YzRQkWKX9Ab",
                "dc2e6bf2fd9dcbb79fc11f86acebb3ed2a85a304840e73e02930f63a3f154dde",
                "03c0cb46037f7492fd46eaf783935c678d1ba17fc9d047a2dec4e3697fe9ed63a8",
                new Satoshi(10000)).Result;

            var tran = b.GetTransaction(transaction.Transactions.Hash).Result;
        }
    }
}
