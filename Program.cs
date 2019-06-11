using System;
using SplashKitSDK;
using System.Collections.Generic;

public enum MethodOption
{
    Sliced_Ham, Yoghurt, ToiletRoll, Print, Quit
}

public class Program
{
    public static void DoSliced(CartHandle accounted)
    {
        int amount;
        int quotient = 0;
        int remainder = 0;
        int handle = 0;
        Console.WriteLine("Please enter number of Sliced Ham to be purchased: ");
        amount = Convert.ToInt32(Console.ReadLine());
        int amountDouble = amount;
        handle = quotient = Math.DivRem(amount, 5, out remainder);
        Sliced newCart = new Sliced(handle, "5");
        if (quotient > 0)
        {
            accounted.AddSliced(newCart);
        }
        if (remainder > 0)
        {
            handle = remainder = Math.DivRem(remainder, 3, out amountDouble);
            newCart = new Sliced(handle, "3");
            Console.WriteLine("this is the remainder " + amountDouble);

            accounted.AddSliced(newCart);
            if (amountDouble > 0)
            {
                Console.WriteLine("Please enter a valid Pack");
            }

        }
        accounted.PrintS();


    }

    public static void DoYoghurt(CartHandle accounted)
    {
        int amount;
        int quotient = 0;
        int quotient2 = 0;
        int quotient3 = 0;
        int quotient4 = 0;
        int quotient5 = 0;
        int remainder = 0;
        int remainder2 = 0;
        int handle = 0;
        Console.WriteLine("Please enter number of Yoghurt to be purchased: ");
        amount = Convert.ToInt32(Console.ReadLine());
        int amountDouble = amount;
        handle = quotient = Math.DivRem(amount, 15, out remainder);
        Yoghurt newCart = new Yoghurt(handle, "15");
        Yoghurt newCart2 = new Yoghurt(quotient2, "10");
        Yoghurt newCart3 = new Yoghurt(quotient3, "4");
        Yoghurt newCart4 = new Yoghurt(quotient4, "10");
        Yoghurt newCart5 = new Yoghurt(quotient5, "4");
        //first loop in if 15 is applicable
        if (remainder > 0)
        {
            handle = quotient2 = Math.DivRem(remainder, 10, out amountDouble);
            newCart2 = new Yoghurt(handle, "10");

            if (amountDouble == 0)
            {
                accounted.AddYo(newCart);
                accounted.AddYo(newCart2);
            }
            else if (amountDouble > 0)
            {
                handle = quotient3 = Math.DivRem(amountDouble, 4, out remainder);
                newCart3 = new Yoghurt(quotient3, "4");

                //sustain and wait 
                if (remainder == 0)
                {
                    accounted.AddYo(newCart);
                    accounted.AddYo(newCart2);
                    accounted.AddYo(newCart3);
                }
                else if (remainder > 0) // see if you start with 10
                {
                    handle = quotient4 = Math.DivRem(amount, 10, out remainder2);
                    newCart4 = new Yoghurt(handle, "10");

                    if (remainder2 > 0)
                    { // see if you can get no remainder with this
                        handle = quotient5 = Math.DivRem(remainder2, 4, out amountDouble);
                        newCart5 = new Yoghurt(handle, "4");

                        if (amountDouble == 0)
                        {
                            accounted.AddYo(newCart4);
                            accounted.AddYo(newCart5);
                        }
                        else if (amountDouble > 0)
                        {
                            Console.WriteLine("please enter a valid Pack");
                        }


                    }
                }

            }

            else
            {
                Console.WriteLine("Please enter valid packs");
            }
        }
        else if (remainder == 0)
        {
            accounted.AddYo(newCart);
        }




        accounted.PrintY();


    }

