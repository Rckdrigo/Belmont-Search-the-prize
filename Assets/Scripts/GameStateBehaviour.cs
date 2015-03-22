using UnityEngine;
using System.Collections;

public class GameStateBehaviour : Singleton<GameStateBehaviour> {

	public delegate void GameEvents();
	public GameEvents GameOver;
	public GameEvents Reset;

	public Animator anim;

	public UnityEngine.UI.Image message;
	
	public Sprite win;
	public AudioClip winClip;
	
	public Sprite lose;
	public AudioClip loseClip;
	
	[HideInInspector()]
	public int actualPoints;
	
	public GameObject first, second, third;

	void Start(){
#if UNITY_IPHONE
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
#endif
		Timer.Instance.TimeOver += Lose;
	}
	
	public void AddPoint(){
		actualPoints++;
		if(actualPoints >= 6){
			GameOver();
			message.sprite = win;
			GetComponent<AudioSource>().PlayOneShot(winClip);
			anim.SetTrigger("Results");
			Timer.Instance.StopSound();
		}
	}


	public void Quit () {
		Application.Quit();
	}
	
		
	public void RestartGame(){
		Reset();
		first.SetActive(false);
		second.SetActive(false);
		third.SetActive(false);
		
		actualPoints = 0;
		StartGame ();
	}
	
	public void  Return (){
		GameOver();
		first.SetActive(false);
		second.SetActive(false);
		third.SetActive(false);
		Timer.Instance.StopSound();
		anim.SetTrigger("Return");
	}
	
	void Lose(){
		GameOver();
		message.sprite = lose;
		GetComponent<AudioSource>().PlayOneShot(loseClip);
		anim.SetTrigger("Results");
	}
	
	public void StartGame () {
		anim.SetTrigger("StartGame");
		ScenarioSelector.Instance.SelectScenario();
		Timer.Instance.SetTimer(60);
	}

}
