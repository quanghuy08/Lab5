﻿using System;

namespace ExHandling1
{
    internal class Vidu1
    {
        public static void Main(string[] args)
        {
            byte[] a = new byte[5];

            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine("a[{0}]=", 1 + 1);
                    a[i] = Convert.ToByte(Console.ReadLine());
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine(" khong duoc nhap ki tu cho mang so");

            }
            catch (OverflowException ex)
            {
                Console.WriteLine("khong duoc nhac nhap gia tri nam ngoai mien 0-255");
            }

            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Loi vuot qua pham vi cua mang");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.Write(" {0} ", a[i]);
            }
        }
    }
}