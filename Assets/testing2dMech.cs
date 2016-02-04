using UnityEngine;
using System.Collections;

public class testing2dMech : MonoBehaviour {
	public Transform leftPoint;
	public Transform rightPoint;
	public bool onGround;
	public GameObject sprite;
	
	public bool spiritOn = false;
	
	public static int playerHealth;

	public GameObject cameraTwoD;
	
	bool movingLeft = false;
	bool movingRight = false;
	
	/*
		2.5d controller; Left,Right,Jump
		Mouse block grower?
		Bridge
	*/
	//animations:
	
	//public Animation walk;
	public AnimationClip walk;
	
	//public jump AnimationClip;
	void Start () {
		//Init everything here.
	}
	

	void Update () {
			if (Input.GetKeyDown ("space")){
				if(onGround){
					sprite.GetComponent<Rigidbody>().AddForce(Vector2.up * 500);
					onGround = false;
				}
			}
			
		if(Input.GetKeyDown ("a")){
			movingLeft = true;
		}
		if(Input.GetKeyDown ("d")){
			movingRight = true;
		}
		if(Input.GetKeyUp ("a")){
			movingLeft = false;
		}
		if(Input.GetKeyUp ("d")){
			movingRight = false;
		}
		if(movingLeft){
			moveLeft();
		}
		if(movingRight){
			moveRight();
		}
		if(Input.GetKeyDown ("space")){
			if(onGround){
				sprite.GetComponent<Rigidbody>().AddForce(Vector2.up * 500);
				onGround = false;
			}
		}
		
			/*if(Input.GetKeyDown ("a")){
			print("a");
				sprite.GetComponent<Rigidbody>().AddForce(Vector2.right * -100);
			}
			if(Input.GetKeyDown ("d")){
			print("d");
				sprite.GetComponent<Rigidbody>().AddForce(Vector2.right * 100);
			}*/
	}
	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag == "ground"){
			onGround = true;
		}
	}
	
	//2d movement functions:
		
	void moveLeft(){
		sprite.GetComponent<Rigidbody>().AddForce(Vector2.right * -20);
		transform.LookAt(leftPoint);
	//	walk.Play();
	}
	void moveRight(){
		sprite.GetComponent<Rigidbody>().AddForce(Vector2.right * 30);
		//GetComponent<Animation>().CrossFade ("metarig|Run");
		transform.LookAt(rightPoint);
	}
}


