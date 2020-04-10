using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnBreakScript : MonoBehaviour {

	
	public GameObject unbrokenColumn;
	public GameObject brokenColumn;

	//this determines whether the column will be broken or unbroken at the at runtime
	public Camera fpsCam;
	public bool isBroken;


	void Start()
	{ 
		if (isBroken) {
			BreakColumn ();
		} else {
			unbrokenColumn.SetActive (true);
			brokenColumn.SetActive (false);
		}
	}


	void BreakColumn()
	{
		isBroken = true;
		unbrokenColumn.SetActive (false);
		brokenColumn.SetActive (true);
	}


	void Update()
	{
		RaycastHit hit;
		//this is a placeholder activation for breaking the column when the space key is pressed
			
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit)) {
            if (hit.transform.name == "Unboken Column" && !isBroken && Input.GetMouseButtonDown(0)) {
				BreakColumn();
			}
		}
	}
}