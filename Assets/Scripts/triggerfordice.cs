using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//usage: put on trigger to start a counter
//intent: count the amount of dice you've found

public class triggerfordice : MonoBehaviour
{

	public Text myTextDisplay;
	public Collider diecollider;
	int dicefound = 0;
	public Collider laptoptrigger;
	

	// Use this for initialization
	void Start () {
		
		myTextDisplay.text = "Find all three dice!";
		Cursor.lockState = CursorLockMode.Locked;
		laptoptrigger.isTrigger = false;


	}
	
	// Update is called once per frame
	void Update()
	{
		//trying to make an if statement here where laptoptrigger is enabled if dicefound = 3, but you can't convert an int to a bool
	}

	void OnTriggerEnter(Collider diecollider)
	{
		//if (gameObject.CompareTag("dice")) doesn't work for ONLY doing this if the die object enters the collider. atm, any collider entering the trigger makes this happen.
		//{
			//add one to dicefound
			dicefound++;
			//add new line adding score to text UI!
			myTextDisplay.text = "Dice found: " + dicefound.ToString();
			diecollider.GetComponent<Rigidbody>().isKinematic = true;
			diecollider.enabled = false;

		//}
	}
}
