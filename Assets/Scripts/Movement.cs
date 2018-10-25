using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	// Update is called once per frame
	void Update () {

		transform.Translate(20f * Input.GetAxis("Horizontal")*Time.deltaTime, 0f, 25f* Time.deltaTime);
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.Translate(0f, 10f*Time.deltaTime, 0f);
		}
	}
}
