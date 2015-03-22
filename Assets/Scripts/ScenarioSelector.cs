using UnityEngine;
using System.Collections;

public class ScenarioSelector : Singleton<ScenarioSelector> {

	public GameObject[] scenarios;
	
	public void SelectScenario () {
		scenarios[Random.Range(0,scenarios.Length)].SetActive(true);
	}
	
	
}
