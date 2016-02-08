using UnityEngine;
using System.Collections;

public class plantGrow : MonoBehaviour {
	/*	plan:
	
		Hold down left, grow. Differentiate between bouncy or bridge.
		Hold right, shrink.
		
	
	*/
	float range;
	bool growing = false;
	int plantType;
	float timeStart;
	float timeFinish;
	public GameObject playerCamera;
	void Start(){
	
		
	}
	void Update(){

	
	}
	
	void OnMouseOver(){
		if(Input.GetMouseButtonDown(0)){
			//Start counting how long.
		      if(gameObject.tag == "growShroom"){
					print(gameObject.name);
				}else if(gameObject.tag == "bridgeShroom"){
					
				}else if(gameObject.tag == "bridgeShroom"){
					
				}					
		}if(Input.GetMouseButtonUp(0)){
			//Stop animations & transitions
			// Stop counter
		}
	 }

	 void GrowPlanr(){
		 
		 
	 }
 
}
	