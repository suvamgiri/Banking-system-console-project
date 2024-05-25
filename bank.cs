using System;
using System.Collections.Generic;
public class bankdata
{
    public string username { get; set; }
    public string password { get; set; }
    public int pin { get; set; }

    public bankdata(string username, string password, int pin)
    {
        this.username = username;
        this.password = password;
        this.pin = pin;

    }

}
class Program
{

    static void Main(string[] args)
    {
        List<bankdata> bankdata = new List<bankdata>(){
      new bankdata("James","1234",1234),
    };
    top:
        Console.WriteLine("Choose 1 to signp and 2 to login");

        int anwser = Convert.ToInt32(Console.ReadLine());
    
        if (anwser >=1  && anwser <= 2){
            if (anwser == 1)
            {
                Console.Write("Enter you name : ");
                string username = Console.ReadLine();
                Console.Write("Enter you password : ");
                string password = Console.ReadLine();
                Console.Write("Enter you pin : ");
                int pin = Convert.ToInt32(Console.ReadLine());
                bankdata.Add(new bankdata(username, password, pin));


                goto top;
            }

            else
            {

                Console.WriteLine("welcome to our onlinebank system");
                Console.Write("Enter you name : ");
                string username = Console.ReadLine();
                bankdata bankdata1 = bankdata.Find(x => x.username == username);
                if (bankdata1 != null)
                {
                    Console.Write("Enter you pincode : ");
                    int pin = Convert.ToInt32(Console.ReadLine());
                    if (pin == bankdata1.pin)
                    {
                        while (true)
                        {
                            Console.WriteLine("welcome !" + bankdata1.username);
                            Console.WriteLine("choose the option : ");
                            Console.WriteLine("1.withdraw");
                            Console.WriteLine("2.deposit");
                            Console.WriteLine("3.check balance");
                            Console.WriteLine("4.exit");
                            Console.Write("chose the option : ");
                            int option = Convert.ToInt32(Console.ReadLine());
                            switch (option)
                            {
                                case 1:
                                    withdraw();
                                    break;
                                case 2:
                                    deposit();
                                    break;

                                case 3:
                                    check_balance();
                                    break;

                                case 4:
                                    exit();
                                    break;


                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("wrong username");
                }
            }

        }else{
          Console.WriteLine("wrong input");
        }
    }

    static void withdraw()
    {
        Console.Write("Enter the amount you want to withdraw : ");
        int withdraw = Convert.ToInt32(Console.ReadLine());
        int balance = 10000;
        int amount = balance - withdraw;
        Console.WriteLine("your pervious amount : " + balance);
        Console.WriteLine("your current amount : " + amount);

    }
    static void deposit()
    {
        Console.Write("Enter the amount you want to deposit : ");
        int deposit = Convert.ToInt32(Console.ReadLine());
        int balance = 10000;
        int amount = balance + deposit;
        Console.WriteLine("your pervious amount : " + balance + "$");
        Console.WriteLine("your current amount : " + amount + "$");
    }
    static void check_balance()
    {
        int blance = 10000;
        Console.WriteLine("your current balance : " + blance + "$");
    }
    static void exit()
    {
        bool exit = true;
    }
}
