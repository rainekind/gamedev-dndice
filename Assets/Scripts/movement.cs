using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

	public float moveSpeed = 10f;
	//this variable remembers input and passes it to physics
	private Vector3 inputVector;
	private float verticalLook = 0f;
	public float LookSpeed = 100f;
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// MOUSE LOOK!!!
		
		// getting mouse input
		// these are mouse "deltas"... delta = difference
		// these will be 0 when nothing is moving, this ISN'T mouse position
		float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * LookSpeed; // horizontal mouse movement. multiplied by dT means
		// the camera will move the same no matter what framerate
		float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * LookSpeed; // vertical mouse movement
		
		// rotations: Pitch Yaw Roll
		// pitch = up/down rotation, X axis
		// yaw = left/right rotation, Y axis
		// roll = rolling motion, Z axis
		
		// rotate the camera based on mouse input
		// first, rotate body based on horizontal mouse movement
		transform.Rotate( 0f, mouseX, 0f); // yaw
		
		//better mouse lok:
		//add mouse input to verticalLook, then clamp verticalLook
		verticalLook += -mouseY;
		//clamp it
		verticalLook = Mathf.Clamp(verticalLook, -80f, 80f); //vertical look will always be between -80 and 80
		//apply verticalLook to rotation
		Camera.main.transform.localEulerAngles = new Vector3(verticalLook, 0f, 0f);
		
		//lock hide cursor if they click the mouse
		if (Input.GetMouseButtonDown(0)) //0 = left, 1 = right, 2 = middleclick
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
		}

		//----------------------------- 
		//WASD MOVEMENT
		//get axiss returns a float between -1f and 1f. when you're not pressing anything it returns 0f
		float horizontal = Input.GetAxis("Horizontal"); // a d
		float vertical = Input.GetAxis("Vertical"); // w s 
		//apply keyboard input to position
		//when you do this, you're teleporting. no collision detection
		//transform.position += transform.forward * vertical * moveSpeed; //forward
		//transform.position += transform.right * horizontal * moveSpeed; //strafe
		//HAHA SIKE THAT WAS USELESS, BITCH

		//collecting data. remember to use += so it means 'also equals' i guess??
		inputVector = transform.forward * vertical;
		inputVector += transform.right * horizontal;
		

	}
//runs every physics frame (a different framerate than input or rendering or anything else)
//PUT ALL PHYSICS CODE IN FIXEDUPDATE
	void FixedUpdate()
	{
		//override object's velocity with desired inputVector direction
		GetComponent<Rigidbody>().velocity = inputVector * moveSpeed + Physics.gravity * 0.5f;
	}
}
