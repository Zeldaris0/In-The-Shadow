using UnityEngine;

public class Rotation : MonoBehaviour
{
    Rigidbody rb;
    Transform c;
    string tag_g;
    
    [SerializeField]float Rotspeed = 2f;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        c = GetComponent<Transform>();
        tag_g = gameObject.tag;
    }

    void FixedUpdate() {
        if (Input.GetMouseButton(0))
        {
            if (Input.GetKey(KeyCode.Z))
            {
                if (tag_g == "top")
                {
                    rotatio_manager();
                }
            }
            else if (tag_g != "top")
            {
                rotatio_manager();
            }
        }
    }

    void rotatio_manager()
    {
        float x = Input.GetAxis("Mouse X") *  Rotspeed * Time.fixedDeltaTime;
        float y = Input.GetAxis("Mouse Y") *  Rotspeed * Time.fixedDeltaTime;

        rb.AddTorque (Vector3.down * x);
        rb.AddTorque (Vector3.right * y);
    }

    void OnCollisionEnter(Collision collision)
    {
        Physics.IgnoreCollision(collision.collider, GetComponent<Collider>());
    }
}
