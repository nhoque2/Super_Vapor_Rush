using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brakeLight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.DownArrow)||Input.GetKey(KeyCode.S)){
	GetComponent<Light>().range=1.0f;
	}
	else{
	GetComponent<Light>().range=0.5f;
	}
    }
}
