// Задача 1: Задайте двумерный массив символов (тип char
// [,]). Создать строку из символов этого массива. 

char[,] arr = { { 'В', 'с', 'е', 'м', ' ', ' ', ' ' }, { 'П', 'р', 'и', 'в', 'е', 'т', '!' } };

string value = String.Concat<char>(To1Array(arr));
Console.WriteLine(string.Join(' ', value));

char[] To1Array(char[,] wordArr)
{
    char[] newArr = new char[wordArr.GetLength(0) * wordArr.GetLength(1)];
    int z = 0;
    for (int i = 0; i < wordArr.GetLength(0); i++)
        for (int j = 0; j < wordArr.GetLength(1); j++)
        {
            newArr[z] = wordArr[i, j];
            z++;
        }
    return newArr;
}