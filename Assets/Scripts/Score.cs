using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	public Transform blue,red;
	static public int blueScore=0;
	static public int redScore=0;
	public AudioClip pow;

	void Start () {

		blue.GetComponent<TextMesh>().text = ""+blueScore;
		red.GetComponent<TextMesh>().text = ""+redScore;
	}

	void OnCollisionEnter2D (Collision2D engel) 
	{
		if(engel.gameObject.tag == "sagEngel")
		{
			AudioSource.PlayClipAtPoint(pow,transform.position);
			blueScore++;
			blue.GetComponent<TextMesh>().text = ""+blueScore;
			Application.LoadLevel(Application.loadedLevel);
			TimesCount.count=3;
		}

		if(engel.gameObject.tag == "solEngel")
		{
			AudioSource.PlayClipAtPoint(pow,transform.position);
			redScore++;
			red.GetComponent<TextMesh>().text = ""+redScore;
			Application.LoadLevel(Application.loadedLevel);
			TimesCount.count=3;
		}
	}
}
