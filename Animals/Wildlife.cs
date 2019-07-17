using System;

namespace Wildpark.Animals
{
  class Animal
  {
 private string _species; //Animal species (Fox, parrot, panda);
 private string _dietType; //(Carnivore, herbivore);
 private string _animalClass; //(Mammal, reptile, bird);

 public Animal(string species, string dietType, string animalClass)
 {
     _species = species;
     _dietType = dietType;
     _animalClass = animalClass;
 }
 public string GetSpecies()
 {
     return _species;
 }
 public string GetDietType()
 {
     return _dietType;
 }
 public string GetAnimalClass()
 {
     return _animalClass;
 }
 public string GetAnimal()
 {
     return _species+" :   "+_dietType+" :  "+_animalClass;
 }
  }
}