using System;
using System.Collections.Generic;

List<string> surnames = new List<string>() {"Micke", "Martin", "Lena"};

// surnames.Add("Micke");
// surnames.Add("Martin");

surnames.RemoveAt(0);

Console.WriteLine(surnames[0]);



// string name1 = "Micke";
// string name2 = "Martin";
// string name3 = "Lena";

// string name = "";

// Random generator = new Random();

// int n = generator.Next(3);
// if (n == 0) name = name1;
// if (n == 1) name = name2;
// if (n == 2) name = name3;

string[] names = { "Micke", "Martin", "Lena", "Anna" };

// int i = 0;
// while (i < names.Length)
// {
//   Console.WriteLine(names[i]);
//   i++;
// }

// for (int j = 0; j < names.Length; j++)
// {
//   Console.WriteLine(names[j]);
// }

for (int j = 0; j < names.Length; j++)
{
  names[j] = names[j].ToUpper();
}

// Console.WriteLine(names[1]);

// Console.WriteLine(names[1]);
// Console.WriteLine(names[2]);
// Console.WriteLine(names[3]);


// Console.WriteLine(names[7]);

// Random generator = new Random();

// int i = generator.Next(names.Length);

// Console.WriteLine(names[i]);






Console.ReadLine();