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
	

	// Use this for initialization
	void Start () {
		
		myTextDisplay.text = "Find all three dice!";
		Cursor.lockState = CursorLockMode.Locked;
	

	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	void OnTriggerEnter(Collider diecollider)
	{
		//add one to dicefound
		dicefound++;
		//add new line adding score to text UI!
		myTextDisplay.text = "Dice found: " + dicefound.ToString();
		diecollider.GetComponent<Rigidbody>().isKinematic = true;
		diecollider.enabled = false;
	}
}
