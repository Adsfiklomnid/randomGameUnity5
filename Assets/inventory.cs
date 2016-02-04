using UnityEngine;
using System.Collections;

public class inventory : MonoBehaviour {
	
	int animalFrag = 0;
	int amPlantGrow = 0;
	
	void start(){
	
	}
	/*
	HOLD left mous button to grow plant. [In Range?]
	The longer you hold it the more it grows.
	Hold the right mouse button to shrink plant
	*/
	void Update(){
		Vector3 fwd = transform.TransformDirection(Vector3.forward);
		
		if(Input.GetMouseButtonDown(0)){
			if (Physics.Raycast(transform.position, fwd, 10)) {
				
			}
		}	
	}
}