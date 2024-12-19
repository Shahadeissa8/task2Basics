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

#region bonus
Console.WriteLine("==================================Bonus======================================");
int bonus=5; //5-1
while (bonus >=1)
{
    Console.WriteLine(bonus);
    bonus--;
}    
#endregion

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
    Console.WriteLine("enter the value you want to add: ");
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

#region bonus2
Console.WriteLine("==================================Bonus======================================");
//multi dimentional arrays:
//first we have to know that we have been using so far is a 1D array, now ill explain the 2D array, and the same method could work for the 3D array):
// 1D array: arr=[index]
// 2D array: arr=[row,column]
// 3D array: arr=[depth, row, column]
//lets start explaining 2D arrays (3D arrays is stacking 2D arrays), eg: int [] number = {{5,6,7},{0,3,4}};
//reading it would be like this {{0.0,0.1,0.2},{1.0,2.0,3.0}}// dataType[,] array {{row},{column}}:
int[,] num = { { 5, 6, 7 }, { 0, 3, 4 } };
//in this example, this is how its read
//num[0, 0] = 5, num[0, 1] = 6, num[0, 2] = 7
//num[1, 0] = 0, num[1, 1] = 3, num[1, 2] = 4
for (int k = 0; k < num.GetLength(0); k++)             //when we enter the loop it all starts with k=0 (row)
{                                                      
    for (int m = 0; m < num.GetLength(1); m++)         //then we will enter the second loop with k=0 and m=0 (column)
    {                                                  //then the program will print the first element of the table (first row, first column)
        Console.Write( num[k, m] + "\t");              //here i made the code print the output >> note: I added enter tab or \t in order for the code to have tabs between each output 
    }
    Console.Write("\n");                               //i added this bit because i wanted the code to print a new line, why?
                                                       //because with the new line for this 2D array and with the tabs the array will
                                                       //look like a table
}

//breifly 3D arrays like i mentioned is stacking 2D arrays as follows:
//int[,,] array3D = {
//    { { 1, 2}, { 3, 4} },  // first 2D array 
//    { { 5, 6}, { 7, 8} }   // second 2D array 
//}
#endregion