void FillSecondArray(string[] strg1, string[] strg2)
{
    int count = 0;
    for (int i = 0; i < strg1.Length; i++)
    {
    if(strg1[i].Length <= 3)
        {
        strg2[count] = strg1[i];
        count++;
        }
    }
}
void PrintArray(string[] strg)
{
    for (int i = 0; i < strg.Length; i++)
    {
        Console.Write($"{strg[i]} ");
    }
    Console.WriteLine();
}

string[] strg1 = new string[6] {"hello", "2", "world", ":--P", ":-)", "yes"};
string[] strg2 = new string[strg1.Length];

PrintArray(strg1);

FillSecondArray(strg1, strg2);
PrintArray(strg2);
