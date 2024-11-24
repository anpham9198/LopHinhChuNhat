namespace LopHinhChuNhat
{
    public class Rectangle
    {
        float width = 0;

        float height = 0;

        public Rectangle(float width, float height)
        {
            this.width = width;
            this.height = height;
        }

        public float GetArea()
        {
            return width * height;
        }

        public float GetPrimeter()
        {
            return (width + height) * 2;
        }

        public void Show()
        {
            Console.WriteLine("Chieu dai va chieu rong la {0}{1}", width, height);
            Console.WriteLine("Dien tich la {0}", GetArea());
            Console.WriteLine("Chu vi la {0}", GetPrimeter());
        }
    }
}
