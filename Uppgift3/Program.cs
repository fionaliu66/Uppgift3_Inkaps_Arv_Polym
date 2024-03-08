using Uppgift3.Animal;
namespace Uppgift3
{
    internal class Program
    {
        private static List<UserError> userErrors = new();
        private static List<Animal.Animal> animals = new();
        static void Main(string[] args)
        {
            //PersonHandler personHandler = new PersonHandler();
            //try
            //{
            //    personHandler.CreatePerson(35, "Fiona", "Liu", 000, 00);
            //}catch (ArgumentException ex) { 
            //    Console.WriteLine(ex.Message);
            //}

            //userErrors.Add(new NullInputError());
            //userErrors.Add(new NumericInputError());
            //userErrors.Add(new TextInputError());
            //userErrors.Add(new PersonExistsError());
            //userErrors.Add(new PersonNotExistsError());

            //foreach (var error in userErrors)
            //{
            //    Console.WriteLine(error.UEMessage());
            //}

            Bird bird = new Bird("Bird", 0.8, 1, true);
            Dog dog = new Dog("Dog", 13, 2, "Tax");
            Flamingo flamingo = new Flamingo("Flamingo", 13, 2, true, 13);
            Hedgehog hedgehog = new Hedgehog("Hedgehog", 0.5, 1, 100);
            Horse horse = new Horse("Hourse", 50, 5, 1.2);
            Pelican pelican = new Pelican("Pelican", 10, 3, true, 10);
            Swan swan = new Swan("Swan", 3, 2, true, 20);
            Wolf wolf = new Wolf("Wolf", 35, 3, 13);
            Wolfman wolfman = new Wolfman("Daniel", 80, 120, 8, 190);
            Worm worm = new Worm("Worm", 0.1, 3, true);

            animals.Add(bird);
            animals.Add(dog);
            animals.Add(flamingo);
            animals.Add(hedgehog);
            animals.Add(horse);
            animals.Add(pelican);
            animals.Add(swan);
            animals.Add(wolf);
            animals.Add(wolfman);
            animals.Add(worm);

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.GetType().Name);
                if (animal is Wolfman castedToWolfman)
                {
                    Console.WriteLine(castedToWolfman.Talk()); 
                }
                else
                {
                    animal.DoSound();
                }


            }


        }


    }
}
