using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//usage: put on trigger to start a counter
//intent: count the amount of dice you've found

public class triggerfordice : MonoBehaviour
{

	public Text myTextDisplay;
	public Text thoughtstext;
	public Collider diecollider;
	public static int dicefound = 0;
	

	// Use this for initialization
	void Start () {
		
		myTextDisplay.text = "Well, hell. My D&D session is today, but I dropped my favorite set of dice... (Find all seven dice and drop them in the dice tray.)";


	}
	
	// Update is called once per frame
	void Update()
	{
		if (dicefound == 7)
		{
			myTextDisplay.text = "Found all my dice! Now, time to start my game. Hope I don't get killed in this dungeon. (Click on the laptop to start your game.)";
		}
		//trying to make an if statement here where laptoptrigger is enabled if dicefound = 7, but you can't convert an int to a bool
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

