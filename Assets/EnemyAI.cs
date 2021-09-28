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
        Debug.Log(collision.gameObject.tag + "/" + (collision.gameObject.tag == "Player"));
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<HealthSystem>().TakeDamage(damage);
        }
    }
}
