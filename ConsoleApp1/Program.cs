using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string empty = "";
            string quote = "The only bar I set low is for limbo";
            string firstName ="Cole";
            string favMovie ="The Matrix";
            bool b = favMovie.Contains("THE");
            favMovie = (favMovie.Replace("a", "@").Replace("e", "3"));
            favMovie = (favMovie.ToUpper());
            firstName = (firstName.ToUpper());
            quote = (quote.Replace("e", "").Replace("a", "").Replace("i", "").Replace("o", "").Replace("u", "").Replace("A", "").Replace("E", "").Replace("I", "").Replace("O", "").Replace("U", ""));
                
            Console.WriteLine($"Believe it or not {firstName} doesn't like to watch {favMovie}");
            Console.WriteLine(b);
            Console.WriteLine(quote);
            Console.WriteLine("-_-");
            Console.WriteLine("(.)(.)");








        }
        
       
    
    
    
    
    
    
    }







}
