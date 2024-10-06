using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using HMBank.Entity;

namespace HMBank.BusinessLayer
{
    public class Customers
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public Customers() { }
   

            public Customers(int customerId, string firstName, string lastName, string email, string phoneNumber, string address)
            {
            
                CustomerId = customerId;
                FirstName = firstName;
                LastName = lastName;
                Email = email;
                PhoneNumber = phoneNumber;
                Address = address;
            }

        public void PrintCustomerInfo()
        {
            Console.WriteLine($"Customer ID: {CustomerId}");
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Phone: {PhoneNumber}");
            Console.WriteLine($"Address: {Address}");
        }

        public bool IsValidEmail()
            {
                var emailRegex = new Regex(@"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$");
                return emailRegex.IsMatch(Email);
            }

            public bool IsValidPhoneNumber()
            {
                var phoneRegex = new Regex(@"^\d{10}$");
                return phoneRegex.IsMatch(PhoneNumber);
            }
        public void PrintCustomer()
        {
            Console.WriteLine($"Customer ID: {CustomerId}, Name: {FirstName} {LastName}, Email: {Email}, Phone: {PhoneNumber}, Address: {Address}");
        }
    }
    }

