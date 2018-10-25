using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

	float div;
	float sco;//score to be displayed
	public Transform player;
	public Text SCORE;
	//public Movement move;
	//float height;
	//public Text message;
	// Use this for initialization
	void Start () {
		div = player.position.z;
		//height = player.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		sco = -1*(player.position.z) / div;
		//height = player.position.y;
	}
	private void LateUpdate()
	{
		
		SCORE.text = sco.ToString("0");
	}
}
