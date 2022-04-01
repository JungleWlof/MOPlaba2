using System;

namespace MOPlaba2
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.Write("Введите количество элементов массива А \n-> ");
            int a = Convert.ToInt32(Console.ReadLine());
            int [] A = new int [a];
            Console.WriteLine("Введите элементы массива А через <Enter>");
            for (int i = 0; i < a; i++)
            {
                Console.Write("-> ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(A);
            Console.Write("Введите количество элементов массива B \n-> ");
            int b = Convert.ToInt32(Console.ReadLine());
            int[] B = new int[b];
            Console.WriteLine("Введите элементы массива B через <Enter>");
            for (int i = 0; i < b; i++)
            {
                Console.Write("-> ");
                B[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(B);
            Console.Write("Веберите операцию \n1 - объединение \n2 - пересечение \n3 - включение \n-> ");
            int mode;
            mode = Convert.ToInt32(Console.ReadLine());
            switch (mode)
            {
                case 1:
                    {
                        int j = 0;
                        if (a > b)
                        {
                            for (int i = 0; i < a;)
                            {
                                if (a == i)
                                {
                                    for (int p = j; p < b; p++)
                                        Console.Write(B[p] + " ");
                                    break;
                                }
                                if (b == j)
                                {
                                    for (int p = i; p < a; p++)
                                        Console.Write(A[p] + " ");
                                    break;
                                }
                                int xi = 0, xj = 0;
                                for (int hj = j; j < b;)
                                {
                                    if (B[j] < A[i])
                                    {
                                        Console.Write(B[j] + " ");
                                        xj += 1;
                                    }
                                    if (B[j] == A[i])
                                    {
                                        Console.Write(B[j] + " ");
                                        xj += 1;
                                        xi += 1;
                                    }
                                    break;
                                }
                                if (A[i] < B[j])
                                {
                                    Console.Write(A[i] + " ");
                                    xi += 1;
                                }
                                i += xi;
                                j += xj;
                            }
                            break;
                        }
                        else
                        {
                            int i = 0;
                            for (j = 0; j < b;)
                            {
                                if (a == i)
                                {
                                    for (int p = j; p < b; p++)
                                        Console.Write(B[p] + " ");
                                    break;
                                }
                                if (b == j)
                                {
                                    for (int p = i; p < a; p++)
                                        Console.Write(A[p] + " ");
                                    break;
                                }
                                int xi = 0, xj = 0;
                                for (int hi = i; i < b;)
                                {
                                    if (B[j] < A[i])
                                    {
                                        Console.Write(B[j] + " ");
                                        xj += 1;
                                    }
                                    if (B[j] == A[i])
                                    {
                                        Console.Write(B[j] + " ");
                                        xj += 1;
                                        xi += 1;
                                    }
                                    break;
                                }
                                if (A[i] < B[j])
                                {
                                    Console.Write(A[i] + " ");
                                    xi += 1;
                                }
                                i += xi;
                                j += xj;
                            }
                            break;
                        }
                    }
                case 2:
                    {
                        int j = 0;
                        for (int i = 0; i < a;)
                        {
                            if (a == i)
                            {
                                i -= 1;
                            }
                            if (b == j)
                            {
                                j -= 1;
                            }
                            int xi = 0, xj = 0;
                            for (int hj = j; j < b;)
                            {
                                if (B[j] < A[i])
                                {
                                    xj += 1;
                                }
                                if (B[j] == A[i])
                                {
                                    Console.Write(B[j] + " ");
                                    xj += 1;
                                    xi += 1;
                                }
                                break;
                            }
                            if (A[i] < B[j])
                            {
                                
                                xi += 1;
                            }
                            i += xi;
                            j += xj;
                        }
                        break;
                    }
                case 3:
                    {
                        int g = 0;
                        int c = 0;
                        for (int j = 0; j < b;)
                        {
                            if (A[g] < B[j])
                            {
                                Console.WriteLine("Массив А не является подмножеством массива В");
                                return 0;
                            }
                            if (A[g] == B[j])
                            {
                                g++;
                                j++;
                                c++;

                            }
                            else
                                j++;

                            if (c == a)
                            {
                                Console.WriteLine("Подмножество А является множеством В");
                                return 0;
                            }
                        }


                        Console.WriteLine("Подмножество А не является подмножеством В");
                        return 0;
                    }
            }
            return 0;
        }
    }
}
