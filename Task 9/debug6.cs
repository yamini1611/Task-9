using System;
using System.Collections;
using System.Collections.Generic;

public class Dictionary
{
	static void Main(string[] args)
	{
        IDictionary<int, string> number = new Dictionary<int, string>();//IDictionary mistake<int, string>();

        number.Add(1, "One"); //adding key/value using the Add() method
        number.Add(3, "Three");//should be number

        number.Add(2, "Two");//should be number

        foreach (KeyValuePair<int, string> kvp in number)//should be number
            Console.WriteLine("Key: {0} ",kvp.Key+ "Value: "+ kvp.Value); // should be + kvp.Key +kvp.Value

        //creating a dictionary using collection-initializer syntax
        var cities = new Dictionary<int, string>()
{
            {1,"London, Manchester, Birmingham"},
            {2,"Chicago, New York, Washington"},
            {3,"Mumbai, New Delhi, Pune"}
        };

        foreach (var kvp in cities)
            Console.WriteLine(" Key:{0}" , kvp.Key + " Value: " +kvp.Value);
        Console.ReadLine();
    }
}
	


