﻿// 02. A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. 
// Customers could be individuals or companies. 
// All accounts have customer, balance and interest rate (monthly based). Deposit accounts are allowed to deposit and with
// draw money. Loan and mortgage accounts can only deposit money.
// All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated 
// as follows: number_of_months * interest_rate.
// Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
// Deposit accounts have no interest if their balance is positive and less than 1000.
// Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
// Your task is to write a program to model the bank system by classes and interfaces. You should identify the classes, interfaces, 
// base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.

namespace BankSystem
{
    using System;
    using System.Linq;

    internal class TestBank
    {
        private static void Main()
        {
            Individual pesho = new Individual("Pesho Peshev");
            Company peshoLtd = new Company("Pesho LTD");

            Mortgage indMortgage = new Mortgage(1000m, 4.8, pesho);
            Mortgage compMortgage = new Mortgage(20000, 6.3, peshoLtd);

            Loan indLoan = new Loan(3500m, 3.8, pesho);
            Loan compLoan = new Loan(10200, 6.9, peshoLtd);

            Deposit indDeposit = new Deposit(900m, 3.5, pesho);
            Deposit compDeposit = new Deposit(1200m, 3.5, peshoLtd);

            Console.WriteLine(pesho);
            Console.WriteLine("\tMortgage individual interest payment: {0}", indMortgage.CalculateInterest(10));
            Console.WriteLine("\tLoan individual interest payment: {0}", indLoan.CalculateInterest(12));
            Console.WriteLine("\tDeposit individual interest payment: {0}", indDeposit.CalculateInterest(14));

            indDeposit.DepositMoney(1200m);

            Console.WriteLine("{0} deposit balance: {1}", pesho.ToString(), indDeposit.Balance);
            Console.WriteLine("\tDeposit individual interest payment: {0}", indDeposit.CalculateInterest(14));

            indDeposit.DrawMoney(2000m);

            Console.WriteLine("{0} deposit balance: {1}", pesho.ToString(), indDeposit.Balance);

            Console.WriteLine(peshoLtd);
            Console.WriteLine("\tMortgage company interest payment: {0}", compMortgage.CalculateInterest(8));
            Console.WriteLine("\tLoan company interest payment: {0}", compLoan.CalculateInterest(12));
            Console.WriteLine("\tDeposit company interest payment: {0}", compDeposit.CalculateInterest(14));
        }
    }
}