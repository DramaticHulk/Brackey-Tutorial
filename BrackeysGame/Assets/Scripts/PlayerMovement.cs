using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 2000f;
    public float sidewaysMovement = 500f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rb.AddForce(0, 0, moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(sidewaysMovement * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-sidewaysMovement * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y <= -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
