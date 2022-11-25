using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private const float MAX_HEALTH = 100f;

    private Image healthBar;

    public HealthBar(float health)
    {
        healthBar = GameObject.FindWithTag("HealthBar").GetComponent<Image>();
    }

    public void OnHealthtChange(float health)
    {
       healthBar.fillAmount = health / MAX_HEALTH;
    }
}
