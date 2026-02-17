using UnityEngine;

public class EnemiesPool : MonoBehaviour
{

    private float shootTime = 5f;
    public float shootTimer;
    private bool canShoot = false;

    [SerializeField] private Transform _enemySpawns;
    [SerializeField] private Transform _enemySpawns1;
    [SerializeField] private Transform _enemySpawns2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shootTimer = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }

    void Timer()
    {
        shootTimer += Time.deltaTime;

        if (shootTimer > shootTime)
        {
            canShoot = true;
            shootTimer = 0f;
            SpawnEnemy();
            return;
        }
    }

    void SpawnEnemy()
    {
        GameObject enemy = PoolManager.Instance.GetPooledObject("Enemies0", _enemySpawns.position, _enemySpawns.rotation);
        enemy.SetActive(true);
        GameObject enemy1 = PoolManager.Instance.GetPooledObject("Enemies1", _enemySpawns1.position, _enemySpawns1.rotation);
        enemy1.SetActive(true);
        GameObject enemy2 = PoolManager.Instance.GetPooledObject("Enemies2", _enemySpawns2.position, _enemySpawns2.rotation);
        enemy2.SetActive(true);
        return;
    }
}
