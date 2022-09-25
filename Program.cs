/*17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0
 и выдаёт номер четверти плоскости, в которой находится эта точка.*/

/* Console.Write("Ведите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 || y == 0){
    Console.Write("Введенное число не может быть 0");
} else if ( x > 0 && y > 0){
    Console.Write("1 четверть");
} else if ( x > 0 && y < 0){
    Console.Write("2 четверть");
} else if ( x < 0 && y < 0){
    Console.Write("3 четверть");
} else {
    Console.Write("4 четверть");
} */


/* Задача 18: Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y). */

/* Console.Write("Ведите четверть (1 - 4): ");
int x = Convert.ToInt32(Console.ReadLine());

if (x < 1 || x > 4){
    Console.Write("Введенное число не может быть меньше 0 и больше 4");
} else if ( x == 1 ){
    Console.Write("1 четверть. x = 1 ... 2 147 483 647, y = 1 ... 2 147 483 647");
} else if ( x == 2 ){
    Console.Write("2 четверть. x = 1 ... 2 147 483 647, y = -1 ... -2 147 483 647");
} else if ( x == 3 ){
    Console.Write("3 четверть. x = -1 ... 2 147 483 647, y = -1 ... -2 147 483 647");
} else {
    Console.Write("4 четверть. x = -1 ... 2 147 483 647, y = 1 ... 2 147 483 647");
}
 */

/* Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21 */

/* int[] arr = new int[4];
for (int i = 0; i < 4; i++)
{
    int num = Convert.ToInt32(Console.ReadLine());
    arr[i] = num;
}
double result = Math.Sqrt(Math.Pow((arr[2] - arr[0]), 2) + Math.Pow((arr[3] - arr[1]), 2));
Console.WriteLine(result);

 */
/* Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4 */

/* 
Console.Write("Введите число N:");
int a = System.Convert.ToInt32(Console.ReadLine());

Console.Write(a + " -> ");

for(int x = 1; x <= a; x++ )
{
    int res = x * x;
    Console.Write(res + ", ");
} */