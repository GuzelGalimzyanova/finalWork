/*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/


Console.WriteLine("Введите элементы массива через пробел ");
string text = Console.ReadLine();
if (text == "")
{
    Console.WriteLine("введенный массив пустой");
    Environment.Exit(0);
}
var inputArray = text.Split(' ');
string[] arrayNew = new string[inputArray.Length];
int j = 0;

for (int i = 0; i < inputArray.Length; i++)
{
    if (inputArray[i].Length <= 3)
    {
        arrayNew[j] = inputArray[i];
        j++;
    }
}
Array.Resize(ref arrayNew, j);
Console.WriteLine("полученный массив : " + string.Join(",", arrayNew));

