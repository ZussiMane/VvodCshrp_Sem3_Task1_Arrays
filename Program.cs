// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве. Программа 
// должна выдать ответ: "Да/Нет".
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

//              0  1  2  3   4 - индексы
// int[] array = { 1, 3, 4, 19, 3 };
// int num = 19;
// bool isExistNum = false;

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == num)
//     {
//         isExistNum = true;
//         break;
//         // Console.WriteLine("Да");
//         // break; //-- оператор прерывания цикла (оператора "if")
//     }
// }
// Console.WriteLine(isExistNum ? "Да" : "Нет");

// // if (isExistNum) Console.WtiteLine("Да");
// // else 
// // Console.WriteLine("Нет")

//--------усовершенственное решение--------//

//             0  1  2   3  4
int[] array = {1, 3, 4, 19, 3};
int num = 4;
bool isExistNum = false;

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

Console.WriteLine();

Console.WriteLine("Искомое число: " + num);


for (int i = 0; i < array.Length; i++)
{
    if(array[i] == num)
    {
        isExistNum = true;
        break;
    }
}

Console.WriteLine(isExistNum ? "Да" : "Нет");

// if (isExistNum) Console.WriteLine("Да");
// else Console.WriteLine("Нет");