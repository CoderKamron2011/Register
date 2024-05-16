using Register.Models;

namespace Register.Broker.Storage
{
    internal interface IStorageBroker
    {
        bool CheckoutUser(Users user);
        Users SignUpUser(Users user);
    }
}
