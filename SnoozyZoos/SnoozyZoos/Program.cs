// See https://aka.ms/new-console-template for more information
using SnoozyZoos.Models;

Console.WriteLine("Welcome to the Zookeeper's database!");

Console.WriteLine("***********************************************");

// List of zooAnimals

List<ZooAnimal> zooAnimals = new()
{
    new Kangeroo("Kanga", "brown", 3, Location.Outback),
    new Penguin("Pingu", "grey", 8, Location.BirdSafari),
    new Sloth("Slothy", "ash brown", 10, Location.AnimalAdventure),
    new Penguin("Pinga", "grey", 6, Location.BirdSafari),
    new Sloth("Slotha", "ash brown", 9, Location.AnimalAdventure),
    new Cobra("Dina", "black", 4, Location.ReptileHouse),
    new Sloth("Slothu", "ash brown", 11, Location.AnimalAdventure),
    new Tiger("Jiba", "stripy orange", 12, Location.TigerTerritory),
    new Tiger("Cuddles", "stripy orange", 4, Location.TigerTerritory),
    new Kangeroo("Amber", "brown", 2, Location.Outback),
    new Penguin("Wheezy", "grey", 7, Location.BirdSafari),
    new Penguin("Mumble", "grey", 11, Location.BirdSafari),
    new Kangeroo("Dave", "brown", 3, Location.Outback),
    new Cobra("Asmodeus", "black", 11, Location.ReptileHouse),
};

Console.WriteLine("Challenge 1");
Console.WriteLine("***********************************************");

// Challenge 1

// Given a list of ZooAnimals
// Write a query that returns a list of ZooAnimals with Age greater than 3 and less than 8.

// Expected output for names and ages:
// Pinga, 6
// Dina, 4
// Cuddles, 4
// Wheezy, 7

//var challengeOneZooAnimals = // Add your LINQ query here

//foreach (var zooAnimal in challengeOneZooAnimals)
//{
//    Console.WriteLine($"{zooAnimal.Name}, {zooAnimal.Age}");
//}

Console.WriteLine("***********************************************");










