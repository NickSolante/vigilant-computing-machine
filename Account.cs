using System;
using SplashKitSDK;
using System.Collections.Generic;

public class Account
{
    private int _cart;
    private string _name;
    public static List<int> list = new List<int>();

    public int ifFive(int check)
    {
        int doubleRem = check;
        if (doubleRem % 5 == 0)
        {
            return 0;
        }
        return 1;

    }
    public int ifThree(int check)
    {
        int doubleRem = check;

        if (doubleRem % 3 < 1)
        {
            return 0;
        }
        return 1;

    }

    public Account(string name, int startingBalance)
    {
        _name = name;
        _cart = startingBalance;

    }
    public bool Deposit(int amountToAdd)
    {
        if (amountToAdd > 0)
        {
            _cart = _cart + amountToAdd;

            return true;
        }
        return false;


    }
    public int SlicedHam(int amountToPurchase)
    {

        int tempCart = amountToPurchase;
        int quotient = 0;
        int remainder = 0;

        if (tempCart % 5 == remainder)
        {
            quotient = Math.DivRem(amountToPurchase, 5, out remainder); //checks how many times it has looped through given item
            return quotient;
        }

        else if (tempCart % 3 == 0)
        {
            quotient = Math.DivRem(amountToPurchase, 3, out amountToPurchase); //checks how many times it has looped through given item
            return quotient;
        }
        return quotient;





    }
    public string Name
    {
        get { return _name; }
    }

    public void Print()

    {
        Console.WriteLine(" Balance is: " + _cart);
    }


}