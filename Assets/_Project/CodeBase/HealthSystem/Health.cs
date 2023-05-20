using System;

namespace CodeBase.HealthSystem
{
    public abstract class Health : IHealth
    {
        protected int _healthValue;

        public int HealthValue
        {
            get { return _healthValue; }

            private set
            {
                if (value <= 0)
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

        public Health(int healthValue) => _healthValue = healthValue;

        public virtual void TakeDamage(int damage) => HealthValue -= damage;
    }
}

