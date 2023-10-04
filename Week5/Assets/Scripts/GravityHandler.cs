using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityHandler : MonoBehaviour
{
    public float gravityStrength;
    void Start()
    {
        Physics.gravity = new Vector3(0f, -gravityStrength, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
