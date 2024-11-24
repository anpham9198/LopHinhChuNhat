using LopHinhChuNhat;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap chieu rong");
        float width= float.Parse(Console.ReadLine());
        Console.WriteLine("Nhap chieu dai");
        float height= float.Parse(Console.ReadLine());
        Rectangle rectangle= new Rectangle(width,height);
        rectangle.Show();
        Console.WriteLine("Gia tri gap doi cua dien tich la {0}",rectangle.GetArea() * 2);

    }
}