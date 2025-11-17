ParameterDemo pd = new ParameterDemo();

int num = 20;
pd.Increase(ref num);
Console.WriteLine("After Increase: " + num);

pd.GetFullName(out string fname);
Console.WriteLine("Full Name: " + fname);

Console.WriteLine("SumAll: " + pd.SumAll(1, 2, 3, 4, 5));
