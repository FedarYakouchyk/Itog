void PrintArray(string[] array)
{
    System.Console.WriteLine("['" + String.Join("', '", array) + "']");
}
string[] NewArr()
{
    System.Console.WriteLine("Введите размер массива.");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string [size];
    if (size > 0)
    {
        System.Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Console.ReadLine();
        }
        PrintArray(array);
    }
    else
    {
        System.Console.WriteLine("Введённое вам значение не корректно, попробуйте снова!");

    }
    return array;
}
string[] ArrFin(string [] array)
{
    Random rand = new Random();
    int size = rand.Next(1, 3 + 1 );
    string[] array2 = new string [size];
            for (int i = 0; i < array2.Length; i++)
        {
            array2[i] = array[rand.Next(0, array.Length+1)];
        }
        PrintArray(array2);
    
    return array;
}