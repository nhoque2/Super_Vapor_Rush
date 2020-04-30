using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AestroidRotate : MonoBehaviour
{

    [SerializeField]
    private float tumble;

    void Start()
    {
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere * tumble;
    }
}
