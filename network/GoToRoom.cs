using UnityEngine;
using System.Collections;

public class GoToRoom : MonoBehaviour {
	void Start () {
	
	}
	public void OnPress(bool ispress){
		
		if (ispress) {				
			Application.LoadLevel("mainmemu");		
		}
	}
}
