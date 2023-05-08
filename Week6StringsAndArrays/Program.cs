
string hello = "hello, world! ".;

int stringLenght = hello.Length;

hello = hello.Trim();

char firstLetter = hello[0];

hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('!', '?');

Console.WriteLine(hello);





//int wordCounter = 1;
//for (int i = 0; i < hello.Length; i++)
//{
//  if (char.IsWhiteSpace(hello[i]))
// {
//     wordCounter++;
//}
//}



//Console.WriteLine($"Word count in {hello}: {wordCounter} words.");