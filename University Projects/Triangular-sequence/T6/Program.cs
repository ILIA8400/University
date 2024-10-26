// ایلیا اصغرحری
// تمرین ششم



// دنباله مثلثی بین جمله ام تا ان

string yn;

do
{


    Console.WriteLine("Enter the number of the first sentence:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the number of the Second sentence:");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Triangular sequence between sentence M and N:");
    for (int x = m; x <= n; x++)
    {
        int f = x * (x + 1) / 2;

        Console.WriteLine(f);

    }
    Console.WriteLine("do you continue? y/n");
     yn = Console.ReadLine();

}
while (yn == "y");

Console.WriteLine("THE END");
