using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    private Rigidbody _rigiBody;

    private int enemyVel = 3;
    private Vector3 _enemyDirection = new Vector3(0, -1, 0);
    private float shootTime = 5f;
    public float shootTimer;
    private bool canShoot = false;

    [SerializeField] private Transform _spawnBullet;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        _rigiBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       TimerShoot(); 
    }

    void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        _rigiBody.linearVelocity = _enemyDirection * enemyVel;
    }

    void TimerShoot()
    {
        shootTimer += Time.deltaTime;

        if (shootTimer > shootTime)
        {
            canShoot = true;
            shootTimer = 0f;
            Shoot();
            return;
        }
    }

    void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }

    void Shoot()
    {
        if(canShoot == true)
        {
            canShoot = false;
            GameObject bullet = PoolManager.Instance.GetPooledObject("EnemyBullet", _spawnBullet.position, _spawnBullet.rotation);
            bullet.SetActive(true);
            return;
        }
    }
}
