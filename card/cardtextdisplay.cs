using UnityEngine;
using System.Collections;

public class cardtextdisplay : MonoBehaviour {


	void Start () {
	
	}
	

	void Update () {
	
		int id = System.Convert.ToInt32 (gotobig.cardidd);
		
		string text = cardsay.cardid [id, 1];
		
		this.GetComponent<UILabel>().text=text;



	}
}
