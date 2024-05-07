using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void StartGame()
    {
        Time.timeScale = 1; 
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Reinicia a cena atual
    }

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
