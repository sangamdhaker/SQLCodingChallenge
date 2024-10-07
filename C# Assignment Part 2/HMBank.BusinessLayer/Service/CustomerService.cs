using HMBank.BusinessLayer.Repository;
using HMBank.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMBank.BusinessLayer.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerService(ICustomerRepository customerRepo)
        {
            customerRepository = customerRepo;
        }

        public void RegisterCustomer(Customer customer)
        {
            customerRepository.AddCustomer(customer);
        }

        public Customer RetrieveCustomer(int customerId)
        {
            return customerRepository.GetCustomerById(customerId);
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return customerRepository.GetAllCustomers();
        }
    }
}
