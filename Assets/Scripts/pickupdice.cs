using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupdice : MonoBehaviour {

public Collider bodycollider;

	// Use this for initialization
	void Start () {
	
	
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider bodycollider)
	{
		if (Input.GetKey(KeyCode.Space))
		{
			Destroy(GameObject.FindGameObjectWithTag("dice"));
		}
	}
}
