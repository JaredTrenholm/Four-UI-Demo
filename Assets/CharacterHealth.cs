using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterHealth : MonoBehaviour
{
    public float maxHealth;
    public Text healthText;
    public Image healthBar;
    private float health;

    private void Start()
    {
        health = maxHealth;
    }
    private void Update()
    {
        UpdateHealthBar();
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health < 0)
            health = 0;
    }
    public void Heal(int value)
    {
        health += value;
        if (health > maxHealth)
            health = maxHealth;
    }
    private void UpdateHealthBar()
    {
        healthBar.transform.localScale = new Vector3(health / maxHealth, 1, 1);
        healthText.text = health + " / " + maxHealth;
    }
}
