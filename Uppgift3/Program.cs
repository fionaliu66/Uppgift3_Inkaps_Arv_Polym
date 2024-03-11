using Uppgift3.Animal;
namespace Uppgift3
{
    internal class Program
    {
        private static List<UserError> userErrors = new();
        private static List<Animal.Animal> animals = new();
        private static List<Dog> dogs = new();
        static void Main(string[] args)
        {
            //Person class test
            //***********************************************
            //PersonHandler personHandler = new PersonHandler();
            //try
            //{
            //    personHandler.CreatePerson(35, "Fiona", "Liu", 000, 00);
            //}catch (ArgumentException ex) { 
            //    Console.WriteLine(ex.Message);
            //}
            //***********************************************

            //User error test
            //***********************************************
            //userErrors.Add(new NullInputError());
            //userErrors.Add(new NumericInputError());
            //userErrors.Add(new TextInputError());
            //userErrors.Add(new PersonExistsError());
            //userErrors.Add(new PersonNotExistsError());

            //foreach (var error in userErrors)
            //{
            //    Console.WriteLine(error.UEMessage());
            //}
            //***********************************************

            //Animal list loop test
            // ***********************************************
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


            Dog dog1 = new Dog("Buddy", 12.5, 3, "Labrador");
            Dog dog2 = new Dog("Max", 8.9, 5, "German Shepherd");
            Dog dog3 = new Dog("Bella", 6.2, 2, "Golden Retriever");
            Dog dog4 = new Dog("Charlie", 9.8, 4, "Poodle");
            Dog dog5 = new Dog("Lucy", 7.5, 6, "Beagle");
            animals.Add(dog1);
            animals.Add(dog2);
            animals.Add(dog3);
            animals.Add(dog4);
            animals.Add(dog5);

            //*************************************
            foreach (var animal in animals)
            {
                //Console.WriteLine(animal.States());
                if(animal is Dog)
                {
                   Dog dogs = (Dog) animal;
                    Console.WriteLine(dogs.WeDogs());
                }
            }
            //*************************************


            //*************************************
            //foreach (var animal in animals)
            //{
            //    Console.WriteLine(animal.GetType().Name);
            //    if (animal is Wolfman castedToWolfman)
            //    {
            //        Console.WriteLine(castedToWolfman.Talk()); 
            //    }
            //    else
            //    {
            //        animal.DoSound();
            //    }
            //}
            //***********************************************


            //***********************************************
            //Dog dog1 = new Dog("Buddy", 12.5, 3, "Labrador");
            //Dog dog2 = new Dog("Max", 8.9, 5, "German Shepherd");
            //Dog dog3 = new Dog("Bella", 6.2, 2, "Golden Retriever");
            //Dog dog4 = new Dog("Charlie", 9.8, 4, "Poodle");
            //Dog dog5 = new Dog("Lucy", 7.5, 6, "Beagle");
            //Horse horse = new Horse("Hourse", 50, 5, 1.2);
            //dogs.Add(dog1); 
            //dogs.Add(dog2);
            //dogs.Add(dog3);
            //dogs.Add(dog4);
            //dogs.Add(dog5);
            //dogs.Add((Dog)horse); //Cannot Convert from Horse to Dog
            //***********************************************
        }


    }
}
