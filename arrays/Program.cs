int[,,] numbers = { { { 1, 4, 2, 4, 6 }, { 3, 6, 8, 9, 2 }, { 4, 7, 8,3,1 }, {5, 9, 1,5, 6 },{2, 7, 4, 7,8 } } };
int ysum = 0, ysum1 = 0, ysum2 = 0, ysum3 = 0, ysum4 = 0;
int yavg = 0, yavg1 = 0, yavg2 = 0; yavg3 = 0; yavg4 = 0;

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        for (int k = 0; k < numbers.GetLength(2); k++)
        {
            if (j == 0)
            {
                ysum += numbers[i, j, k];
            }
            if (j == 1)
            {
                ysum1 += numbers[i, j, k];
            }
            if (j == 2)
            {
                ysum2 += numbers[i, j, k];
            }
            if (j == 3)
            {
                ysum3 += numbers[i, j, k];
            }
            if (j == 4)
            {
                ysum4 += numbers[i, j, k];
            }
        }
    }
}

Console.WriteLine($"Sum along y-axis for first element: {ysum}");
Console.WriteLine($"Sum along y-axis for second element: {ysum1}");
Console.WriteLine($"Sum along y-axis for third element: {ysum2}");
Console.WriteLine($"Sum along y-axis for fourth element: {ysum3}");
Console.WriteLine($"Sum along y-axis for fifth element: {ysum4}");
