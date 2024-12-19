// Shahad Eissa
//Control flow
Console.WriteLine("===============================C# control flow===============================");
Console.WriteLine("===============================Challenge 1===================================");

int i;
for ( i =1; i<=10; i++)
{
    Console.WriteLine("the number currently is: " + i);
}

Console.WriteLine("==================================Bonus======================================");

Console.WriteLine ("=================================C# array===================================");
Console.WriteLine("===============================Challenge 1===================================");
string [] daysOfWeek = new string[7];
daysOfWeek[0] = "Monday";
daysOfWeek[1] = "Tuesday";
daysOfWeek[2] = "Wednesday";
daysOfWeek[3] = "Thursday";
daysOfWeek[4] = "Friday";
daysOfWeek[5] = "Saturday";
daysOfWeek[6] = "Sunday";
for (int z = 0; z <daysOfWeek.Length; z++)
{
    Console.WriteLine("the day is " + daysOfWeek[z]);
}


// two dimention array int [,] number = {{5,6,7, },{0,3,4,}};
// benefit {{0.0,0.1,0.2},{1.0,2.0,3.0}}


// takes an array of int \//uses a for loop to print weather each num is even or odd
//if the num is even it prints even otherwise prints odd


Console.WriteLine("===============================Challenge 2===================================");
int sum = 0;
Console.WriteLine("enter a value of repetition: ");
int[] ThisArray = new int[Convert.ToInt32(Console.ReadLine())];
for (int x = 0; x < ThisArray.Length; x++)
{
    Console.WriteLine("enter the value: ");
    ThisArray[x] = Convert.ToInt32(Console.ReadLine());
    sum+= ThisArray[x] ;
    //Console.WriteLine("enter a number to add ");
    //int sum = sum + Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("sum: " + sum);