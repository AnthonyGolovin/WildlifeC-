using System;
using System.Collections.Generic;
using Wildpark.Animals;

namespace Wildpark.Animals {

  public class Program
  {
    public static void Main()
    {
    

      Console.WriteLine("Enter an animal for yout logbook: ");
      Console.WriteLine("Enter the animal species");
      string inputSpecies = Console.ReadLine();
      Console.WriteLine("Enter the animals diet type");
      string inputDietType = Console.ReadLine();
      Console.WriteLine("Enter the animals class");
      string inputAnimalClass = Console.ReadLine();
      Animal newAnimal = new Animal(inputSpecies, inputDietType, inputAnimalClass); 

        Console.WriteLine("----------------------");
        Console.WriteLine(newAnimal.GetSpecies());
        Console.WriteLine("Is a " + newAnimal.GetDietType());
        Console.WriteLine("Is of the Class " + newAnimal.GetAnimalClass());
        //Console.WriteLine(Car.MakeSound("Bang"));
      List<Animal> Animals = new List<Animal>() {};  
  }
  }
}