using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System; 


public class SimpleCarController : MonoBehaviour {

	public void GetInput()
	{
		m_horizontalInput = Input.GetAxis("Horizontal");
		m_verticalInput = Input.GetAxis("Vertical");
	}

	private void Steer()
	{
		m_steeringAngle = maxSteerAngle * m_horizontalInput;
		frontDriverW.steerAngle = m_steeringAngle;
		frontPassengerW.steerAngle = m_steeringAngle;
	}

	private void Accelerate()
	{
		frontDriverW.motorTorque = m_verticalInput * motorForce;
		frontPassengerW.motorTorque = m_verticalInput * motorForce;
	}

	private void UpdateWheelPoses()
	{
		UpdateWheelPose(frontDriverW, frontDriverT);
		UpdateWheelPose(frontPassengerW, frontPassengerT);
		UpdateWheelPose(rearDriverW, rearDriverT);
		UpdateWheelPose(rearPassengerW, rearPassengerT);
	}

	private void UpdateWheelPose(WheelCollider _collider, Transform _transform)
	{
		Vector3 _pos = _transform.position;
		Quaternion _quat = _transform.rotation;

		_collider.GetWorldPose(out _pos, out _quat);

		_transform.position = _pos;
		_transform.rotation = _quat;
	}
	

	public float Speed() {
		float speed=Math.Abs(frontDriverW.radius * Mathf.PI * frontDriverW.rpm * 60f / 100000f)/100;
		if(speed<999){
		return speed;	
		}
		else{
		return 999f;
		}
	}
	

	private void FixedUpdate()
	{
		

		GetInput();
		Steer();
		if(((frontDriverW.radius * Mathf.PI * frontDriverW.rpm * 60f / 100000f)/100)<=maxSpeed){
			Accelerate();
		}	
		UpdateWheelPoses();
if(speedText!=null)
			speedText.text = Speed().ToString("f0") ;
	if((transform.position.y<-50)&&(transform.position.x>-3128.448)){
		gameOver.GameEnd();
		timer.timeStop=true;
	}
	if(transform.position.x<-1989.25){
		timer.timeStop=true;
		won.gameWon();	
	}
	if(Speed()>975){
	speedText.color = Color.red;
	}
		



}
private float m_horizontalInput;
	private float m_verticalInput;
	private float m_steeringAngle;
	private bool isOnTrack=false;

	public GameOver gameOver;
	public GameWon won;
	public Timer timer;
	public WheelCollider frontDriverW, frontPassengerW;
	public WheelCollider rearDriverW, rearPassengerW;
	public Transform frontDriverT, frontPassengerT;
	public Transform rearDriverT, rearPassengerT;
	public float maxSteerAngle = 30;
	public float motorForce = 50;
	public float maxSpeed=450;
	public Text speedText;

}
