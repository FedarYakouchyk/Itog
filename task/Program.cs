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