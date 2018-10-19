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
		
		myTextDisplay.text = "Oh no. My D&D session is today, but I lost my crucial dice set! \n \n -Find all seven dice and drop them in the dice tray.";


	}
	
	// Update is called once per frame
	void Update()
	{
		if (dicefound == 7)
		{
			myTextDisplay.text = "Found all my dice! Now, time to start my game. Hope I don't get killed in this dungeon. \n \n -Click on the laptop to end the search!";
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
			diecollider.GetComponent<Rigidbody>().isKinematic = false;
			//diecollider.enabled = false;
			diecollider.gameObject.layer = 2;
		if (dicefound == 1)
		{
			myTextDisplay.text += "\n \n Fun fact: Each set of polyhedral dice for D&D contains seven dice, each of a different amount of sides: 4, 6, 8, 10, another 10 for percentages, 12, and 20.";
		}
		if (dicefound == 2)
		{
			myTextDisplay.text += "\n \n I got my first set of dice at Forbidden Planet on Broadway two years ago. \n I've now got over twenty sets, all glittery, mostly blue.";
		}
		if (dicefound == 3)
		{
			myTextDisplay.text += "\n \n Fun fact: The twenty-sided die is the most important, and most satisfying, for a D&D player.";
		}
		if (dicefound == 4)
		{
			myTextDisplay.text += "\n \n This is a very approximate, simplified version of my dorm room. \n \n It's much tinier than this, actually, and a little more hospitable.";
		}
		if (dicefound == 5)
		{
			myTextDisplay.text += "\n \n I made this song on Garageband a few years ago out of boredom.";
		}
		if (dicefound == 6)
		{
			myTextDisplay.text += "\n \n Almost there. Isn't this vague, dissociative sunrise pocket dimension lovely?";
		}
		

		//}
	}

}

