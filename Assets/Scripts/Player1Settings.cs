using UnityEngine;
using System.Collections;

public class Player1Settings : MonoBehaviour {


    private Vector3 position;

	void Update ()
	{
		Move ();
//		Debug.LogError(GameObject.Find("Ball").GetComponent<Rigidbody2D>().velocity.x);
	}

	public void Move()
	{
		if(Application.platform == RuntimePlatform.Android)
			position = Camera.main.ScreenToWorldPoint(new Vector3(Input.GetTouch(0).position.x,Input.GetTouch(0).position.y,-2));
		
		else
			position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,-2));

		transform.position = new Vector3 (transform.position.x, position.y+1f,-1);
	}
}
