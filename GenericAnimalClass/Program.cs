using System;

namespace GenericAnimalClass
{
    class Animal<T>
    {
        private T data;

        public Animal(T data)
        {
            this.data = data;
        }

        public T GetAnimal()
        {
            return data;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            Animal<string> animalName = new Animal<string>("Lion");
            
            Animal<string> animalHabitat = new Animal<string>("Savannah");
          
            Animal<bool> endangered = new Animal<bool>(true);
            
            Animal<bool> extinct = new Animal<bool>(false);
           
            Animal<int> averageLifespan = new Animal<int>(15);

            Console.WriteLine($"Animal Name: {animalName.GetAnimal()}");
            Console.WriteLine($"Animal Habitat: {animalHabitat.GetAnimal()}");
            Console.WriteLine($"Endangered: {endangered.GetAnimal()}");
            Console.WriteLine($"Extinct: {extinct.GetAnimal()}");
            Console.WriteLine($"Average Lifespan: {averageLifespan.GetAnimal()} years");
        }
    }
}
