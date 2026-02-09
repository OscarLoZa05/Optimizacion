using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    private Rigidbody _rigiBody;

    private int enemyVel = 5;
    private Vector3 enemyDirection = new Vector3(0, -1, 0);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        _rigiBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Movement()
    {
        _rigiBody.linearVelocity = enemyDirection * enemyVel;
    }
}
