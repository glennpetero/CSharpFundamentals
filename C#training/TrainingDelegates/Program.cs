namespace TrainingDelegates
{
    internal class Program
    {
        // Delegates: let you store a function as a variable or a parameter        
        
        private delegate void AttackDelegate();  // delegate reference
        private static AttackDelegate attackAction;

        private static Action<int> myAction;  // built-in C# delegate, void return
        private static Func<int> myFunction; // built-in C# delegate, returns the <T> type specified

        // anonymous function (lambda)
        private static Action myAnonymousAction = () =>   // no params like myAction
        {
            Console.WriteLine("Attack!");
        };

        private static Action<int> myOtherAnonymousAction = (int i) =>
        {
            Console.WriteLine($"Attack {i} times!");
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            attackAction = DoAttack;  // assign it
            attackAction();           // now call it
            attackAction += RangeAttack;  // add another method to the delegate
            attackAction();
            attackAction -= RangeAttack;  // now remove the method from the delegate
            attackAction();

            myFunction = MyTestFunction;
            Console.WriteLine(myFunction());

            myAnonymousAction();
            myOtherAnonymousAction(1);
        }

        private static void DoAttack()   // this method signature MUST match the AttackDelegate signature
        {
            Console.WriteLine("Attack!");
        }

        private static void RangeAttack()   
        {
            Console.WriteLine("Range!");
        }

        private static int MyTestFunction()
        {
            return 1;
        }
    }
}
