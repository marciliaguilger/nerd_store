using System;
using System.Linq;

namespace NerdStore.Pagamentos.AntiCorruption
{
    public class PayPalGateway : IPayPalGateway
    {
        //As implementações são simulações
        public bool CommitTransaction(string cardHashKey, string orderId, decimal amount)
        {
            return new Random().Next(2) == 0; //vai sortear numeros de 0 a 2 -> sorteio de pagamento
            //return false;
        }

        public string GetCardHashKey(string serviceKey, string cartaoCredito)
        {
            return new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }

        public string GetPayPalServiceKey(string apiKey, string encriptionKey)
        {
            return new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }

    }
        

}
