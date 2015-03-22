using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ObjectSelectable : MonoBehaviour {

	void Start(){
		GameStateBehaviour.Instance.Reset += Reset;
	}

	void Reset(){
		GetComponent<Image>().color = new Color(1,1,1,1);
		GetComponent<Button>().interactable = true;
	}

	public void AddPoint(){
		GetComponent<AudioSource>().Play();
		GameStateBehaviour.Instance.AddPoint();
	}
}
