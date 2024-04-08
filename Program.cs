int getCountLitleWord(string[] words) {
    int count = 0;
    foreach (string word in words)
    {
        if (word.Length <= 3)
        {
            count++;
        }
    }
    return count;
}


string[] getArrayLitleWord(string[] words)
{
    int length = getCountLitleWord(words);
    int index = 0;
    string[] result = new string[length];
    foreach (string word in words)
    {
        if (word.Length <= 3)
        {
           result[index] = word;
           index++;
        }
    }
    return result;
}

void printArray(string[] words)
{
    foreach (string word in words)
    {
        Console.Write(word + " ");
    }
}


Console.WriteLine("Введите количество слов");
int countWords = int.Parse(Console.ReadLine()!);
string[] inputListWords = new string[countWords];
for (int i = 0; i < countWords; i++)
{
    inputListWords[i] = Console.ReadLine()!;

}
Console.WriteLine();

string[] arrayLitleWords = getArrayLitleWord(inputListWords);
printArray(arrayLitleWords);
