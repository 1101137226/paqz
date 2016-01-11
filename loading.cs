using UnityEngine;
using System.Collections;

public class loading : MonoBehaviour {
	AsyncOperation async;

	void Start () {
		StartCoroutine(loadScene());
	}
	IEnumerator loadScene()
	{
		string what = GameObject.Find ("donotkillme").GetComponent<loadscene> ().what;
		async = Application.LoadLevelAsync(what);
		

		yield return async;
		
	}

	void Update () {


	
	}
}
