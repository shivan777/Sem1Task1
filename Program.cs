// Программа принимает два числа и выдает какое число большее.
string inputLineA = Console.ReadLine()??"";
string inputLineB = Console.ReadLine()??"";

    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);

    if (inputNumberA > inputNumberB)
    {
        Console.Write("max = ");
        Console.Write(inputLineA);
    }
    else
    {
        Console.Write("max = ");
        Console.Write(inputLineB);
    }