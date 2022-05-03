// See https://aka.ms/new-console-template for more information
using Day_8_LineComparison;

Console.WriteLine("----- Welcome TO Line Calculations -----\n");
Console.WriteLine("\nEnter the co-ordinates for Line 1:-\n");
FindLength obj1 = new FindLength();
double len1 = obj1.FindingLength();
Console.WriteLine("\nLength of line 1 :- "+len1);

Console.WriteLine("\nEnter the co-ordinates for Line 2:-\n");
FindLength obj2= new FindLength();
double len2 = obj2.FindingLength();
Console.WriteLine("\nLength of line 2 :- " +len2);

FindEquality obj3 = new FindEquality();
Console.Write("\nResult of Equality:- "); // console.write don't print next statement in new line 
obj3.EqualityMethod(len1, len2);


CompareLines obj4 = new CompareLines();
Console.Write("\nResult of CompareLine :- "); // console.write don't print next statement in new line 
obj4.Comparelines(len1,len2);