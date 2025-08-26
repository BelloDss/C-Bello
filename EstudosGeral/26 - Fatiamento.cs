//Fatia[inicio..Final -]

List<string> lista2 = new List<string>
{
  "Python",
  "Java",
  "C#",
  "PQP",
  "SQL",

};

//Sem Fatia [inicio..Final-1]
Console.WriteLine(string.Join(", ", lista2));

//Com Fatia [inicio..Final-1]
Console.WriteLine(string.Join(", ", lista2[0..3]));
Console.WriteLine(string.Join(", ", lista2[1..4]));
Console.WriteLine(string.Join(", ", lista2[2..5]));

List<string> times = new List<string>
{
  "vasco",
  "sãopaulo",
  "palmeiras",
  "curica",
  "são bento",
  "santos",
};
List<string> fati1 = times[4..1];
List<string> fati2 = times[..1];
List<string> fati3 = times[1..5];

Console.WriteLine(string.Join(", ", fati1));
Console.WriteLine(string.Join(", ", fati2));
Console.WriteLine(string.Join(", ", fati3));




