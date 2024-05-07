using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 1f;
    public float damage = 10f; 

    private void Update()
    {
        transform.position += speed * Time.deltaTime * Vector3.left;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Health playerHealth = collision.gameObject.GetComponent<Health>();
            if (playerHealth != null)
            {
                playerHealth.TakeDamage(damage);
            }
        }
    }
}
