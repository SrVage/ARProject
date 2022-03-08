using UnityEngine;

namespace Code
{
    public class EnemyController:UnitController
    {
        protected override void Update()
        {
            base.Update();
            if (!_isDead && UnitManager.Player.Health != null)
            {
                transform.LookAt(UnitManager.Player.transform);
                if (Vector3.Distance(transform.position, UnitManager.Player.transform.position)<5)
                    _combat.Attack(UnitManager.Player.Health);
            }
        }

        protected override void Dead()
        {
            base.Dead();
            UnitManager.Enemy = null;
        }
    }
}