using System;
namespace ConsoleApplication1.ASM6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] RateList = {1, 2, 3};
                        New program = new New(121, "Cô gái đến từ hôm qua", "05/03/2019", "Nguyễn Nhật Ánh", "Đọc là biết",RateList);
                        program.Calculate();
                        program.Display();
        }
    }
}