    public static void DoToilet(CartHandle accounted)
    {
        int amount;
        int quotient = 0;
        int quotient2 = 0;
        int quotient3 = 0;
        int quotient4 = 0;
        int quotient5 = 0;
        int remainder = 0;
        int remainder2 = 0;
        int handle = 0;
        Console.WriteLine("Please enter number of Toilet Rolls to be purchased: ");
        amount = Convert.ToInt32(Console.ReadLine());
        int amountDouble = amount;
        handle = quotient = Math.DivRem(amount, 9, out remainder);
        ToiletRolls newCart = new ToiletRolls(handle, "9");
        ToiletRolls newCart2 = new ToiletRolls(quotient2, "5");
        ToiletRolls newCart3 = new ToiletRolls(quotient3, "3");
        ToiletRolls newCart4 = new ToiletRolls(quotient4, "5");
        ToiletRolls newCart5 = new ToiletRolls(quotient5, "3");
        //first loop in if 15 is applicable
        if (remainder > 0)
        {
            handle = quotient2 = Math.DivRem(remainder, 5, out amountDouble);
            newCart2 = new ToiletRolls(handle, "5");

            if (amountDouble == 0)
            {
                accounted.AddTo(newCart);
                accounted.AddTo(newCart2);
            }
            else if (amountDouble > 0)
            {
                handle = quotient3 = Math.DivRem(amountDouble, 3, out remainder);
                newCart3 = new ToiletRolls(quotient3, "3");

                //sustain and wait 
                if (remainder == 0)
                {
                    accounted.AddTo(newCart);
                    accounted.AddTo(newCart2);
                    accounted.AddTo(newCart3);
                }
                else if (remainder > 0) // see if you start with 10
                {
                    handle = quotient4 = Math.DivRem(amount, 5, out remainder2);
                    newCart4 = new ToiletRolls(handle, "5");

                    if (remainder2 > 0)
                    { // see if you can get no remainder with this
                        handle = quotient5 = Math.DivRem(remainder2, 3, out amountDouble);
                        newCart5 = new ToiletRolls(handle, "3");

                        if (amountDouble == 0)
                        {
                            accounted.AddTo(newCart4);
                            accounted.AddTo(newCart5);
                        }
                        else if (amountDouble > 0)
                        {
                            Console.WriteLine("please enter a valid Pack");
                        }


                    }
                }

            }

            else
            {
                Console.WriteLine("Please enter valid packs");
            }
        }
        else if (remainder == 0)
        {
            accounted.AddTo(newCart);
        }



        accounted.PrintTR();


    }



    public static void DoPrint(CartHandle accounted)
    {


        accounted.AllPR();

    }

    public static MethodOption ReadOption()
    {
        int option;
        string options;

        do
        {
            Console.WriteLine("Choose between the options of either 1 Sliced Ham, 2 Yoghurt, 3 Toilet Roll,4 Print and 5 Quit");
            options = Console.ReadLine();
            option = Convert.ToInt32(options);

        } while (option < 1 && option > 4);

        return (MethodOption)(option - 1);
    }
    public static void Main()
    //Main is here

    {
        CartHandle myAccount = new CartHandle();
        Console.WriteLine("Sliced ham at 3 @ $2.99 and 5 @ 4.99");
        Console.WriteLine("Yoghurt at 4 @ $4.95, 10 @ 9.95 and 15 @ $13.95");
        Console.WriteLine("Toilet Rolls at 3 @ $2.95 and 5 @ 4.45 and 9 @ $7.99");

        MethodOption ClientSelection;

        do
        {
            ClientSelection = ReadOption();

            Console.WriteLine("The client chose to " + ClientSelection);
            switch (ClientSelection)
            {
                case MethodOption.Sliced_Ham:
                    DoSliced(myAccount);
                    break;
                case MethodOption.Yoghurt:
                    DoYoghurt(myAccount);
                    break;
                case MethodOption.ToiletRoll:
                    DoToilet(myAccount);
                    break;
                case MethodOption.Print:
                    DoPrint(myAccount);
                    break;
                case MethodOption.Quit:
                    Console.WriteLine("Quitting time");
                    break;
            }
        }
        while (ClientSelection != MethodOption.Quit);



    }
}
