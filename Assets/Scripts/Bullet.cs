using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 10f;
    public int damage = 1;

    private void Update()
    {
        // Movimento da bala
        transform.Translate(Vector2.right * bulletSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifica se colidiu com um objeto inimigo
        //if (collision.CompareTag("Enemy"))
        {
            // Chama uma função para aplicar dano ao inimigo
            //collision.GetComponent<Enemy>().TakeDamage(damage);
            
            // Destroi a bala
            //Destroy(gameObject);
        }
    }
}
