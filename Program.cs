string s = "8th";
Console.WriteLine("Welcome to my " + s + "challenge!");
Console.WriteLine("Let's have some fun with the next project:\n");


Console.WriteLine("Insert triangle's width you would like to calculate and press ENTER:");
string widthText = Console.ReadLine();
float width = Convert.ToSingle(widthText);

//taking information from the user
Console.WriteLine("Insert triangle's height you would like to calculate and press ENTER");
string heightText = Console.ReadLine();
float height = Convert.ToSingle(heightText);

// finding out the area
float area = (width * height) / 2;
Console.WriteLine("The area of the triangle is: " + area);
Console.WriteLine("Press any key to stop this program");


