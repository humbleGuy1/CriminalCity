using System;

namespace CodeBase.HealthSystem
{
    public interface IHealth
    {
        public event Action ReachedZero;

        public void TakeDamage(int damage);
    }
}

