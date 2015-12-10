using UnityEngine;
using System.Collections;

public class NETMAP : MonoBehaviour {

	public Sprite village;
	public Sprite forest;
	public Sprite town;
	public Sprite field;
	public Sprite mountain;
	public Sprite cave;
	public Sprite castle;
	public Sprite school;
	public Sprite subway;
	public Sprite king;

	int o;
	// Use this for initialization
	void Start () {
		GameObject m = GameObject.Find ("donotkillme").gameObject;

		byte map = m.GetComponent<NETmapselect> ().mapnum;
		GameObject mapchange = GameObject.Find ("ground3").gameObject;

		o = System.Convert.ToInt32 (map);

		if (map == 0) {
			Random.seed = System.Guid.NewGuid().GetHashCode();
			 o=Random.Range(0,10);
		
		
		}


		switch (o) {
				
		
		case  1 :
			mapchange.GetComponent<SpriteRenderer>().sprite=village;

			break;
		case  2 :
			mapchange.GetComponent<SpriteRenderer>().sprite=forest;
			
			break;
		case  3 :
			mapchange.GetComponent<SpriteRenderer>().sprite=town;
			
			break;
		case  4 :
			mapchange.GetComponent<SpriteRenderer>().sprite=field;
			
			break;
		case  5 :
			mapchange.GetComponent<SpriteRenderer>().sprite=mountain;
			
			break;
		case  6 :
			mapchange.GetComponent<SpriteRenderer>().sprite=cave;
			
			break;
		case  7 :
			mapchange.GetComponent<SpriteRenderer>().sprite=castle;
			
			break;
		case  8 :
			mapchange.GetComponent<SpriteRenderer>().sprite=school;
			
			break;
		case  9 :
			mapchange.GetComponent<SpriteRenderer>().sprite=subway;
			
			break;
		case  10 :
			mapchange.GetComponent<SpriteRenderer>().sprite=king;
			
			break;
		
		
		
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
