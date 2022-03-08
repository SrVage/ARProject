using UnityEngine;

namespace Code
{
    public class UnitManager:MonoBehaviour
    {
        public static UnitController Player, Enemy;

        public void SetTargetPlayer(UnitController player)
        {
            Player = player;
        }

        public void SetTargetEnemy(UnitController enemy)
        {
            Enemy = enemy;
        }

        public void SetNullTarget()
        {
            Player = null;
        }

        public void SetNullEnemy()
        {
            Enemy = null;
        }
    }
}