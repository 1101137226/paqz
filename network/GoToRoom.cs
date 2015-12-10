using UnityEngine;
using System.Collections;

public class GoToRoom : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	public void OnPress(bool ispress){
		
		if (ispress) {
				
			Application.LoadLevel("mainmemu");
		
		
		
		}

		
	}
	// Update is called once per frame

}
