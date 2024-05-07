using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float queueTime = 1.5f;
    private float time = 0;
    public List<GameObject> obstacles; 
    public float height;

    void Update()
    {
        if (time > queueTime)
        {
            int index = Random.Range(0, obstacles.Count);
            GameObject go = Instantiate(obstacles[index]);
            go.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            time = 0;
            Destroy(go, 10); 
        }
        time += Time.deltaTime;
    }
}
