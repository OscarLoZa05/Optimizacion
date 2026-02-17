using UnityEngine;
using UnityEngine.InputSystem;

public class ShipMovement : MonoBehaviour
{

    //Input
    private InputAction _moveInput;
    public Vector2 _moveAction;

    //Movement
    private Rigidbody _rigiBody;
    private int _speed = 40;
    private Vector3 minPosition = new Vector3(-16, -3 ,0);
    private Vector3 maxPosition = new Vector3(16, 50, 0);


    void Awake()
    {
        _moveInput = InputSystem.actions["Move"];

        _rigiBody = GetComponent<Rigidbody>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _moveAction = _moveInput.ReadValue<Vector2>();

        Movement();
    }

    void FixedUpdate()
    {
        float clampX = Mathf.Clamp(transform.position.x, minPosition.x, maxPosition.x);
        float clampY = Mathf.Clamp(transform.position.y, minPosition.y, maxPosition.y);
        transform.position = new Vector3(clampX, clampY, 0);
    }

    void Movement()
    {
        _rigiBody.linearVelocity = _moveAction * _speed;
    }


}
