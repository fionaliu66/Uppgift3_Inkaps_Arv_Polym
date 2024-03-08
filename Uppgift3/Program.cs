namespace Uppgift3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonHandler personHandler = new PersonHandler();
            try
            {
                personHandler.CreatePerson(35, "F", "Liu", 162, 60);
            }catch (ArgumentException ex) { 
                Console.WriteLine(ex.Message);
            }
          
         
            

        }
    }
}
