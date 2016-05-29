using UnityEngine;
using System.Collections;

public class Settings: MonoBehaviour {

	public bool basla,cikis;
	public bool resume,restart,menu,createMenu,sound,sCheck;
	public AudioClip click;
	public Sprite soundOff,soundOn;
	public Transform pauseMenu;
	static bool create=true;

	void Start () {
		sCheck = true;
	}

	void Update () {
		
		if (Input.GetKey ("escape") && createMenu==true) 
		{
			if(create==true)
			{
				Instantiate (pauseMenu, pauseMenu.transform.position,pauseMenu.transform.rotation);
				this.GetComponent<AudioSource>().Stop();
				AudioSource.PlayClipAtPoint (click, this.transform.position);
				create=false;
				Time.timeScale=0;
			}
		}	
	}

	void Play()
	{
		AudioSource.PlayClipAtPoint (click, this.transform.position);
		Application.LoadLevel ("Scenes1");
	}

	void Exit()
	{
		Application.Quit ();
	}

	void Resume()
	{
		Destroy(GameObject.Find("ayar_0(Clone)"));
		this.GetComponent<AudioSource> ().Play ();
		AudioSource.PlayClipAtPoint (click, this.transform.position);
	}

	void Restart()
	{
		Application.LoadLevel (Application.loadedLevel);
		AudioSource.PlayClipAtPoint (click, this.transform.position);
	}

	void Sound()
	{
		if(sCheck)
		{
			this.GetComponent<SpriteRenderer>().sprite = soundOff;
			this.GetComponent<AudioSource>().mute = true;
			sCheck=false;
		}
		
		else
		{
			this.GetComponent<SpriteRenderer>().sprite = soundOn;
			this.GetComponent<AudioSource>().mute = false;
			sCheck=true;
		}
	}




	void OnMouseUp()
	{
		if (basla)
		{
			AudioSource.PlayClipAtPoint (click, this.transform.position);
			Application.LoadLevel ("Scenes1");
		}
		if (cikis)
			Application.Quit ();

		if (resume)
		{
			Destroy(GameObject.Find("ayar_0(Clone)"));
			AudioSource.PlayClipAtPoint (click, this.transform.position);
			this.GetComponent<AudioSource> ().Play ();
		}

		if (restart)
		{
			Application.LoadLevel (Application.loadedLevel);
			AudioSource.PlayClipAtPoint (click, this.transform.position);
		}

		if (menu)
		{
			Application.LoadLevel ("MainMenu");
			AudioSource.PlayClipAtPoint (click, this.transform.position);
		}

		if(sound)
		{
			if(sCheck)
			{
				this.GetComponent<SpriteRenderer>().sprite = soundOff;
				this.GetComponent<AudioSource>().mute = true;
				sCheck=false;
			}

			else
			{
				this.GetComponent<SpriteRenderer>().sprite = soundOn;
				this.GetComponent<AudioSource>().mute = false;
				sCheck=true;
			}
		}

		Time.timeScale = 1;
		create = true;

	}
}
