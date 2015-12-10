using UnityEngine;
using System.Collections;

public class VSBack : MonoBehaviour {

	// Use this for initialization
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
	
	// Update is called once per frame
	void Update () {
	
	}
}
