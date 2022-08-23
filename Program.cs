
//Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int [] array = new int [8];
int evenNumber = 0;
Console.Write("[");

for (int i = 0; i< array.Length; i++)
{
  array[i] = new Random().Next(100,1000);
  Console.Write(" " + array[i]);
  if (array[i] % 2 == 0) evenNumber++;
}

Console.WriteLine("]");
Console.WriteLine("В масссиве " + evenNumber + " четных числа");
*/




//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int [] array = new int [8];
int sum = 0;

Console.Write("[");

for (int i = 1; i< array.Length; i++)
{
  array[i] = new Random().Next(99);
  Console.Write(" " + array[i]);
 if (i % 2 == 0) sum = sum + array[i];
   
}

Console.WriteLine("]");
Console.WriteLine(sum);

*/

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
Console.Write("Введите размер массива ");
int Size = Convert.ToInt32(Console.ReadLine());
double [] array = new double [Size];

for (int i=0; i < array.Length; i++)
{
array[i] = new Random().Next(1, Size);
Console.Write(" " + array[i]);}

double maximum = array[0];
double minimum = array[0];


for (int i=1; i < array.Length; i++)
{

if ( maximum < array[i]) {maximum = array[i];}
if (minimum > array[i]) {minimum = array[i];}
}
 

double difference = maximum - minimum;
Console.WriteLine("");
Console.WriteLine($" max-min= {difference}");

*/
