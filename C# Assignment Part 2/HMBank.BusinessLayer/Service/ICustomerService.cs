using HMBank.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMBank.BusinessLayer.Service
{
    public interface ICustomerService
    {
        void RegisterCustomer(Customer customer);
        Customer RetrieveCustomer(int customerId);
        IEnumerable<Customer> GetAllCustomers();
    }
}
