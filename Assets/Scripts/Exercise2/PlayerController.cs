using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exercise2
{
    public class PlayerController : MonoBehaviour
    {
        private Weapon equippedWeapon;

        public void SetWeapon(Weapon weapon)
        {
            equippedWeapon = weapon;
        }

        void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                equippedWeapon.Attack();
            }
        }
    }
}

