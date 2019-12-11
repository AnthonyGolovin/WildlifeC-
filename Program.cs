using System;
using System.Threading;
using System.Collections.Generic;

using Wildpark.Animals;

namespace Wildpark.Animals {

  public class Program
  {
    public static void Main()
    {
    List<Animal> AnimalList = new List<Animal>();
    AddAnimal(AnimalList);
    }
  
    static void AddAnimal(List<Animal> AnimalList)
    {
      Console.WriteLine("Would you like to add an animal? [y or n]");
      string checkAdd = Console.ReadLine();
        if (checkAdd.ToLower() == "y")
          {
            Console.WriteLine("Enter an animal for your logbook: ");
            Console.WriteLine("Enter the animal species");
            string inputSpecies = Console.ReadLine();
            Console.WriteLine("Enter the animals diet type. [Carnivore, Omnivore, Vegetarian, Vegan]");
            string inputDietType = Console.ReadLine();
            Console.WriteLine("Enter the animals class. [Mammal, Reptile, Marsupial, Bird, Monotreme]");
            string inputAnimalClass = Console.ReadLine();
            Animal newAnimal = new Animal(inputSpecies, inputDietType, inputAnimalClass); 

            Console.WriteLine("----------------------");
            Console.WriteLine(newAnimal.GetSpecies());
            Console.WriteLine("Is a " + newAnimal.GetDietType());
            Console.WriteLine("Is of the Class " + newAnimal.GetAnimalClass());

            AnimalList.Add(newAnimal);
          }
      else if (checkAdd.ToLower() == "n")
          {
            OptionBranch(AnimalList);
          }
      else
          {
            Console.WriteLine("I don't think you understood");
          }
           AddAnimal(AnimalList);
          }
      static void OptionBranch(List<Animal> AnimalList)
        {
        for (int i = 0; i < AnimalList.Count; i++)
          {
            Console.WriteLine(i + ": " + AnimalList[i].GetAnimal());
          }
      
            Console.WriteLine("Would you like to edit an animal? (y/n)");
            string answer = Console.ReadLine();
        if (answer.ToLower() == "y")
          {
            Console.WriteLine("Enter number for the animal you want to change:");

            string id = Console.ReadLine();
            int intId = int.Parse(id);
            Console.WriteLine("Enter Revised Animal name:");
            Console.WriteLine("Enter the revised animal species");
            string inputSpecies = Console.ReadLine();
            AnimalList[intId].SetSpecies(inputSpecies);

            Console.WriteLine("Enter the animals diet type. [Carnivore, Omnivore, Vegetarian, Vegan]");
            string inputDietType = Console.ReadLine();
            AnimalList[intId].SetDietType(inputDietType);

            Console.WriteLine("Enter the animals class. [Mammal, Reptile, Marsupial, Bird, Monotreme]");
            string inputAnimalClass = Console.ReadLine();
            AnimalList[intId].SetAnimalClass(inputAnimalClass);

            Console.WriteLine("Revised Animal is: " + AnimalList[intId].GetAnimal());
            AddAnimal(AnimalList);
          }
        else if (answer.ToLower() == "n")
          {
            Console.WriteLine("GoodBye :)");
            Thread.Sleep(1000);
            return;
          }
        
        }   
  }
}