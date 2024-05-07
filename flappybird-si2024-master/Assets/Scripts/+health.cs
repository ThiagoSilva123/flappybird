using UnityEngine;

public class IncreaseMaxHealthPowerUp : MonoBehaviour
{
    public int healthIncreaseAmount = 10; 

    private void OnTriggerEnter2D(Collider2D other)
    {
      
        if (other.CompareTag("Player"))
        {
            Health playerHealth = other.GetComponent<Health>();
            
            if (playerHealth != null)
            {
                playerHealth.maxHealth += healthIncreaseAmount;


                Destroy(gameObject);
            }
        }
    }
}
