using System;
using UnityEngine;
using UnityEngine.Events;

namespace Code
{
    public class Combat:MonoBehaviour
    {
        [SerializeField] private int _damage = 1;
        [SerializeField] private float _cooldown = 1f;
        private float _cooldownTimer;
        public UnityEvent OnAttack;

        private void Update()
        {
            if (_cooldownTimer > 0)
            {
                _cooldownTimer -= Time.deltaTime;
            }
        }

        public void Attack(Health health)
        {
            if (_cooldownTimer <= 0)
            {
                OnAttack.Invoke();
                health.TakeDamage(_damage);
                _cooldownTimer = _cooldown;
            }
        }
    }
}