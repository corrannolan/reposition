using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nofaller : MonoBehaviour
{
    Rigidbody rB;

    float ran1, ran2, ran3;

    // Start is called before the first frame update
    void Start()
    {
        rB = GetComponent<Rigidbody>();

        rB.constraints = RigidbodyConstraints.FreezePosition;
    }

    // Update is called once per frame
    void Update()
    {
        ran1 = Random.Range(-100, 100);
        ran2 = Random.Range(-100, 100);
        ran3 = Random.Range(-100, 100);

        rB.angularVelocity = new Vector3(ran1, ran2, ran3);
    }
}
