using UnityEngine;
using System.Collections;

public class BallControll : MonoBehaviour {

	public AudioClip click;

	void Start()
	{
		this.GetComponent<Rigidbody2D> ().gravityScale = 0;
	}

	void OnCollisionEnter2D(Collision2D engel)
	{
		AudioSource.PlayClipAtPoint (click, this.transform.position);
	}

}
