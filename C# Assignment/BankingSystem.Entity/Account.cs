﻿namespace BankingSystem.Entities
{
    public class Account
    {
        public int AccountId { get; set; }
        public int CustomerId { get; set; }
        public string AccountType { get; set; } 
        public double Balance { get; set; }
    }
}

