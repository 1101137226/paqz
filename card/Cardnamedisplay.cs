using UnityEngine;
using System.Collections;

public class Cardnamedisplay : MonoBehaviour {
	void Start () {
	

	}

	void Update () {


		int id = System.Convert.ToInt32 (gotobig.cardidd);

		string name = cardsay.cardid [id, 0];
	
		this.GetComponent<UILabel>().text=name;

	
	}
}
