Console.Write("Enter a day: ");
string day = Console.ReadLine();

if (day.ToLower() == "friday" || day.ToLower() == "saturday")
    Console.WriteLine("It is: Weekend");
else
    Console.WriteLine("It is: Weekday");

Book b1 = new Book("C# Basics", "John Doe", 29.99);
Book b2 = b1 with { title = "Advanced C#", price = 39.99 };

Console.WriteLine($"Book 1: {b1}");

var (title, author, price) = b2;
Console.WriteLine($"Book 2 Deconstructed: {title}, {author}, {price}");
