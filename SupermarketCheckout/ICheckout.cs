namespace SupermarketCheckout
{
    public interface ICheckout
    {
        int GetTotalPrice();
        void Scan(Item item);
    }
}