namespace SOLIDPrinciples.ISP
{


    public interface IOrder : ICash , ICredit , IInstallment , IOnline
    {

        public void MethodForOrder();

    }


    public interface ICash
    {
        void ProcessCashInvoice();
    }
    public interface IOnline
    {
        void ProcessOnilePaymentInvoice();
    }

    public interface ICredit
    {
        void ProcessCashInvoice();
    }


    public interface IInstallment
    {
        void ProcessInstallment();
    }

}