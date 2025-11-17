using UnityEngine;

public class TiroInimigo : MonoBehaviour
{
    public Transform player;          // referência do player
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 10f;

    public float fireRate = 1f;       // tiros por segundo
    private float nextFireTime = 0f;

    void Update()
    {
        if (player == null) return;

        // Faz o inimigo "olhar" para o jogador (2D e 3D)
        LookAtPlayer();

        // Atirar
        if (Time.time >= nextFireTime)
        {
            Shoot();
            nextFireTime = Time.time + 1f / fireRate;
        }
    }

    void LookAtPlayer()
    {
        // Para jogos 3D
        transform.LookAt(player);

        // Para jogos 2D, pivoteia olhando apenas no plano XY:
        // Vector2 direction = player.position - transform.position;
        // float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        // transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // 3D
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.linearVelocity = firePoint.forward * bulletSpeed;
        }

        // 2D
        Rigidbody2D rb2d = bullet.GetComponent<Rigidbody2D>();
        if (rb2d != null)
        {
            Vector2 dir = (player.position - firePoint.position).normalized;
            rb2d.linearVelocity = dir * bulletSpeed;
        }
    }
}