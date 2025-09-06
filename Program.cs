namespace PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter a number: ");
            string answer = !int.TryParse(Console.ReadLine(), out n) ? "Error" : PrimeNum(n) ? "Your number is prime" : "Your number is composite";
            Console.WriteLine(answer);
        }
        public static bool PrimeNum(int n)
        {
            if(n==2) return true;
            int sqrt=(int)Math.Sqrt(n);
            for(int i=2;i<=sqrt+1;++i)
            {
                if(n%i==0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
