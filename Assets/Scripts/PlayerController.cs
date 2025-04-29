using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // public variables are always capitalised
    public float Speed = 1;
    private Vector2 movement;
    public Rigidbody rigidbody;

    private void Awake()
    {
        // This is called when the script instance is being loaded
        // You can use this to initialize variables or set up references
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    private void FixedUpdate()
    {
        Vector3 move = new Vector3(movement.x, 0, movement.y);
        rigidbody.AddForce(move * Time.fixedDeltaTime * Speed);
    }

    private void LateUpdate()
    {

    }

    private void OnMove(InputValue input)
    {
        movement = input.Get<Vector2>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("item1")){
            other.gameObject.SetActive(false);
        }
    }
}
