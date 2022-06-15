using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_rota : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]float Rotspeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            if (Input.GetKey(KeyCode.Q))
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
}
