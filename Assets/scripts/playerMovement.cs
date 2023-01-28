using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody Rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 25f;

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        Rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d") )
        {
            Rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a") )
        {
            Rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Rb.position.y <-1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
