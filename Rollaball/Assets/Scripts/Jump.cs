using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public float jump_force = 10;
    public GameObject ground;
    Rigidbody rb;
    private int jumpcount;
    
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        jumpcount =2;    

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") && jumpcount > 0)
            {
                rb.AddForce(Vector3.up*jump_force, ForceMode.Impulse);
                jumpcount--;
            }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("JumpReset"))
        {
            jumpcount = 2;
        }
        
    }
}
