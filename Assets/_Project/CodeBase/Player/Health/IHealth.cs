using System;

namespace CodeBase.Player.Health
{
    public interface IHealth
    {
        public event Action ReachedZero;

        public void TakeDamage(int damage);
    }
}

