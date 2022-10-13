//==================================================================
// Написать программу, которая из имеющегося массива строк или 
// введённого с клавиатуры, формирует массив строк, длина которых
// меньше либо равна 3 символа. При решении использовать 
// исключительно массивы. 
//================================================================== 
// Метод получения числовых данных пользователя.
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод получения строковых данных пользователя.
string ReadDataString(string line)
{
    Console.Write(line);
    string dataStr = Console.ReadLine() ?? "0";
    return dataStr;
}

// Метод вывода результата.
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// Метод заполнения массива строками.
string[] GenArrayString(int num)
{
    string[] array = new string[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = ReadDataString($"  Введите {i+1} строку: ");
    }
    return array;
}

// Метод печати массива.
void Print1DArray(string[] arr)
{
    Console.WriteLine($"  [{string.Join(", ", arr)}]");
}

// Метод получиния массива из исходного с 
// длиной строк <= 3 символов.
string[] ArrayStringThreeChar(string[] arr)
{
    string[] outArr = new string[0];
    for (int i = 0; i < arr.Length; i++)
    {
        // если введена пустая строка - 0 символов 
        // if (arr[i].Length > 0 && arr[i].Length <= 3)

        if (arr[i].Length <= 3)
        {
            Array.Resize(ref outArr, outArr.Length+1);
            outArr[outArr.Length-1] = '"' + arr[i] + '"';
        }
    }
    return outArr;
}

int numberStr = ReadData("Введите - сколько будет введено строк?: ");
PrintResult("\nВведите строки из слов или набора символов: ");
string[] arrayString = GenArrayString(numberStr);

PrintResult("\nВсе строки длиной меньше или равно три символа: ");
string[] result = ArrayStringThreeChar(arrayString);
Print1DArray(result);
