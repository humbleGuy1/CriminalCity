using System;

namespace CodeBase.Player.Health
{
    public class PlayerHealth : IHealth
    {
        private int _healthValue;

        public int HealthValue
        {
            get { return _healthValue; }

            private set 
            {
                if(value <= 0)
                {
                    _healthValue = 0;
                    ReachedZero?.Invoke();
                }
                else
                {
                    _healthValue = value;
                }
            }
        }
           
        public event Action ReachedZero;

        public PlayerHealth(int healthValue)
        {
            _healthValue = healthValue;
        }

        public void TakeDamage(int damage)
        {
            HealthValue -= damage;
        }
    }
}

