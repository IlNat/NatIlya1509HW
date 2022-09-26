// Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100.
// Определить сумму элементов массива, расположенных
// между минимальным и максимальным элементами.

int rows = 5;
int columns = 5;
int min = 100;
int max = -100;
bool maxWasFounded = false;
bool minWasFounded = false;
int sumBetween = 0;
Random rand = new Random();
int[,] array2D = new int[rows, columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array2D[i, j] = rand.Next(-100, 100);
        
        if (array2D[i, j] > max)
            max = array2D[i, j];

        if (array2D[i, j] < min)
            min = array2D[i, j];
    }
};

Console.WriteLine("Hello, World!");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        
        if (array2D[i, j] == max)
            maxWasFounded = true;
        if (minWasFounded == true && maxWasFounded == false)
            sumBetween += array2D[i, j];
        if (array2D[i, j] == min)
            minWasFounded = true;
        
        Console.Write($"{array2D[i, j]}\t");
        
    }
    Console.WriteLine();
};

Console.WriteLine($"Наибольшое число: {max}");
Console.WriteLine($"Наименьшее число: {min}");
Console.WriteLine($"Сумма чисел между наименьшим и наибольшим числами равна: {sumBetween}");