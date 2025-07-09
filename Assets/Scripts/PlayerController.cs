using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 3.0f;
    public float rotationSpeed = 90.0f;

    public float mouseSensitivity = 5.0f;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        rb = GetComponent<Rigidbody>(); // Access player's Rigidbody.
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = moveVertical * speed * Time.fixedDeltaTime * transform.forward;


        rb.MovePosition(rb.position + movement);

        // Rotate player based on horizontal input.
        float turn = Input.GetAxis("Horizontal") * rotationSpeed * Time.fixedDeltaTime;
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);

        // if (Input.GetMouseButton(0))
        // {
        //     transform.Rotate(Vector3.up, Input.GetAxis("Mouse X") * mouseSensitivity, Space.World);
        //     transform.Rotate(Vector3.right, -Input.GetAxis("Mouse Y") * mouseSensitivity, Space.Self);
            
        // }

    }
}
