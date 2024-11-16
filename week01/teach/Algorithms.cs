using System.Diagnostics;

public static class Algorithms {
    public static void Run() {
        Console.WriteLine("{0,15}{1,15}{2,15}{3,15}{4,15}{5,15}{6,15}", "n", "alg1-count", "alg2-count", "alg3-count",
            "alg1-time", "alg2-time", "alg3-time");
        Console.WriteLine("{0,15}{0,15}{0,15}{0,15}{0,15}{0,15}{0,15}", "----------");

        for (int n = 0; n < 15001; n += 1000) {
            int count1 = Algorithm1(n);
            int count2 = Algorithm2(n);
            int count3 = Algorithm3(n);
            double time1 = Time(Algorithm1, n, 10);
            double time2 = Time(Algorithm2, n, 10);
            double time3 = Time(Algorithm3, n, 10);
            Console.WriteLine("{0,15}{1,15}{2,15}{3,15}{4,15:0.00000}{5,15:0.00000}{6,15:0.00000}", n, count1, count2,
                count3, time1, time2,
                time3);
        }
    }

    private static double Time(Func<int, int> algorithm, int input, int times) {
        var sw = Stopwatch.StartNew();
        for (var i = 0; i < times; ++i) {
            algorithm(input);
        }

        sw.Stop();
        return sw.Elapsed.TotalMilliseconds / times;
    }

    /// <summary>
    /// The count variable is keeping track of the amount
    /// of work done in the function.  When the function is 
    /// done the count is returned.
    /// </summary>
    /// <param name="size">the amount of work to do</param>
    private static int Algorithm1(int size) {  // O(n)
        var count = 0;
        for (var i = 0; i < size; ++i)
            count += 1;

        return count;
    }

    /// <summary>
    /// The count variable is keeping track of the amount
    /// of work done in the function.  When the function is 
    /// done the count is returned.
    /// </summary>
    /// <param name="size">the amount of work to do</param>
    private static int Algorithm2(int size) { 
        var count = 0;
        for (var i = 0; i < size; ++i)
        for (var j = 0; j < size; ++j)
            count += 1;

        return count;
    }

    /// <summary>
    /// The count variable is keeping track of the amount
    /// of work done in the function.  When the function is 
    /// done the count is returned.
    /// </summary>
    /// <param name="size">the amount of work to do</param>
    private static int Algorithm3(int size) {  // O(log n)
        var count = 0;
        var start = 0;
        var end = size - 1;
        while (start <= end) {
            var middle = (end - start) / 2 + start;
            start = middle + 1;
            count += 1;
        }

        return count;
    }
}
//1.
// Alg1- O(n)
// Alg2- O(n^2) the indenting tricked me on this one
////at first I thought this was O(n) until I realized it was a loop within a loop even though the indenting is on the same level. its O(n^2)
// Alg3- O(log n)
//2.
// Alg 3 has the best performance being logarithmic 
//3.
// becuase when n is large and the algorithm is exponential it increses the time it takes to run exponentilly  (when n is small n*n is small when n is large n*n is large)