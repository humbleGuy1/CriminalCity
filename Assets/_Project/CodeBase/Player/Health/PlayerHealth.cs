using CodeBase.HealthSystem;

namespace CodeBase.Player
{
    public class PlayerHealth : Health
    {
        public PlayerHealth(int healthValue) : base(healthValue) => _healthValue = healthValue;

        public override void TakeDamage(int damage)
        {
            base.TakeDamage(damage);
        }
    }
}

