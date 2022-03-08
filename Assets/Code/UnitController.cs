using System;
using UnityEngine;

namespace Code
{
    public class UnitController:MonoBehaviour
    {
        [SerializeField] protected Combat _combat;
        public Health Health;
        protected bool _isDead = false;

        private void Start()
        {
            Health.Dead += Dead;
        }

        protected virtual void Update()
        {
            
        }

        protected virtual void Dead()
        {
            _isDead = true;
        }
    }
}