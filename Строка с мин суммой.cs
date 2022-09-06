int CorrectInput()
{
    string? UserNumber;
    int number = 0;
    bool check = false;
    while (check == false)
    {
        UserNumber = Console.ReadLine();
        if (int.TryParse(UserNumber, out number))
        {
            check = true;
        }
        else
        {
            Console.Write("Ошибка ввода.\n Повторите ввод:");
        }
    }
    return number;
}

// создание двумерного массива
int[,] CreateArray()
{
    Console.Write("Введите количество строк: ");
    int n = CorrectInput();
    Console.Write("Введите количество столбцов: ");
    int m = CorrectInput();
    int[,] matrix = new int[n, m];
    for (int i = 0; i<n; i++)
    {
        for (int j = 0; j<m; j++)
        {
            matrix[i,j] = new Random().Next(-9,10);            
        }
    }
    return matrix;
}

// Вывод двумерного массива
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i<matrix.GetUpperBound(0) + 1; i++)
    {
        for (int j = 0; j<matrix.GetUpperBound(1) + 1; j++)
        {
            if (matrix[i,j]<0)
                Console.Write(matrix[i,j]+" ");
            else
                Console.Write(" " + matrix[i,j]+" ");             
        }
    Console.WriteLine();
    }
}


// Поиск минимальной суммы
void MinimalSumInRowMatrix(int[,] matrix)
{
    int row = 0, box = 0, sum = 10*matrix.GetLength(0);
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            box += matrix[i,j];
        }
        if (sum > box)
        {
            sum = box;
            row = i + 1;
            box = 0;
        }
    }
    Console.WriteLine("Минимальная сумма в строке: " + row);
}


//Код программы
int[,] twoDimensionalArray = CreateArray();
PrintMatrix(twoDimensionalArray);
MinimalSumInRowMatrix(twoDimensionalArray);