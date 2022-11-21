// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

void FillArray(int[] array)
{
    Console.WriteLine("Введите числа: ");
    int Length = array.Length;
    int index = 0;
        while (index < Length)
    {
    array[index] = int.Parse(Console.ReadLine()!);
    index++;
                    
    }
                     
    }

void poloz(int[] array)
{
   int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count ++;
    }
}
Console.WriteLine("Количество чисел больше 0: " + count);
}

void PrintArray(int[] col)
{
    Console.WriteLine("Массив");
    int count = col.Length;
    int position = 0;
        while (position < count)
{
        Console.Write(col[position] + "; ");
        position++;
}
}
            
Console.WriteLine("Введите количество элементов: ");
           
int number = int.Parse(Console.ReadLine()!);

int[] array = new int[number];
FillArray(array);        
PrintArray(array);
poloz(array);