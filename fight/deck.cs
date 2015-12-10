using UnityEngine;
using System.Collections;

public class deck : MonoBehaviour
{
	
	public UILabel card;
	public Transform father;
	public static bool draw = false;
	Queue handd = new Queue ();
	byte carddeck;
	// Use this for initialization
	void Start ()
	{
		/*
		PlayerPrefs.SetInt ("001_amount", 3);
		PlayerPrefs.SetInt ("002_amount", 3);
		PlayerPrefs.SetInt ("003_amount", 3);
		PlayerPrefs.SetInt ("004_amount", 3);
		PlayerPrefs.SetInt ("005_amount", 3);
		*/

		string [] deck = new string[30];
		string j = "1";
		int i = 0;
	
		do {
			
			if ((PlayerPrefs.GetInt (j + "_amount")) == 3) {
				deck [i] = j;
				deck [i + 1] = j;
				deck [i + 2] = j;
				i = i + 3;
				
			} else if ((PlayerPrefs.GetInt (j + "_amount")) == 2) {
				deck [i] = j;
				deck [i + 1] = j;
				i = i + 2;
				
			} else if ((PlayerPrefs.GetInt (j + "_amount")) == 1) {
				deck [i] = j;
				i++;
			}

			j = System.Convert.ToString (System.Int32.Parse (j) + 1);	
			
			if (j == "81") {
				i = 30;
			}
		} while(i<30);

		Random.seed = System.Guid.NewGuid ().GetHashCode ();

		for (int q=1; q<1000; q++) {
				
			int o = Random.Range (0, 30);
			int p = Random.Range (0, 30);

			string change = deck [o];
			deck [o] = deck [p];
			deck [p] = change;
		}

		for (int q=0; q<30; q++) {
			handd.Enqueue (deck [q]);
		}

		father = GameObject.Find ("UIRoot").transform;
		for (int q=0; q<5; q++) {
			
			Instantiate (Resources.Load ("hand/" + handd.Peek ()));
			GameObject.Find (handd.Peek () + "(Clone)").transform.parent = GameObject.Find ("UIRoot").transform;
			GameObject.Find (handd.Peek () + "(Clone)").transform.localScale = new Vector3 (1, 1, 1);

			//First 5 Card In Hand
			//X Pos >> -6600(0), -4800(1), -3000(2), -1200(3), 600(4)
			GameObject.Find (handd.Peek () + "(Clone)").transform.localPosition = new Vector3 (-6600 + q * 1800, -3300, 0);

			GameObject.Find (handd.Dequeue () + "(Clone)").name = System.Convert.ToString (q);

			bactrl.ishand [q] = true;

		}

		//mSprite
		carddeck = 25;
	}

	public void Draw ()
	{

		for (int q=0; q<5; q++) {
			if (bactrl.ishand [q] == false && handd.Count > 0) {
				GameObject.Find ("drawSE").GetComponent<AudioSource> ().Play ();
				bactrl.ishand [q] = true;
				carddeck--;
				Instantiate (Resources.Load ("hand/" + handd.Peek ()));
				GameObject.Find (handd.Peek () + "(Clone)").transform.parent = GameObject.Find ("UIRoot").transform;
				GameObject.Find (handd.Peek () + "(Clone)").transform.localScale = new Vector3 (1, 1, 1);

				//The New Card By Draw, Their Y Pos Has To Control And Lower Than Default Y Pos Of Card
				GameObject.Find (handd.Peek () + "(Clone)").transform.localPosition = new Vector3 (-6600 + q * 1800, -4500, 0);

				GameObject.Find (handd.Peek () + "(Clone)").GetComponent<cardfly> ().fly = true;
				GameObject.Find (handd.Dequeue () + "(Clone)").name = System.Convert.ToString (q);
				
				break;
			}
		}
	}
	// Update is called once per frame
	void Update ()
	{
		card.text = System.Convert.ToString (carddeck);

		if (aaaaa.drawcombo >= 10) {
			aaaaa.drawcombo = 0;
			Draw ();
		}
	}
}
