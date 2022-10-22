// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
/*
int[] array = GetArray(5,7,8);
Console.WriteLine($"{String.Join(" ", array)}");

int GetSum = 0;

for (int i = 0; i < array.Length; i++)
{
if (array[i]>0)
{
GetSum = GetSum + array[i];
}
else
{
Console.WriteLine ("Нет таких чисел ");
}
}
Console.WriteLine($"Введите GetSum = {GetSum}");

int[] GetArray(int size, int minValue, int maxValue)
{   
int[] res = new int[size]; 

for (int i = 0; i < size; i++)     
{        
     res[i] = new Random().Next(minValue, maxValue + 1);     
     }     
     return res; 
     }

*/

//Найти произведение всех элементов массива целых чисел, меньших заданного числа. 
//Размерность массива –10. Заполнение массива осуществить случайными числами от 50 до 100.
/*
int[] array = GetArray(10,50,100);
Console.WriteLine(String.Join("",array));

Console.WriteLine("Введите число: ");
int x = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Произведение чисел, меньше {x} = {SearchNumber(array, x)}");

int SearchNumber(int[] inArray, int x){
int pro = 1;
for (int i = 0; i < inArray.Length; i++)
{
if(array[i] < x){
    pro = array[i];
}
}
return pro;
}

int[] GetArray(int size, int minValue, int maxValue)
{   
int[] res = new int[size]; 

for (int i = 0; i < size; i++)     
{        
     res[i] = new Random().Next(minValue, maxValue + 1);     
     }     
     return res; 
     }
     */