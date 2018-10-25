using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

	float div;
	float sco;//score to be displayed
	public Transform player;
	public Text SCORE;
	public Movement move;
	float height;
	// Use this for initialization
	void Start () {
		div = player.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		sco = -1*(player.position.z) / div;
		height = player.position.y;
	}
	private void LateUpdate()
	{
		Debug.Log(player.position.y);
		if(player.position.y<0f)
		{
			SCORE.text = "Out of Bounds";
		}
		SCORE.text = sco.ToString("0");
		
	}
	private void OnCollisionEnter(Collision collision)
	{
		 if (collision.collider.tag == "winplatform")
		{
			move.enabled = false;
			SCORE.text = "You Win.";
		}

	}
}
