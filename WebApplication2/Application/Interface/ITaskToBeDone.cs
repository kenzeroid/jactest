namespace WebApplication2.Application.Interface
{
    public interface ITaskToBeDone
    {
        public string DetermineTriangale(float side1, float side2, float side3);
        public string Fibonacci(int element);
        public string WordReverse(string? word);
        public string WordHash(string? word);
    }
}
