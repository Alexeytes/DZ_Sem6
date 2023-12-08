// Задача 3: Задайте произвольную строку. Выясните,
// является ли она палиндромом.

Console.Write("Задайте произвольную строку: ");
string words = Console.ReadLine();
Console.WriteLine();

string resiv = ToResiver(words);
string result = IsPalindrom(words, resiv);
Console.WriteLine(string.Join(' ', result));

string ToResiver(string word)
{
    char[] wordForResiver = word.ToCharArray();
    Array.Reverse(wordForResiver);
    string wordResiver = new string(wordForResiver);

    return wordResiver;
}

string IsPalindrom(string word, string wordRes){
    string res = string.Empty;
    if(word == wordRes) res = "ДА";
    else res = "НЕТ";
    return res;
}