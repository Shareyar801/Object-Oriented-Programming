using System;
namespace ConsoleApp1
{
    class Account
    {
        string Name;
        string acc_no;
        protected double acc_balance;
        protected double deposite, withdraw;
        protected int flag = 0;

        public Account()
        {
            Name = "shari";
            acc_no = "458BA";
            acc_balance = 4999.99;
        }
        public void Display_Details()
        {
            Console.WriteLine("\n=====DISPLAYING DETAILS=====");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Account Number: " + acc_no);
        }
        public double Deposite_Amount()
        {
            Console.WriteLine("\n=====DEPOSITE=====");
            Console.Write("Enter amount to deposite: ");
            deposite = Convert.ToDouble(Console.ReadLine());
            acc_balance += deposite;
            Console.WriteLine("Your new balance is {0}", acc_balance);
            return deposite;
        }
        public double Withdraw_Amount()
        {
            Console.WriteLine("\n=====WITHDRAW=====");
            Console.Write("Enter amount of withdraw: ");
            withdraw = Convert.ToDouble(Console.ReadLine());
            if (withdraw <= acc_balance)
            {
                acc_balance -= withdraw;
                Console.WriteLine("Your new balance is {0}", acc_balance);
                flag = 01;
                return acc_balance;
            }
            else
            {
                Console.WriteLine("ERROR 420:Debit amount exceeded account balance.");
                Console.WriteLine("Your account balance is " + acc_balance + ".");
                flag = 0;
                return 0;
            }
        }
        public void Get_Balance()
        {
            Console.WriteLine("\n=====DISPLAYING BALANCE=====");
            Console.Write("Your current balance is " + acc_balance + ".");
        }
}
class SavingsAccount : Account
{
    double interest_rate = 0.07; //interest rate of 7%
    public double calculateInterest()
    {
        double inter_amount;
        inter_amount = interest_rate * acc_balance;
        Console.WriteLine("\n\n=====DISPLAYING INTEREST AMOUNT=====");
        Console.WriteLine("\nNOTE:Current interest rate is 7%.");
        Console.WriteLine("New balance will be " + (inter_amount + acc_balance) + ".");
        return inter_amount;
    }
}

class CheckingAccount : Account
{
    double trans_fee;
    public void credit_trans_fee_cal()
    {
        trans_fee = 15;
        acc_balance = acc_balance + Deposite_Amount() - trans_fee;
        Console.WriteLine("After subtracting transaction amount of " + trans_fee + " your new balance will be {0}.", acc_balance);
    }
    public void debit_trans_fee_cal()
    {
        Withdraw_Amount();
        trans_fee = 15;
        if (flag == 01)
        {
            acc_balance = acc_balance - trans_fee;
            Console.WriteLine("After subtracting transaction amount of " + trans_fee + " your balance will be {0}.",acc_balance);
        }
        else if (flag == 0)
        {
            Console.WriteLine("No transaction amount will be charged! ");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        char loop_choice2, loop_choice, loop_choice3;
        int switch_choice;
        Console.WriteLine("==============================================");
        Console.WriteLine("======WELCOME TO SHARE'S BANK PVT LIMITED=====");
        Console.WriteLine("==============================================");
        Console.WriteLine("Press 01 to open current account.");
        Console.WriteLine("Press 02 to open Checking account.");
        Console.Write("Enter your choice: ");
        switch_choice = Convert.ToInt32(Console.ReadLine());
        switch (switch_choice)
        {
            case 01:
                {
                    SavingsAccount s_acc01 = new SavingsAccount();
                    Console.WriteLine("\n\n----------CURRENT ACCOUNT----------");
                    Console.WriteLine("\nPress 101 to Display Account Details.");
                    Console.WriteLine("Press 102 to Deposite Amount.");
                    Console.WriteLine("Press 103 to Withdraw Amount.");
                    Console.WriteLine("Press 104 to Display Balance.");
                    Console.WriteLine("Press 105 to Display Interest Amount.");
                    do
                    {
                        Console.Write("\n\n=>Enter your choice: ");
                        int switch_choice2 = Convert.ToInt32(Console.ReadLine());
                        switch (switch_choice2)
                        {
                            case 101:
                                {
                                    s_acc01.Display_Details();
                                    break;
                                }
                            case 102:
                                {
                                    s_acc01.Deposite_Amount();
                                    break;
                                }
                            case 103:
                                {
                                    s_acc01.Withdraw_Amount();
                                    break;
                                }
                            case 104:
                                {
                                    s_acc01.Get_Balance();
                                    break;
                                }
                            case 105:
                                {
                                    Console.WriteLine("The earned interest amount is " +
                                    s_acc01.calculateInterest() + ".");
                                    break;
                                }
                            default:
                                Console.WriteLine("The entered detail is invalid!!");
                                break;
                        }
                        Console.Write("\n=>Want to exit? Press y or Y: ");
                        loop_choice2 = Convert.ToChar(Console.ReadLine());
                    } while ((loop_choice2 == 'Y') || (loop_choice2 == 'y'));
                    break;
                }
            case 02:
                {
                    CheckingAccount c_acc01 = new CheckingAccount();
                    Console.WriteLine("\n\n----------CHECKING ACCOUNT----------");
                    Console.WriteLine("\nPress 201 to Display Account Details.");
                    Console.WriteLine("Press 202 to Deposite Amount with Transaction Fee.");
                    Console.WriteLine("Press 203 to Withdraw Amount with Transaction Fee.");
                    Console.WriteLine("Press 204 to Display Balance.");
                    do
                    {
                        Console.Write("Enter your choice: ");
                        int switch_choice3 = Convert.ToInt32(Console.ReadLine());
                        switch (switch_choice3)
                        {
                            case 201:
                                {
                                    c_acc01.Display_Details();
                                    break;
                                }
                            case 202:
                                {
                                    c_acc01.credit_trans_fee_cal();
                                    break;
                                }
                            case 203:
                                {
                                    c_acc01.debit_trans_fee_cal();
                                    break;
                                }
                            case 204:
                                {
                                    c_acc01.Get_Balance();
                                    break;
                                }
                            default:
                                Console.WriteLine("The entered detail is invalid!!");
                                break;
                        }
                        Console.Write("\n=>Want to exit? Press y or Y: ");
                        loop_choice3 = Convert.ToChar(Console.ReadLine());
                    } while ((loop_choice3 == 'Y') || (loop_choice3 == 'y'));
                    break;
                }
            default:
                {
                    Console.WriteLine("ERROR 420: INVALID CHOICE!!! TRY AGAIN!!!");
                    break;
                }
        }
    }
}
}
