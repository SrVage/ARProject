using System;
using UnityEngine;

namespace Code
{
    public class Health:MonoBehaviour
    {
        [SerializeField] private int _maxValue;
        private int _currentValue;
        public int CurrentValue => _currentValue;
        public event Action Dead;

        private void Start()
        {
            _currentValue = _maxValue;
        }

        public void TakeDamage(int damage)
        {
            if (_currentValue > 0)
            {
                _currentValue -= damage;
                if (_currentValue <= 0)
                {
                    _currentValue = 0;
                    Dead?.Invoke();
                }
            }
        }
    }
}