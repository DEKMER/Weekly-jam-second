using UnityEngine;

public class GalagaProjectile : MonoBehaviour
{
    public float Speed;
    int DeathTime = 200;
    void FixedUpdate()
    {
        transform.Translate(Vector2.up * Speed);
        DeathTime--;
        if (DeathTime <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (gameObject.tag == "PP" && other.tag == "Enemy")
        {
            other.gameObject.GetComponent<GalagaEnemy>().EnemigosCountMinus();
            other.gameObject.SetActive(false);
            Destroy(gameObject);
        }
        if (gameObject.tag == "EP" && other.tag == "Player")
        {
            other.gameObject.GetComponent<Galaga>().Health -= 1;
            Destroy(gameObject);
        }
    }
}
