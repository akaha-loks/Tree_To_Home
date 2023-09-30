using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{
    Image healthBar;
    public float maxHealth = 100f;
    
    public HealthSystem pl;

    private void Start()
    {
        healthBar = GetComponent<Image>();
        pl.HP = maxHealth;
    }

    private void Update()
    {
        healthBar.fillAmount = pl.HP / maxHealth;
        if (healthBar.fillAmount <= 0f)
        {
            SceneManager.LoadScene(0);
        }
    }
}
