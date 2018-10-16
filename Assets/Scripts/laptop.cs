using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class laptop : MonoBehaviour
{

	public Collider laptopcollider;
	
	//stick on laptop trigger
	//ENDSTATE TRIGGER SCRIPT: When you enter the collider, new scene with just text UI saying "yaaay u did it"
	//scenemanager???

	// Use this for initialization
	void Start ()
	{

		laptopcollider.isTrigger = false;

	}
	
	// Update is called once per frame
	void Update () {

		if (triggerfordice.dicefound == 7)
		{
			laptopcollider.isTrigger = true;
		}
		else
		{
			laptopcollider.isTrigger = false;
		}
		
	}

void OnTriggerStay(Collider laptopcollider) 
	{
		if (Input.GetMouseButtonDown(0) && triggerfordice.dicefound == 7)
		{
			Debug.Log("Win!");
			SceneManager.LoadScene("endscene");
		}
	}
}
