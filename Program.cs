/* **Задача**: Написать программу, которая из имеющегося массива
строк формирует массив из строк, длина которых меньше либо 
равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении 
не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
**Примеры**:
[hello,2,world,:-)] -> ["2", ":-)"]
[1234,1567,-2,computer science] -> ["-2"]
[Russia,Denmark,Kazan] -> [] */

string[] CreateArray()
{
    Console.WriteLine("Введите элементы массива через запятую: ");
    string[] array = Console.ReadLine()!.Split(',');
    Console.WriteLine($"Изначальный массив: [{string.Join(", ", array)}]");
    return array;
}
string[] ChangeArray(string[] Array, int MaxLenght = 3)
{
    string value = string.Empty;
    string[] ArrayChange = new string[Array.Length];
    for (int i = 0; i < Array.Length; i++)
    {
        value = Array[i];
        if (value.Length <= MaxLenght) ArrayChange[i] = Array[i];
    }
    ArrayChange = ArrayChange.Where(x => x != null).ToArray();

    return ArrayChange;
}

string[] result = CreateArray();
string[] result1 = ChangeArray(result);
Console.WriteLine($"Новый массив: [{string.Join(", ", result1)}]");