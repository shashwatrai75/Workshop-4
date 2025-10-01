Student s1 = new Student();
s1.name = "Alice";
s1.age = 20;
s1.course = "Computer Science";

Student s2 = new Student();
s2.name = "Bob";
s2.age = 22;
s2.course = "Data Science";

Console.WriteLine($"Student 1: {s1.name}, {s1.age}, {s1.course}");
Console.WriteLine($"Student 2: {s2.name}, {s2.age}, {s2.course}");

Console.WriteLine("School Name: " + Student.schoolName);
