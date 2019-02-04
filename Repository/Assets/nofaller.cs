using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nofaller : MonoBehaviour
{
    Rigidbody rB;

    // Start is called before the first frame update
    void Start()
    {
        rB = GetComponent<Rigidbody>();

        rB.constraints = RigidbodyConstraints.FreezePosition;
    }

    // Update is called once per frame
    void Update()
    {
        rB.angularVelocity = new Vector3(100, 50, 30);
    }
}
