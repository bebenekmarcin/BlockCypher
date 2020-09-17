#region
using System;
using BlockCypher.Objects;
using BlockCypher.Pcl;

#endregion

namespace BlockCypher.Test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                var b = new Blockcypher("f4dfb3efeb9d4e5ca036fbfab5d919c9", Endpoint.BtcTest3);

                var json = b.Send("mwv4fzSSxa5FTAGekECBbdLDk3tCLBxXJj",
                    "mg5svxPWuKwjBi8EhJUUdu985ub5dyRJDP",
                    "dc2e6bf2fd9dcbb79fc11f86acebb3ed2a85a304840e73e02930f63a3f154dde",
                    "03c0cb46037f7492fd46eaf783935c678d1ba17fc9d047a2dec4e3697fe9ed63a8",
                    new Satoshi(10000)).Result.ToJson();

                Console.WriteLine(json);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            Console.ReadKey();
        }
    }
}