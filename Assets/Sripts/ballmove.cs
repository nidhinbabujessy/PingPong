using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ballmove : MonoBehaviour
{
    public Vector3 initialImpulse;
    public Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
     
    rigidbody.AddForce(initialImpulse,ForceMode.Impulse);
    }
    
    
}