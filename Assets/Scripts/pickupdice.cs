using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class pickupdice : MonoBehaviour
{

	//usage: put on item to be picked up
	//intent: click to pick up object, move it with player, then be able to put it down.
	//MIGHT BE TOTALLY USELESS AND I SHOULD PROBABLY JUST USE RAYCASTING,
	
	//define in inspector the item, then the character controller temporarily being parented to it i think.
	//not sure what the transform is yet. following a tutorial here
	public GameObject die;
	public GameObject tempParent;
	public Transform guide;

	// Use this for initialization
	void Start ()
	{
		//at start, die has gravity
		die.GetComponent<Rigidbody>().useGravity = true;



	}
	
	// Update is called once per frame
	void Update () {
		//define ray. two parameters = ray origin and ray direction
		Ray camRay = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
		//set max distance
		float maxRaycastDist = 0.5f;
		RaycastHit myRayHit = new RaycastHit();
		//visualize
		Debug.DrawRay(camRay.origin, camRay.direction * maxRaycastDist, Color.magenta);

		if ((Physics.Raycast(camRay, out myRayHit, maxRaycastDist)) && Input.GetMouseButton(0))  //have an else for mouse release
		{
			//set gravity to false and kinematic to true so it can be lifted?
			die.GetComponent<Rigidbody>().useGravity = false;
			die.GetComponent<Rigidbody>().isKinematic = true;
			//move and rotate die with player? somehow 'guide' will become player movement.
			die.transform.position = guide.transform.position;
			die.transform.rotation = guide.transform.rotation;
			//making die a child of tempParent
			die.transform.parent = tempParent.transform;
		}
		else
		{
			//mouse release
			die.GetComponent<Rigidbody>().useGravity = true;
			die.GetComponent<Rigidbody>().isKinematic = false;
			//unparent die from tempParent;
			die.transform.parent = null;
			//teleporting one more time to guide's position???
			die.transform.position = guide.transform.position;
			
		}

	}
	
}
