// See https://aka.ms/new-console-template for more information
using SnoozyZoos.Models;

Console.WriteLine("Welcome to the Zookeeper's Zoo Analysis 🦁!");

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

/* Challenge 1
Given a list of ZooAnimals
Write a query that returns a list of ZooAnimals with Age greater than 3 and less than 8.

Expected output for names and ages:
Pinga, 6
Dina, 4
Cuddles, 4
Wheezy, 7
*/


var challengeOneZooAnimals = zooAnimals.Where(animal => animal.Age > 3).Where(animal => animal.Age < 8);

foreach (var zooAnimal in challengeOneZooAnimals)
{
    Console.WriteLine($"{zooAnimal.Name}, {zooAnimal.Age}");
}


Console.WriteLine("***********************************************");

Console.WriteLine("Challenge 2");
Console.WriteLine("***********************************************");

/* Challenge 2

Given a list of ZooAnimals
Write a query that returns a list of ZooAnimals where the name is at least 6 characters long.
Finally, make the names uppercase.

Expected output:
SLOTHY
SLOTHA
SLOTHU
CUDDLES
WHEEZY
MUMBLE
ASMODEUS
*/


var challengeTwoZooAnimals = zooAnimals.Where(animal => animal.Name.Length >= 6);

foreach (var zooAnimal in challengeTwoZooAnimals)
{
    Console.WriteLine($"{zooAnimal}");
}


Console.WriteLine("***********************************************");

Console.WriteLine("Challenge 3");
Console.WriteLine("***********************************************");

/* Challenge 3

Given a list of ZooAnimals
Write a query that returns a list of ZooAnimals ordered by oldest to youngest

Expected output:
Jiba, 12
Slothu, 11
Mumble, 11
Asmodeus, 11
Slothy, 10
Slotha, 9
Pingu, 8
Wheezy, 7
Pinga, 6
Dina, 4
Cuddles, 4
Kanga, 3
Dave, 3
Amber, 2
*/


var challengeThreeZooAnimals = zooAnimals.OrderBy(x => x.Age);

foreach (var zooAnimal in challengeThreeZooAnimals)
{
    Console.WriteLine($"{zooAnimal.Name}, {zooAnimal.Age}");
}


Console.WriteLine("***********************************************");

Console.WriteLine("Challenge 4");
Console.WriteLine("***********************************************");

/* Challenge 4

Given a list of ZooAnimals
Write a query to group the animals by their Zoo Location

Expected output:
Zoo Location is: ReptileHouse
        Hello, my name is Dina.
        Hello, my name is Asmodeus.
Zoo Location is: Outback
        Hello, my name is Kanga.
        Hello, my name is Amber.
        Hello, my name is Dave.
Zoo Location is: BirdSafari
        Hello, my name is Pingu.
        Hello, my name is Pinga.
        Hello, my name is Wheezy.
        Hello, my name is Mumble.
Zoo Location is: TigerTerritory
        Hello, my name is Jiba.
        Hello, my name is Cuddles.
Zoo Location is: AnimalAdventure
        Hello, my name is Slothy.
        Hello, my name is Slotha.
        Hello, my name is Slothu.
*/

var challengeFourZooAnimals = zooAnimals.OrderBy(x => x.Location).GroupBy(y => y.Location );


foreach (var group in challengeFourZooAnimals)
{
    Console.WriteLine($"Zoo Location is: {group.Key}");
    foreach (var animal in group)
    {
        Console.WriteLine($"\tHello, my name is {animal.Name}.");
    }
        
}

Console.WriteLine("***********************************************");

