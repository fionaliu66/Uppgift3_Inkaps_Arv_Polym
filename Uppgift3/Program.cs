namespace Uppgift3
{
    internal class Program
    {
        private static List<UserError> userErrors = new List<UserError>();
        static void Main(string[] args)
        {
            PersonHandler personHandler = new PersonHandler();
            try
            {
                personHandler.CreatePerson(35, "Fiona", "Liu", 162, 60);
            }catch (ArgumentException ex) { 
                Console.WriteLine(ex.Message);
            }

            userErrors.Add(new NullInputError());
            userErrors.Add(new NumericInputError());
            userErrors.Add(new TextInputError());
            userErrors.Add(new PersonExistsError());
            userErrors.Add(new PersonNotExistsError());

            foreach (var error in userErrors)
            {
                Console.WriteLine(error.UEMessage());
            }



        }
    }
}
