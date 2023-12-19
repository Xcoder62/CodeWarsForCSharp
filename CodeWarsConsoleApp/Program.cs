using CodeWarsConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;


//Console.WriteLine("Running Get Grade");
//var result = Kata.GetGrade(90, 90, 90);
//Console.WriteLine(result);

//Console.WriteLine("RPS");
//Console.WriteLine(Kata.Rps("rock", "rock"));
//Console.WriteLine(Kata.Rps("rock", "scissors"));
//Console.WriteLine(Kata.Rps("paper", "scissors"));

//Console.WriteLine("string to array");
//foreach (var item in Kata.StringToArray("Porter Robinson")) 
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("Needle in hay stack");
//object[] randList = new object[] { "ABC", "EDF", "needle", "813", 41};
//Console.WriteLine(Kata.FindNeedle(randList));

//Console.WriteLine("Love is real");
//Console.WriteLine(Kata.lovefunc(1, 4));
//Console.WriteLine(Kata.lovefunc(2, 4));
//Console.WriteLine(Kata.lovefunc(11,13));

//Console.WriteLine("SumArray");
//Console.WriteLine(Kata.SumArray(new double[] {9, -4 }));
//Console.WriteLine(Kata.SumArray(new double[] {  }));
//Console.WriteLine(Kata.SumArray(new double[] { 999 }));

//Console.WriteLine("Min Max");
//Console.WriteLine(Kata.kataMin(new int[] { -52, 56, 30, 29, -54, 0, -110 }));
//Console.WriteLine(Kata.kataMax(new int[] { 5 }));
//Console.WriteLine(Kata.kataMax(new int[] {11, 51, 4}));

//Console.WriteLine("Area or Perimeter");
//Console.WriteLine(Kata.AreaOrPerimeter(4,4));
//Console.WriteLine(Kata.AreaOrPerimeter(10, 6));

//Console.WriteLine("Disemvowel");
//Console.WriteLine(Kata.Disemvowel("This website is for losers LOL!"));


//Console.WriteLine("People in bus");
//List<int[]> peopleList1 = new List<int[]>() { new[] { 10, 0 }, new[] { 3, 5 }, new[] { 5, 8 } };
//Console.WriteLine(Kata.NumberOfPeopleLeftOnBus(peopleList1));

//Console.WriteLine("Invert Values");
//int[] input = new int[] { 1, -2, 3 };
//var result1 = Kata.InvertValues(input);
//Console.WriteLine(result1[0]);
//Console.WriteLine(result1[1]);
//Console.WriteLine(result1[2]);

//Console.WriteLine("Remove smol from list");
//var input3 = new List<int> { 1, 2, 3, 4, 5 };
//var result3 = Kata.RemoveSmallest(input3);
//foreach (var item in result3)
//{
//    Console.Write(item + ", ");
//}

//Console.WriteLine("Rental Car");
//Console.WriteLine(Kata.RentalCarCost(7));
//Console.WriteLine(Kata.RentalCarCost(1));
//Console.WriteLine(Kata.RentalCarCost(4));

//Console.WriteLine("BMI");
//Console.WriteLine(Kata.Bmi(100,25));
//Console.WriteLine(Kata.Bmi(80,1.80));

//Console.WriteLine("feast of the beast");
//Console.WriteLine(Kata.Feast("great blue heron", "garlic Naan"));
//Console.WriteLine(Kata.Feast("Bear", "Bear-Claw"));

//Console.WriteLine("Descending Order");
//Console.WriteLine(Kata.DescendingOrder(205158));

Console.WriteLine("ones and zeros");
Console.WriteLine(Kata.binaryArrayToNumber(new int[] { 1, 0, 0, 1 }));
Console.WriteLine(Kata.binaryArrayToNumber(new int[] { 1, 1, 1, 1 }));

Console.WriteLine("Reversed Words");
Console.WriteLine(Kata.ReverseWords("This Is an Example!"));

Console.WriteLine("population attack");
Console.WriteLine(Kata.NbYear(1000,2,50,1200));
Console.WriteLine(Kata.NbYear(1500000, 0.25, 1000, 2000000));
Console.WriteLine(Kata.NbYear(1000, 2.0, 50, 1214));

Console.WriteLine("Tip");
//Console.WriteLine(Kata.tipCalculator(20,16));
var reciept = Kata.tipCalculator(13, 28);
Console.WriteLine($"Tip: {reciept[0]}, Total Amt: {reciept[1]}");


Console.WriteLine("NSeries, cuz math");
Console.WriteLine(Kata.seriesSum(0));

Console.WriteLine(Kata.seriesSum(2));
Console.WriteLine(Kata.seriesSum(5));
Console.WriteLine(Kata.seriesSum(9));
Console.WriteLine(Kata.seriesSum(67));
Console.WriteLine(Kata.seriesSum(100));
Console.WriteLine(Kata.Stray(new int[] {3,4,4,4,4,4,4} ));
Console.WriteLine(Kata.Stray(new int[] { 17, 17, 3, 17, 17, 17, 17 }));
Console.WriteLine(Kata.Grow(new int[] {1,2,3,4} ));
Console.WriteLine(Kata.Grow(new int[] { 4, 1, 1, 1, 4 }));

Console.WriteLine(Kata.GetVowelCount("abracadabra"));
Console.WriteLine(Kata.OtherAngle(30,30));
Console.WriteLine(Kata.OtherAngle(60, 30));
Console.WriteLine("Century");
Console.WriteLine(Kata.CenturyFromYear(84));
Console.WriteLine(Kata.CenturyFromYear(1701));
Console.WriteLine(Kata.CenturyFromYear(1900));

Console.WriteLine(Kata.GetMiddle("cat"));
Console.WriteLine(Kata.GetMiddle("test"));

Console.WriteLine(Kata.Accum("aBcdE"));

Console.WriteLine(Kata.CountBy(2,6));
Console.WriteLine(Kata.IsIsogram("isogram"));
Console.WriteLine(Kata.IsIsogram("moose"));

Console.WriteLine(Kata.ToJadenCase("This is a Test"));

foreach (var item in Kata.OpenOrSenior(new[] { new[] { 18, 20 }, new[] { 61, 12 } } )) {
    Console.WriteLine(item);

}
