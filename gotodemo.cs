using UnityEngine;
using System.Collections;

public class gotodemo : MonoBehaviour {

	public void OnPress(bool ispress){
		
		if (ispress) {
			GameObject.Find("donotkillme").GetComponent<loadscene>().what="demokai";
			GameObject.DontDestroyOnLoad(GameObject.Find("donotkillme").gameObject);
						Application.LoadLevel ("load");
			
				}
		}
		
		
	}

