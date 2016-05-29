using UnityEngine;
using System.Collections;

public class TimesCount : MonoBehaviour {

    public float zaman;
	static public int count=2;
	public Sprite sprite;
	public Transform ball;
	public AudioClip[] press;

	void Start () { 
		zaman = Time.time;
	}
	void Update () {

		TimeBreak();
	}

	void TimeBreak()
	{
		if(Time.time-1>= zaman && count>=-1)
		{
			if(count>0)
			{
				GetComponent<TextMesh>().text =""+count;
				AudioSource.PlayClipAtPoint(press[0],this.transform.position);
			}
			
			
			else if(count==0)
			{ 
				GetComponent<TextMesh>().text ="";
				GameObject.Find("ScreenSprite").GetComponent<SpriteRenderer>().sprite  = sprite;
				AudioSource.PlayClipAtPoint(press[1],this.transform.position);
			}
			
			else if(count<0)
			{
				GameObject.Find ("Ball").GetComponent<Rigidbody2D> ().gravityScale = 1;
				GameObject.Find ("Ball").GetComponent<Rigidbody2D> ().velocity = new Vector2 (25, 10);
				GameObject.Find("ScreenSprite").GetComponent<SpriteRenderer>().enabled = false;
				this.GetComponent<AudioSource>().Play();
			}
			
			count--;
			zaman = Time.time;
		}

	}
}
