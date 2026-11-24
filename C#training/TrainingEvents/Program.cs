namespace TrainingEvents
{
    internal class Program
    {       
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Events: how to have one class be notified when something happens
            // the class that publishes the Event is completely decoupled from the class(es) that
            // subscribe to that Event!  :) 

            Player player1 = new Player();
            PlayerHealthBar playerHealthBar = new PlayerHealthBar(player1);
            
            player1.Damage();
        }

        private class Player
        {
            public event Action OnPlayerDamaged;   // Action delegate can be used

            public void Damage()
            {
                if (OnPlayerDamaged != null)
                {
                    OnPlayerDamaged();
                }                
            }
        }

        private class Enemy
        {
            public class OnEnemyDamagedEventArgs : EventArgs
            {
                public int previousHealth;
            }
            public event EventHandler<OnEnemyDamagedEventArgs> OnEnemyDamaged;  // But EventHandler is common C# usage

            public void Damage()
            {
                if (OnEnemyDamaged != null)
                {
                    OnEnemyDamaged(this, new OnEnemyDamagedEventArgs
                    {
                        previousHealth = 56,
                    });
                }
            }
        }

        private class PlayerHealthBar : IDisposable
        {            
            private int playerHealth;
            private readonly Player _player;
            
            public PlayerHealthBar(Player player)
            {
                _player = player;
                playerHealth = 100;
                player.OnPlayerDamaged += Player_OnPlayerDamaged;
                Console.WriteLine($"Player {playerHealth}");
            }

            public void Dispose() 
            {
                if (_player != null)
                {
                    _player.OnPlayerDamaged -= Player_OnPlayerDamaged;
                    Console.WriteLine($"Player destroyed!");
                }                
            }

            private void Player_OnPlayerDamaged()
            {
                playerHealth -= 10;
                Console.WriteLine($"Player {playerHealth}");
            }
        }
    }
}
