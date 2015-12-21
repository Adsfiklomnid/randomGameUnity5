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
<<<<<<< HEAD
		
		if(isThreeD){
		
		}else{
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
=======
		if(!isThreeD){
			sprite.transform.position.z = 0;
		
			if (Input.GetKeyDown ("space")){
				if(onGround){
					sprite.rigidbody.AddForce(Vector2.up * 500);
					onGround = false;
				}
			}
		
			if(Input.GetKeyDown ("a")){
			print("a");
				sprite.rigidbody.AddForce(Vector2.right * -100);
			}
			if(Input.GetKeyDown ("d")){
			print("d");
				sprite.rigidbody.AddForce(Vector2.right * 100);
			}
		
			if(Input.GetKeyDown ("c")){
				if(isThreeD){
					cameraTwoD.SetActive(true);
					cameraThreeD.SetActive(false);
				
					spriteThreeD.SetActive(false);
					spriteTwoD.SetActive(true);
				
				}else{
					cameraTwoD.SetActive(false);
					cameraThreeD.SetActive(true);
				
					spriteTwoD.SetActive(false);
					spriteThreeD.SetActive(true);
				}
			}
		}else{
		//3d controller
>>>>>>> 31437d1fb31d938b320a8a17164f44e3a03b82a8
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


