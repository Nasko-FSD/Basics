var n = int.Parse(Console.ReadLine());
var minArea = int.Parse(Console.ReadLine());
var count = 0;
for (var left = -n; left <= n; left++)
{
    for (var top = -n; top <= n; top++)
    {
        for (var right = left + 1; right <= n; right++)
        {
            for (int bottom = top + 1; bottom <= n; bottom++)
            {
                var width = right - left;
                var height = bottom - top;
                var area = Math.Abs(right - left) * Math.Abs(bottom - top);
                if ( (area >= minArea))
                {
                    Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}", left, top, right, bottom, area);
                    count++;
                }
            }
        }
    }
}
if (count == 0)
{
    Console.WriteLine("No");
}