using UnityEngine;
using System.Collections;

public class VSBack : MonoBehaviour {


	void Start () {
	
	}

	public void OnPress(bool ispress)
	{
		if (ispress) {
		if(this.name == "Back")
			{
				Application.LoadLevel("mainmemu");
			}
		}
	}
	

	void Update () {
	
	}
}
