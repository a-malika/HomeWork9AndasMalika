using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    public class KaspiPaymentAdapter : IPaymentProcessor
    {
        private KaspiPaymentService kaspiPaymentService;
        public KaspiPaymentAdapter(KaspiPaymentService kaspiPaymentService)
        {
            this.kaspiPaymentService = kaspiPaymentService;
        }
        public void ProcessPayment(double amount)
        {
            kaspiPaymentService.MakePayment(amount);
        }
    }
}
