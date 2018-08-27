using System;
﻿using System.Text;
﻿using System.Collections.Generic;

namespace Section6
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReverseName();
            //BiggestNumber();
            //UniqueNumbers();
            DisplayList();
        }
    
    //  2- Write a program and ask the user to enter their name. Use an array to reverse the name and then 
    //  restore the result in a new string. Display the reversed name on the console.    
    static int ReverseName()
    {
        Console.Write("Enter your name: ");
        String name = Console.ReadLine();
        Console.Write("Good day, ");
        Console.Write(name);
        Console.WriteLine("!");
        
        char[] chars = new char[name.Length];

        for (int i = 0, j = name.Length - 1; i <= j; i++, j--)
        {
            chars[i] = name[j];
            chars[j] = name[i];
        }

        Console.WriteLine(chars);
        return 0;
    }
    

    
    //  3- Write a program and ask the user to enter 5 numbers. If a number has been previously entered, 
    //  display an error message and ask the user to re-try. Once the user successfully enters 5 unique 
    //  numbers, sort them and display the result on the console.
    
    static int BiggestNumber()
    {
        string MyNumber = "0";
        int Biggest = 0;
        while(MyNumber != "")
        {   
            Console.Write("Enter a number: ");
            MyNumber = Console.ReadLine();
            
            if(MyNumber != "")
            {
                if(Int32.Parse(MyNumber) > Biggest)
                {
                    Biggest = Int32.Parse(MyNumber);
                }
            }
        }
        Console.WriteLine(String.Format("The biggest number is {0}", Biggest));
        return 0;

    }

    //  4- Write a program and ask the user to continuously enter a number or type "quit" to exit. The list 
    //  of numbers may include duplicates. Display the unique numbers that the user has entered.
    static int UniqueNumbers()
    {
        List<string> MyNumbers = new List<string>();
        
        string MyNumber = "0";
        while(MyNumber != "quit")
        {   Console.Write("Enter a number: ");  
            MyNumber = Console.ReadLine();
            
            if((MyNumber != "") && !(MyNumbers.Contains(MyNumber)) && (MyNumber != "quit"))
            {
                Console.WriteLine("I did not find it so ima add it");
                MyNumbers.Add(MyNumber);
            }    
        }   
        MyNumbers.Sort();
        foreach (var num in MyNumbers) {
            Console.Write("{0} ", num);
        }
        Console.WriteLine();   
        return 0;
    }

    static int DisplayList()
    {
        Console.Write("Enter a list of numbers: ");
        String names = Console.ReadLine();
        
        string[] values = names.Split(',');
        Array.Sort(values);
        
        
        if(values.Length >= 5)
        {
            Console.Write("You did it!  ");
        }    
        else
        {
            Console.WriteLine("Try Again!");
            DisplayList();
        }
        
        for (int i = 0, j = 0; i < values.Length - 1 || j < 2; i++)
        {
 
            if (i > 0 && values[i] == values[i-1])
            {
                // if it's in the list skip it
                i++;
            }
            else if(values[i] == values[i+1])
            {
                // print it but then advance
                Console.Write(values[i] + " ");
                i++;
                j++;
            }
            else
            {
                Console.Write(values[i] + " ");
                j++;
            }
        }
        Console.WriteLine();
        
        //  5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
        //  If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; 
        // otherwise, display the 3 smallest numbers in the list.
        return 0;
    }

    }
}
