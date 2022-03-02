using System;
namespace Enumerations
{
    public class BSection
    {
        enum ECE
        {
            RangaSai=461,RaviTeja,Reshma,Jayanth,Josthna,
        }
        public static void Main(string[]args)
        {
            Console.WriteLine("Roll numbers of the candidates are:");
            foreach(int i in Enum.GetValues(typeof(ECE)))
            {
                Console.WriteLine($"{Enum.GetName(typeof(ECE),i)} : "+i);
            }
            
            
        }
    }
}