using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }

    private int score = 0; 
    public Text scoreText; 

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        StartCoroutine(IncrementScoreRoutine());
    }

    private System.Collections.IEnumerator IncrementScoreRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f); 
            AddScore(1); 
        }
    }

    public void AddScore(int amount)
    {
        score += amount; 
        UpdateScoreUI(); 
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString(); 
        }
    }
}
