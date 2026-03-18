
Console.WriteLine("Hello, World!");
Console.WriteLine("Feature1");

Console.WriteLine("Feature2");



static double CalculateMax(int[] values)
{
    int max = -1;
    foreach (var value in values)
        if (value > max)
            max = value;
    
    return max;
}


try
{
    int x = int.Parse(Console.In.ReadLine());
    Console.WriteLine(x*x);
    double[] y = new[] { 1.0, 2.0, 3.0, 4.0};
    double z = 0;
    for (int i = 0; i < y.Length; i++)
    {
        z += y[i];
    }
    Console.WriteLine(z);
}
catch (Exception e)
{
    Console.WriteLine(e);
    throw;
}

static int CalculateAverage(int[] values)
{
    int sum = 0;
    for (int i = 0; i < values.Length; i++)
    {
        sum += values[i];
    }
    sum /= values.Length;
    return sum;
}

int[] val = new[]{1,2,3,4,5,6};

Console.WriteLine(CalculateAverage(val));

int CalculateMin(int[] values)
{
    int valMin = int.MaxValue;
    for (int i = 0; i < values.Length; i++)
    {
        if (values[i] < valMin)
        {
            valMin = values[i];
        }
    }
    return valMin;
}


