class Program
{
    static void Main()
    {
        Console.WriteLine("Введите исходный массив строк: ");// Введите  массив строк
        string[] sourceArray = Console.ReadLine().Split(' ');
    
        string[] newArray = new string[sourceArray.Length];// Формируем новый массив из строк, длина которых меньше или равна 3 символам
        int count = 0;
        for (int i = 0; i < sourceArray.Length; i++)
        {
            if (sourceArray[i].Length <= 3)
            {
                newArray[count] = sourceArray[i];
                count++;
            }
        }
        
        Console.WriteLine("Новый массив строк:");// Печатаем новый массив
        for (int i = 0; i < count; i++)
        {
            Console.Write(newArray[i] + " ");
        }
    }
}

