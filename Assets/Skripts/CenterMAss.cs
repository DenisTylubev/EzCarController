using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterMAss : MonoBehaviour
{
    public Transform CenterOfMass;

    private void Awake()
    {
        GetComponent<Rigidbody>().centerOfMass =  Vector3.Scale(CenterOfMass.localPosition, transform.localScale);
       
    }

}
