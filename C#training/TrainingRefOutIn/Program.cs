namespace TrainingRefOutIn
{
    internal class Program
    {
        public enum State
        { 
            Idle,
            Patrolling,
            Attacking,
        }
                
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Unit unit = new Unit(); 
            State state = State.Idle;   // ref requires pre-initialization
            
            unit.GetUnitState(ref state, out int healthAmount);
            Console.WriteLine(healthAmount);
        }

        public class Unit
        {
            public void GetUnitState(ref State state, out int healthAmount)   //in int anInRef
            {
                healthAmount = 58;  // out param MUST be set inside method, but NOT ref
                state = State.Idle;
                //anInRef = 0; // in creates a ref readonly param, so cannot set here
            }
        }
    }
}
