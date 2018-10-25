using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class collision : MonoBehaviour {

	// Update is called once per frame
	public Text WinText;
	public Movement move;
	public Transform player;
	Vector3 temp;
	private void Start()
	{
		temp = player.position;
	}
	private void OnCollisionEnter(Collision collision)
	{
		if(collision.collider.tag=="obstacle")
		{
			move.enabled = false;
			transform.Translate(0f, 0f, 20f * Time.deltaTime);
			transform.Translate(0f, 0f, 20f * Time.deltaTime);
			//player.position = temp;
		}
		else if(collision.collider.tag=="winplatform")
		{
			move.enabled = false;
		}
		
	}
}
