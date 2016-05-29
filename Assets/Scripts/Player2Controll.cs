using UnityEngine;
using System.Collections;

public class Player2Controll : MonoBehaviour {

	public Transform ball;
	public Transform point;
	private bool rasgele=true;


	void Update () 
	{
		Move ();
	}

	public void Move()
	{
		if(ball.position.x>= point.position.x && rasgele==true)
		{
			rasgele = false;
			transform.position = new Vector2 (transform.position.x,ball.transform.position.y);
		}
		
		else if(ball.position.x< point.position.x)
			rasgele = true;
	}
}
