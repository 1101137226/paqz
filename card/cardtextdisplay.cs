using UnityEngine;
using System.Collections;

public class cardtextdisplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		int id = System.Convert.ToInt32 (gotobig.cardidd);
		
		string text = cardsay.cardid [id, 1];
		
		this.GetComponent<UILabel>().text=text;



	}
}
