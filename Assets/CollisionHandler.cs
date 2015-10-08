using UnityEngine;
using System.Collections;

public class CollisionHandler : MonoBehaviour {

	private bool isColliding = false;
	public bool IsColliding{
		get{
			return isColliding;
		}

		set{
			isColliding = value;
		}
	}
	// Update is called once per frame
	void Update () {
		Debug.DrawRay(transform.localPosition, new Vector3(1, 0, 0));
		CheckForCollisions();
		Debug.Log(IsColliding);

	}

	void CheckForCollisions(){
		if(Physics.Raycast(transform.position, new Vector3(1,0,0), 1)){
			IsColliding = true;
		}
		else if(!Physics.Raycast(transform.position, new Vector3(1, 0, 0), 1)){
			IsColliding = false;
		}

	}
	void CheckForInteractable(){
		if(IsColliding == true){

		}
	}
}
