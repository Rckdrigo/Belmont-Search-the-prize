using UnityEngine;
using System.Collections;

public class ScenarioSelector : Singleton<ScenarioSelector> {

	public GameObject[] scenarios;
	int index = 0;
	
	
	public void SelectScenario () {
		scenarios[index].SetActive(true);
		index++;
		
		if(index > scenarios.Length - 1)
			index = 0;
	}
	
	
}
