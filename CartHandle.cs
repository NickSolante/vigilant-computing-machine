using System;
using SplashKitSDK;
using System.Collections.Generic;

public class CartHandle
{
    private static List<Sliced> _Sliced = new List<Sliced>();
    private static List<Yoghurt> _Yoghurt = new List<Yoghurt>();
    private static List<ToiletRolls> _ToiletRolls = new List<ToiletRolls>();

    float total_TR, TR_pack9, TR_pack5, TR_pack3 = 0;
    float total_Y, Y_pack15, Y_pack10, Y_pack4 = 0;
    float total_SH, SH_pack5, SH_pack3 = 0;

    decimal costY, costTR, costSH, total = 0;
    public void AddSliced(Sliced GroceryToBeAdded)
    {
        _Sliced.Add(GroceryToBeAdded);
    }
    //check for packages that are the same *possible future upgrade
    // public Sliced getPackageSli(string package)
    // {
    //     Sliced toCart;
    //     foreach (Sliced item in _Sliced)
    //     {
    //         if (package == item._pack)
    //         {
    //             return toCart = item;
    //         }
    //     }
    //     return null;
    // }
    public void AddYo(Yoghurt GroceryToBeAdded)
    {
        _Yoghurt.Add(GroceryToBeAdded);
    }

    public void AddTo(ToiletRolls GroceryToBeAdded)
    {
        _ToiletRolls.Add(GroceryToBeAdded);
    }

    public void PrintS()
    {
        foreach (var item in _Sliced)
        {

            Console.WriteLine("Pack: " + item._pack);
            Console.WriteLine("Number of Items: " + item._number);
        }
    }
    public void PrintY()
    {
        foreach (var item in _Yoghurt)
        {
            Console.WriteLine("Pack: " + item._pack);
            Console.WriteLine("Number of Items: " + item._number);
        }
    }

    public void PrintTR()
    {
        foreach (var item in _ToiletRolls)
        {
            Console.WriteLine("Pack: " + item._pack);
            Console.WriteLine("Number of Items: " + item._number);
        }
    }

    public void AllPR()
    {

        foreach (var item in _ToiletRolls)
        {

            if (item._pack == "9")
            {
                TR_pack9 = TR_pack9 + item._number;
            }
            else if (item._pack == "5")
            {
                TR_pack5 += item._number;
            }
            else
            {
                TR_pack3 += item._number;
            }

        }
        foreach (var item in _Yoghurt)
        {
            if (item._pack == "15")
            {
                Y_pack15 = Y_pack15 + item._number;
            }
            else if (item._pack == "10")
            {
                Y_pack10 += item._number;
            }
            else
            {
                Y_pack4 += item._number;
            }
            Console.WriteLine("Pack: " + item._pack);
            Console.WriteLine("Number of Items: " + item._number);
        }
        foreach (var item in _Sliced)
        {
            if (item._pack == "5")
            {
                SH_pack5 += item._number;
            }
            else if (item._pack == "3")
            {
                SH_pack3 += item._number;
            }

            Console.WriteLine("Pack: " + item._pack);
            Console.WriteLine("Number of Items: " + item._number);
        }
        // Total Rolls
        Console.WriteLine("Toilet Rolls 9 pack at 7.99: " + TR_pack9 + " total is $" + TR_pack9 * 7.99);
        costTR = Convert.ToDecimal(TR_pack9 * 7.99);
        TR_pack9 = TR_pack9 * 9;
        Console.WriteLine("Toilet Rolls 5 pack at 4.45: " + TR_pack5 + " total is $" + TR_pack5 * 4.45);
        costTR = costTR + Convert.ToDecimal(TR_pack5 * 4.45);
        TR_pack5 = TR_pack5 * 5;
        Console.WriteLine("Toilet Rolls 3 pack at 2.95: " + TR_pack3 + " total is $" + TR_pack3 * 2.95);
        costTR = costTR + Convert.ToDecimal(TR_pack3 * 2.95);
        TR_pack3 = TR_pack3 * 3;
        total_TR = TR_pack9 + TR_pack5 + TR_pack3;
        Console.WriteLine("Total of items " + total_TR + " at " + costTR);

        // Total Yoghurt
        Console.WriteLine("Yoghurt 15 pack at 13.95: " + Y_pack15 + " total is $" + Y_pack15 * 13.95);
        costY = Convert.ToDecimal(Y_pack15 * 13.95);
        Y_pack15 = Y_pack15 * 15;
        Console.WriteLine("Yoghurt 10 pack at 9.95: " + Y_pack10 + " total is $" + Y_pack10 * 9.95);
        costY = costY + Convert.ToDecimal(Y_pack10 * 9.95);
        Y_pack10 = Y_pack10 * 10;
        Console.WriteLine("Yoghurt 4 pack at 4.95: " + Y_pack4 + " total is $" + Y_pack4 * 4.95);
        costY = costY + Convert.ToDecimal(Y_pack4 * 4.95);
        Y_pack4 = Y_pack4 * 4;
        total_Y = Y_pack4 + Y_pack10 + Y_pack15;
        Console.WriteLine("Total of items " + total_Y + " at " + costY);

        // Total Sliced Ham
        Console.WriteLine("Sliced Ham 4 pack at 4.49: " + SH_pack5 + " total is $" + SH_pack5 * 4.49);
        costSH = Convert.ToDecimal(SH_pack5 * 4.49);
        SH_pack5 = SH_pack5 * 5;
        Console.WriteLine("Sliced Ham 4 pack at 2.99: " + SH_pack3 + " total is $" + SH_pack3 * 2.99);
        costSH = costSH + Convert.ToDecimal(SH_pack3 * 2.99);
        SH_pack3 = SH_pack3 * 3;
        total_SH = SH_pack3 + SH_pack5;
        Console.WriteLine("Total of items " + total_SH + " at " + costSH);
        total = costSH + costTR + costY;
        Console.WriteLine("Total grocery cost: $" + total);
    }


}
