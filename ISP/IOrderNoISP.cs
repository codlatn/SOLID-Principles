namespace SOLIDPrinciples.ISP
{
    public interface IOrderNoISP
    {
        void ProcessCashInvoice();
        void ProcessCreditInvoice();
        void ProcessOnilePaymentInvoice();
        void ProcessInstallment();
    }

}