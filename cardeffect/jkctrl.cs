using UnityEngine;
using System.Collections;

public class jkctrl : MonoBehaviour
{
	public float passtime;
	bool jk;
	bool enjk;
	public GameObject eloww;
	public GameObject ehighh;
	public Transform father;
	Transform elowpoi;
	Transform ehighpoi;
	bool inin;
	bool inin2;
	bool where;
	void Start ()
	{
		inin = true;

		jk = GameObject.Find ("UIRoot").GetComponent<bactrl> ().jk;
		enjk = bactrl.enjk;
		GameObject.Find ("UIRoot").GetComponent<bactrl> ().jkctrloff = false;
		inin2 = true;
	}
	
	void Update ()
	{
		father = GameObject.Find ("UIRoot").transform;
		passtime += Time.deltaTime;

		if (inin) {
			bactrl.enchjk = false;
			if (jk == false) {
				if (enjk) {
					where = false;
					Destroy (GameObject.Find ("ehigh(Clone)").gameObject);
					GameObject.Find ("broken").GetComponent<AudioSource> ().Play ();
					Instantiate (Resources.Load ("highboom"));
					
					GameObject.Find ("highboom(Clone)").transform.parent = father;
					GameObject.Find ("highboom(Clone)").transform.localPosition = new Vector3 (-4000, 900, 0);
					GameObject.Find ("highboom(Clone)").GetComponent<Animator> ().SetBool ("boom", true);
					Instantiate (eloww);
					elowpoi = GameObject.Find ("elow(Clone)").transform;
					effectctrl.mother = elowpoi;
					GameObject.Find ("elow(Clone)").transform.parent = father;
					GameObject.Find ("elow(Clone)").transform.localPosition = new Vector3 (-8000, 900, 0);
				

				}
				


			} else if (jk == true) {
				if (enjk == false) {
					where = true;
					Destroy (GameObject.Find ("elow(Clone)").gameObject);
					GameObject.Find ("broken").GetComponent<AudioSource> ().Play ();
					Instantiate (Resources.Load ("lowboom"));
										
					GameObject.Find ("lowboom(Clone)").transform.parent = father;
					GameObject.Find ("lowboom(Clone)").transform.localPosition = new Vector3 (-4000, 900, 0);
					GameObject.Find ("lowboom(Clone)").GetComponent<Animator> ().SetBool ("boom", true);
					Instantiate (ehighh);
					ehighpoi = GameObject.Find ("ehigh(Clone)").transform;
					effectctrl.mother = ehighpoi;
					GameObject.Find ("ehigh(Clone)").transform.parent = father;
					GameObject.Find ("ehigh(Clone)").transform.localPosition = new Vector3 (-5184, 913, 0);
									
				}
			}
		
			inin = false;
		}


		if (passtime >= 0.67 && inin2) {
			inin2 = false;
			if (where && !enjk) {
				Destroy (GameObject.Find ("lowboom(Clone)").gameObject);
			} else if (!where && enjk) {
				Destroy (GameObject.Find ("highboom(Clone)").gameObject);


			}
		
		
		}
				
		if (passtime >= 10f) {

			GameObject.Find ("UIRoot").GetComponent<bactrl> ().jkctrloff = true;
			Destroy (this.gameObject);
			
			
		}
	}
}
