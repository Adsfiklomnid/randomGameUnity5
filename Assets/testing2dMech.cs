using UnityEngine;
using System.Collections;

public class testing2dMech : MonoBehaviour {

	public bool onGround;
	public GameObject sprite;
	public GameObject spriteThreeD;

	public static int playerHealth;

	public GameObject cameraTwoD;
	public GameObject cameraThreeD;
	
	public bool isThreeD;
	
	bool movingLeft = false;
	bool movingRight = false;
	
	void Start () {
		//Init everything here.
		isThreeD = false;
	}
	

	void Update () {
		
		if(isThreeD){
		
		}
		else
		{
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
			
			if(Input.GetKeyDown ("c")){
				changeMode(isThreeD);
			}
			if(Input.GetKeyUp ("a")){
				movingLeft = false;
			}
			if(Input.GetKeyUp ("d")){
				movingRight = false;
			}
		}	
		
		if(movingLeft){
			moveLeft();
		}
		if(movingRight){
			moveRight();
		}
		if(!isThreeD){
			if (Input.GetKeyDown ("space")){
				if(onGround){
					sprite.GetComponent<Rigidbody>().AddForce(Vector2.up * 500);
					onGround = false;
				}
			}
		
			if(Input.GetKeyDown ("a")){
			print("a");
				sprite.GetComponent<Rigidbody>().AddForce(Vector2.right * -100);
			}
			if(Input.GetKeyDown ("d")){
			print("d");
				sprite.GetComponent<Rigidbody>().AddForce(Vector2.right * 100);
			}
		
			if(Input.GetKeyDown ("c")){
				if(isThreeD){
					cameraTwoD.SetActive(true);
					cameraThreeD.SetActive(false);
				
				}else{
					cameraTwoD.SetActive(false);
					cameraThreeD.SetActive(true);
				
				}
			}
		}else{
		//3d controller

		}
	}
	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag == "ground"){
			onGround = true;
		}
	}
	
	//2d movement functions:
		
	void moveLeft(){
		sprite.GetComponent<Rigidbody>().AddForce(Vector2.right * -20);
	}
	void moveRight(){
		sprite.GetComponent<Rigidbody>().AddForce(Vector2.right * 20);
	}
	
	void changeMode(bool threeD){
		if(threeD){
			cameraTwoD.SetActive(true);
			cameraThreeD.SetActive(false);
			isThreeD = false;
					
		}else{
			cameraTwoD.SetActive(false);
			cameraThreeD.SetActive(true);
			isThreeD = true;
		}
		
	}
	
	
}


