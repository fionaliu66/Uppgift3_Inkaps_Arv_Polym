namespace Uppgift3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Person p = new Person("Fiona", "Faith");
                p.Age = -35;
            }catch (ArgumentException aex)
            {
                Console.WriteLine(aex.Message);
            }
          
         
            

        }
    }
}
