using Unity.VisualScripting;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{

    private int _bulletVel = 10;
    private Rigidbody _rigiBody;
    private Vector3 _bulletDirection = new Vector3(0, -1, 0);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Awake()
    {
        _rigiBody = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Movement();
    }
    void OnBecameInvisible()
    {
        Debug.Log("Bullet invisible");
        gameObject.SetActive(false);
    }

    void Movement()
    {
        _rigiBody.linearVelocity = _bulletDirection * _bulletVel;
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Player")
        {
            Debug.Log("Te han matado");
            Destroy(collider.transform.gameObject);
            gameObject.SetActive(false);
        }
    }
}
