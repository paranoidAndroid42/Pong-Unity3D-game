using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {


	void Start () {	
		int c = Random.Range (0,34);
		if (c < 10)
		{
			Debug.LogError("ihtimal yüzde 10");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
