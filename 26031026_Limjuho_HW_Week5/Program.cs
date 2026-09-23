
    internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1 ~100 짝수 출력");
        for (var i = 1; i <= 100; ++i)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
        Console.WriteLine();

        Console.WriteLine("0 ~10 while 작성");
        var iwhile = 0;
        while (iwhile <= 10)
        {
            Console.WriteLine(iwhile);
            ++iwhile;
        }
        Console.WriteLine();

        Console.WriteLine("1 ~100 홀수 do while 작성");
        var idowhile = 0;
        do
        {
            if (idowhile % 2 == 1)
            {
                Console.WriteLine(idowhile);
            }
            idowhile++;
        }
        while (idowhile < 100);
        Console.WriteLine();

        Console.WriteLine("별 피라미드 출력");
        for (int i = 0; i < 8; ++i)
        {
            for (int j = i + 1; j < 8; ++j)
            {
                Console.Write(' ');
            }

            for (int j = 0; j <= i * 2; ++j)
            {
                Console.Write('*');
            }

            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine("숫자 5개 입력 최소 최대 출력");
        int[] iarr = new int[5];
        for (int i = 0; i < 5; ++i)
        {
            Console.Write($"숫자를 입력하시오 현재 {i}개 : ");
            iarr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(iarr);
        Console.Write($"최소 값 {iarr[0]}, 최대값 {iarr[4]}");
    }
}

