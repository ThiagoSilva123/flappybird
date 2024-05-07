using UnityEngine;

public class ScoreIncreasePowerUp : MonoBehaviour
{
    public int scoreIncreaseAmount = 100; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.Instance.AddScore(scoreIncreaseAmount);

            Destroy(gameObject);
        }
    }
}
