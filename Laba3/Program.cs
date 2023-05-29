namespace NormExample
{
    public abstract class Norm
    {
        public virtual double CalculateNorm()
        {
            throw new NotImplementedException();
        }
        public virtual double CalculateModule()
        {
            throw new NotImplementedException();
        }
    }
    public class Complex : Norm
    {
        private double a, b;
        public Complex(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public override double CalculateNorm()
        {
            return a * a + b * b;
        }
        public override double CalculateModule()
        {
            return Math.Sqrt(a * a + b * b);
        }
    }
    public class Vector3D : Norm
    {
        private double x, y, z;
        public Vector3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public override double CalculateNorm()
        {
            return Math.Max(Math.Max(Math.Abs(x), Math.Abs(y)), Math.Abs(z));
        }
        public override double CalculateModule()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(2, 3);
            Vector3D v1 = new Vector3D(3, -4, 5);
            Console.WriteLine("c1.Norm = " + c1.CalculateNorm());
            Console.WriteLine("c1.Module = " + c1.CalculateModule());
            Console.WriteLine("v1.Norm = " + v1.CalculateNorm());
            Console.WriteLine("v1.Module = " + v1.CalculateModule());
            Console.ReadKey();
        }
    }
}