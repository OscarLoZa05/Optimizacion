using UnityEngine;
using UnityEngine.InputSystem;

public class BulletShoot : MonoBehaviour
{
    private InputAction _attackInput;
    [SerializeField] private Transform _bulletSpawn;


    void Awake()
    {
        _attackInput = InputSystem.actions["Attack"];
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        if(_attackInput.WasPerformedThisFrame())
        {
            Debug.Log("Ataque");
            Attack();
        }
    }

    void Attack()
    {
        GameObject bullet = PoolManager.Instance.GetPooledObject("Bullets", _bulletSpawn.position, _bulletSpawn.rotation);
        bullet.SetActive(true);
    }
}