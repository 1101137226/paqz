using UnityEngine;
using System.Collections;

public class loading : MonoBehaviour {
	AsyncOperation async;
	// Use this for initialization
	void Start () {
		StartCoroutine(loadScene());
	}
	IEnumerator loadScene()
	{
		//异步读取场景。
		//Globe.loadName 就是A场景中需要读取的C场景名称。
		string what = GameObject.Find ("donotkillme").GetComponent<loadscene> ().what;
		async = Application.LoadLevelAsync(what);
		
		//读取完毕后返回， 系统会自动进入C场景
		yield return async;
		
	}
	// Update is called once per frame
	void Update () {


	
	}
}
