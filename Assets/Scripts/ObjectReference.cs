using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ObjectReference : MonoBehaviour {

	public Sprite active, unactive;
	
	void OnEnable(){
		GetComponent<Image>().sprite = active;
	}
	
	public void ObjectFound(){
		GetComponent<Image>().sprite = unactive;
	}
	

}
