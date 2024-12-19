Console.WriteLine("==========================Shahad Eissa Basics2===============================");
Console.WriteLine("=============================C# control flow=================================");
#region 1

Console.WriteLine("===============================Challenge 1===================================");
int i;
for (i = 1; i <= 10; i++)
{
    Console.WriteLine("counter: " + i);
}
#endregion
Console.WriteLine("==================================Bonus======================================");


Console.WriteLine("=================================C# array====================================");
#region 2
Console.WriteLine("===============================Challenge 1===================================");
string[] daysOfWeek1 = new string[7];
daysOfWeek1[0] = "Monday";
daysOfWeek1[1] = "Tuesday";
daysOfWeek1[2] = "Wednesday";
daysOfWeek1[3] = "Thursday";
daysOfWeek1[4] = "Friday";
daysOfWeek1[5] = "Saturday";
daysOfWeek1[6] = "Sunday";
for (int z = 0; z < daysOfWeek1.Length; z++)
{
    Console.WriteLine("the day is: " + daysOfWeek1[z]);
}

Console.WriteLine("============================Alternative solution=============================");
string[] daysOfWeek2 = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
for (int y = 0; y < daysOfWeek2.Length; y++)
{
    Console.WriteLine("the day is: " + daysOfWeek2[y]);
}
#endregion

#region 3
Console.WriteLine("===============================Challenge 2===================================");

//taking the number of the array's repeatition from the user:
int sum = 0;
Console.WriteLine("enter a value of repetition: ");
int[] ThisArray = new int[Convert.ToInt32(Console.ReadLine())];
for (int x = 0; x < ThisArray.Length; x++)
{
    Console.WriteLine("enter the value: ");
    ThisArray[x] = Convert.ToInt32(Console.ReadLine());
    sum += ThisArray[x];
}
Console.WriteLine("sum: " + sum);

Console.WriteLine("============================Alternative solution=============================");
//Alternative solution: with pre-assigning the number of array's repeatition:
int sum2 = 0;
int[] ThisArray2 = new int[3];
for (int x2 = 0; x2 < ThisArray2.Length; x2++)
{
    Console.WriteLine("enter the value you want to add: ");
    ThisArray2[x2] = Convert.ToInt32(Console.ReadLine());
    sum2 = sum2 + ThisArray2[x2];
}
Console.WriteLine("sum is: " + sum2);
#endregion