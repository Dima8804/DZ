

Console.Clear();

int[] n = Console.ReadLine().Split(' ').Select(e => Convert.ToInt32(e)).ToArray();

int[] result = Sum0(n);
System.Console.WriteLine(result);

int[] Sum0(int[] array)
{
    int[] res =new int [array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >=  100 & array[i] <= 1000)
        {
            res[i] = array[i];
           System.Console.WriteLine( res[i]);
        }

    }
    return res ;
}
