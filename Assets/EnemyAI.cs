using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Vector3 movement;
    public int damage;

    private void Update()
    {
        Move();
    }
    private void Move()
    {
        this.transform.Translate(movement*Time.deltaTime, Space.World);
    }
    private void OnCollisionEnter(Collision collision)
    {
        movement = movement * -1;
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<HealthSystem>().TakeDamage(damage, this.gameObject);
            this.gameObject.GetComponent<HealthSystem>().TakeDamage(damage, collision.gameObject);
        }
    }
}
