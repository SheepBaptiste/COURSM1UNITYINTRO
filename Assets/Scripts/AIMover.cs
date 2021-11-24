using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMover : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform player;
    public void Start()
    {
      GameObject goplayer = GameObject.FindGameObjectWithTag("Player");
      player = goplayer.transform;
     }
     
    // Update is called once per frame
    void Update()
    {
        
    }
    [Tooltip("vitesse de déplacement"), Range(0,15)]
    public float linearSpeed = 6;
    [Tooltip("vitesse de déplacement")]
    public float angularSpeed = 1;

    
    
    void FixedUpdate()
    {
       Rigidbody rb =  GetComponent<Rigidbody>();
        if (rb != null)
        {

            if (rb.angularVelocity.magnitude < angularSpeed)
            { 

                rb.AddTorque(transform.up * -angularSpeed);
             }
            
            
            
            
            
            
            
            
            
            
            //if(rb.velocity.magnitude < 5)
            if (Input.GetButton("Fire1") && rb.velocity.magnitude < linearSpeed)
            {
                rb.AddForce(transform.forward * 30);
            }

            if (Input.GetButton("Fire2") && rb.angularVelocity.magnitude < angularSpeed)
            {
                Debug.Log("Coucou");
                rb.AddTorque(transform.up * 30);
            }
       }
        Animator anim = GetComponent<Animator>();
        if(anim != null)
        {
            anim.SetFloat("Speed", rb.velocity.magnitude);
        }





;    }
}
