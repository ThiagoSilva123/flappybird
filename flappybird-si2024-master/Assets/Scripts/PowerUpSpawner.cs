using UnityEngine;

public class PowerUpSpawner : MonoBehaviour
{
    public GameObject powerUpPrefab1; 
    public GameObject powerUpPrefab2; 
    public GameObject powerUpPrefab3; 

    public float spawnInterval = 10f; 
    public float spawnHeight = 2f; 

    private float timer; 

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            timer = 0f;

            SpawnPowerUp();
        }
    }

    void SpawnPowerUp()
    {
        Debug.Log("Spawnando power-up...");

        GameObject selectedPrefab = GetRandomPrefab();
        if (selectedPrefab != null)
        {
            Debug.Log("Prefab selecionado: " + selectedPrefab.name);

            GameObject newPowerUp = Instantiate(selectedPrefab, transform.position + Vector3.up * Random.Range(-spawnHeight, spawnHeight), Quaternion.identity);

            Destroy(newPowerUp, 10f);
        }
        else
        {
            Debug.LogWarning("Nenhum prefab de power-up atribuído!");
        }
    }

    GameObject GetRandomPrefab()
    {
        int randomIndex = Random.Range(1, 4);

        switch (randomIndex)
        {
            case 1:
                return powerUpPrefab1;
            case 2:
                return powerUpPrefab2;
            default:
                return powerUpPrefab3;
        }
    }
}
