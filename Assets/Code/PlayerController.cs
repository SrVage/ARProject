using System.Runtime.InteropServices;
using UnityEngine;
using Vuforia;

namespace Code
{
    public class PlayerController:UnitController
    {
        public Transform _virtualButton;

        private void Start()
        {
            _virtualButton = gameObject.transform.parent;
            _virtualButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
            _virtualButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        }

        protected override void Update()
        {
            base.Update();
            if (!_isDead && UnitManager.Enemy != null)
            {
                transform.LookAt(UnitManager.Enemy.transform);
            }
        }

        private void OnButtonReleased(VirtualButtonBehaviour obj)
        {
            
        }

        private void OnButtonPressed(VirtualButtonBehaviour obj)
        {
            if (!_isDead && UnitManager.Enemy!=null)
            {
                if (Vector3.Distance(transform.position, UnitManager.Enemy.transform.position)<5)
                    _combat.Attack(UnitManager.Enemy.Health);
            }
        }

        protected override void Dead()
        {
            base.Dead();
            UnitManager.Player = null;
        }
    }
}