namespace Exercise.Services
{
    class PaypalService : IOnlinePaymentService
    {
        public double PaymentFee(double amount)
        {
            // IMPLEMENTAR CALCULO DE IMPOSTO
            return amount;
        }

        public double Interest(double amount, int months)
        {
            // IMPLEMENTAR
            return amount;
        }
    }
}
