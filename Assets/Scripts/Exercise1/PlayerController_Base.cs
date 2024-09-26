using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Exercise1
{
    public class PlayerController_Base : MonoBehaviour
    {
        public float speed;
        public float health;


        void Update()
        {
            Move();
            Attack();
        }

        void Move()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            transform.Translate(new Vector3(horizontal, vertical, 0) * speed * Time.deltaTime);
        }

        void Attack()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Debug.Log("Attacking!");
            }
        }

        public void TakeDamage(float damage)
        {
            health -= damage;
            if (health <= 0) Debug.Log("Player Died");
        }
    }
}
