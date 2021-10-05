using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{
    public bool isPlayer = false;
    public float maxHealth;
    public Text healthText;
    public Image healthBar;
    public Image blood;
    private float health;
    private float originalHealthBarWidth;
    private float timePassed = 0;
    private float timeToPass = 1f;
    private bool tookDamage = false;

    private void Start()
    {
        health = maxHealth;
        originalHealthBarWidth = healthBar.rectTransform.sizeDelta.x;
    }
    private void Update()
    {
        UpdateHealthBar();
        if (isPlayer && health <= 0)
            SceneManager.LoadScene(0);
        if(isPlayer && tookDamage)
        {
            if (blood == null)
                return;

            blood.enabled = true;
            if(timePassed >= timeToPass)
            {
                blood.enabled = false;
                tookDamage = false;
            } else
            {
                timePassed += Time.deltaTime;
            }
        }
    }
    public void TakeDamage(int damage, GameObject attacker)
    {
        if (attacker.gameObject.tag == this.gameObject.tag)
            damage = 1;
        health -= damage;
        if (health < 0)
            health = 0;

        if (isPlayer)
            DamageIndicator();
        else if(health <= 0)
        {
            this.gameObject.SetActive(false);
        }
    }
    public void Heal(int value)
    {
        health += value;
        if (health > maxHealth)
            health = maxHealth;
    }
    private void UpdateHealthBar()
    {
        healthBar.rectTransform.sizeDelta = new Vector2(originalHealthBarWidth * (health / maxHealth), healthBar.rectTransform.sizeDelta.y);
        healthText.text = health + " / " + maxHealth;
    }
    private void DamageIndicator()
    {
        timePassed = 0;
        if (tookDamage)
        {
            return;
        } else
        {
            tookDamage = true;
        }
    }
}
