namespace TrainingNullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int i = null;

            int? j = null;
            Console.WriteLine(j.GetValueOrDefault(12));
            if (j.HasValue)
            {
                int attackDamage = j.Value;
            }

            int? a = null;
            int b = a ?? 58;  // a is null, so sets to 58



            // or can do nullable explicitly:
            Nullable<int> k = null;

        }
    }
}
