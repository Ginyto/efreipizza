

namespace Projet
{
    public class Payment
    {
        private string ClientName;
        private string ClientFirstName;
        private string TypeOfPayment;
        private int PriceOrder;

        public Payment(string ClientName, string ClientFirstName, string TypeOfPayment,int PriceOrder)
        {
            this.ClientName=ClientName;
            this.ClientFirstName=ClientFirstName;
            this.TypeOfPayment=TypeOfPayment;
            this.PriceOrder=PriceOrder;
            
        }
    }
}