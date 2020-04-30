using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smokeEffect : MonoBehaviour
{
private ParticleSystem ps;
    // Start is called before the first frame update
    void Start()
    {
         ps = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
 var main = ps.main;
        if(Input.GetKey(KeyCode.DownArrow)||Input.GetKey(KeyCode.S)||Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.LeftArrow)
		||Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow)){
	 main.startSize =2f;	
    }
else{
 main.startSize =0f;
}
}
}
