using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class Health : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public Text healthText; 
    public Text gameOverText;
    void Start()
    {
        health = maxHealth; 
        UpdateHealthUI();
        HideGameOverText();
    }

    void Update()
    {
      
        if (health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        UpdateHealthUI();
    }

    void UpdateHealthUI()
    {
        if (healthText != null)
        {
            healthText.text = "Health: " + health.ToString();
        }
    }

    void ShowGameOverText()
    {
        if (gameOverText != null)
        {
            gameOverText.gameObject.SetActive(true);
        }
    }

    void HideGameOverText()
    {
        if (gameOverText != null)
        {
            gameOverText.gameObject.SetActive(false);
        }
    }
}
