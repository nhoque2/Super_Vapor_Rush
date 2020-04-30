using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowController : MonoBehaviour {

	
	public void LookAtTarget()
	{
		Vector3 _lookDirection = objectToFollow.position - transform.position;
		Quaternion _rot = Quaternion.LookRotation(_lookDirection, Vector3.up);
		transform.rotation = Quaternion.Lerp(transform.rotation, _rot, lookSpeed * Time.deltaTime);
	}

	public void MoveToTarget()
	{
		Vector3 _targetPos = objectToFollow.position + 
							 objectToFollow.forward * offset.z + 
							 objectToFollow.right * offset.x + 
							 objectToFollow.up * offset.y;
		transform.position = Vector3.Lerp(transform.position, _targetPos, followSpeed * Time.deltaTime);
	}

	private void FixedUpdate()
	{
	
	 if(Input.GetKey(KeyCode.DownArrow)||Input.GetKey(KeyCode.S)){
		if(Camera.main.fieldOfView>=55 && Camera.main.fieldOfView<=60){
		Camera.main.fieldOfView+=0.1f;
		}
	}
	
		if(Camera.main.fieldOfView>=55 && Camera.main.fieldOfView<=60){
			Camera.main.fieldOfView-=0.1f;
		}
	
		LookAtTarget();
		MoveToTarget();
	}

	public Transform objectToFollow;
	public Vector3 offset;
	public float followSpeed = 10;
	public float lookSpeed = 10;
}
