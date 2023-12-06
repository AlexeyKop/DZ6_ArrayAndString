// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.
/*
void InputMatrix(char [,] matrix){
    string symbols = "abcdefghijklmnopqrstuvwxyz";
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int index = new Random().Next(symbols.Length);
            matrix[i, j] = symbols[index];
        }
    }
}
void PrintMatrix(char[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
string CreateString (char[,] matrix){
    string result = string.Empty;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result += matrix[i,j];
        }
    }
    return result;
}

Console.Clear();
Console.Write("Введите размеры двумерного массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[] OneDimArray = new int [size.Length];
char [,] matrix = new char[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив: ");
PrintMatrix(matrix);
Console.WriteLine($"Finish String: {CreateString(matrix)}");
*/
// ==============================

// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.
/*
void LowerString (string AnyString){
    char result = '!';    
    char[] charArry = AnyString.ToCharArray();
        foreach (char elem in charArry)
        {  
            if (Char.IsUpper(elem))
            {  
            result = Char.ToLower(elem);
            }
            else
            result = elem;
        Console.Write(result);
        }
}
Console.Clear();
Console.WriteLine("Enter any sring: ");
string AnyString = Console.ReadLine()!;
LowerString(AnyString);
*/

// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

bool PalindromString (string AnyString){    
    for (int i = 0; i < (AnyString.Length-1)/2; i++)
    {
        if (AnyString[i] != AnyString[AnyString.Length - 1 - i])
            return false;                 
    }
    return true;   
}   
    
Console.Clear();
Console.WriteLine("Enter any string: ");
string AnyString = Console.ReadLine()!;

if (PalindromString(AnyString) == false)
    Console.WriteLine ($"Строка '{AnyString}' не является палиндромом");
else
    Console.WriteLine ($"Congratulations. It's: '{AnyString}' polyline!");





