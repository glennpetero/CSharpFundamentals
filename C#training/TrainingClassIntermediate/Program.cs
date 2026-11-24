namespace TrainingClassIntermediate
{
    internal class Program
    {
        
        // polymorphism allows different classes to share a common interface or base type but 
        //  provide their own implentation of that class/method
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Player player = new Player();
            Enemy enemy = new Enemy();

            Console.WriteLine(enemy);


            Unit unit2 = enemy;
            unit2.Attack();

            List<Unit> unitList = new List<Unit> 
            { 
                unit2,
                player,
                enemy
            };            
        }

        public class Player : Unit
        {
            public Player()
            {
                speed = 5;
                Move();
            }

            protected override void Move()
            {
                Console.WriteLine("Move Player");
            }

            public override void Attack()
            {
                throw new NotImplementedException();
            }
        }

        public class Enemy : Unit 
        {
            public Enemy()
            {
                speed = 5;
                Move();
            }

            // Destructor method
            ~Enemy()
            {
                Console.WriteLine("Enemy destrcuted");
            }

            protected override void Move()
            {
                Console.WriteLine("Move Enemy");
            }

            public override string ToString()  // overriding base class virtual method
            {
                return "I am an Enemy";
            }

            public override void Attack()
            {
                Console.WriteLine("Enemy Attack!");
            }
        }


        // base class to inherit
        public abstract class Unit
        {
            protected float speed;  // this class and any class that inherits/extends it can have access

            protected virtual void Move()  // this method is now overridable with virtual keyword
            { 
                Console.WriteLine("Move Unit");
            }

            public abstract void Attack();
        }



        // NOTE: abstract class cannot be directly instantiated

        // abstract method HAS to be defined by inherited class
        // virtual method offers base implementation and can be overridden by inherited class
        // sealed class cannot be extended/inherited    method/property cannot be overriden

    }
}
