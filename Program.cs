string[] mas1 = new string[] {"Hello", "2", "world", ":-)"};
//string[] mas1 = new string[] {"1234", "1567", "-2", "computer science"};
//string[] mas1 = new string[] {"Russia", "Denmark",  "Kazan"};
string[] mas2 = new string[mas1.Length];
    int count = 0;
    for (int i = 0; i < mas1.Length; i++)
    {
    if(mas1[i].Length <= 3)
        {
        mas2[count] = mas1[i];
        count++;
        }
    }

    for (int i = 0; i < mas2.Length; i++)
    {
        Console.Write($"{mas2[i]} ");
    }
    Console.WriteLine();
