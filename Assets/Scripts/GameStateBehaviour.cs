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
	

	void Start(){
#if UNITY_IPHONE
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
#endif
		Timer.Instance.TimeOver += Lose;
	}


	public void Quit () {
		Application.Quit();
	}
	
		
	public void RestartGame(){
		Reset();
		StartGame ();
	}
	
	public void  Return (){
		GameOver();
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
		Timer.Instance.SetTimer(11);
	}

}
