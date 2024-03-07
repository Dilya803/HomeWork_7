// Задайте произвольный массив. Выведете его элементы, начиная 
//с конца. Использовать рекурсию, не использовать циклы.

void PrintMass(int[] Masnew_mas, int i = 0)
{
    if (i > 0)
    {
        Console.Write(Masnew_mas[i]);
        PrintMass(Masnew_mas, i - 1);
    }
    else
    {
        Console.WriteLine(Masnew_mas[i]);
    }

}

void Print_mas(int[] col)
{
    foreach (var item in col)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

int[] Random_mas(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(1, 10);
    }
    return col;
}


Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] Mass = new int[n];
int[] new_mas = Random_mas(Mass);
Print_mas(new_mas);
PrintMass(new_mas, new_mas.Length - 1);
