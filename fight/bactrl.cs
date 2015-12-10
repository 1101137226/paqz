using UnityEngine;
using System.Collections;

public class bactrl : MonoBehaviour
{



	public static bool[] ishand = new bool[5];
	public Transform father;
	public static bool ispace;
	public static bool isP;
	public static bool isspc = false;
	public bool jk = false;
	public GameObject loww;
	public GameObject highh;
	public GameObject eloww;
	public GameObject ehighh;
	Transform lowpoi;
	Transform highpoi;
	Transform elowpoi;
	Transform ehighpoi;
	public bool changeflag;
	public static bool enjk;
	public static bool enchjk;
	public bool jkctrloff;
	public static bool sonicflag;

	// Use this for initialization
	void Start ()
	{
		aaaaa.combo = 0;
		aaaaa.drawcombo = 0;
		jkctrloff = true;
		father = GameObject.Find ("UIRoot").transform;
		changeflag = false;
		enjk = false;
		enchjk = false;
		Instantiate (eloww);
		Instantiate (loww);
		lowpoi = GameObject.Find ("low(Clone)").transform;
		elowpoi = GameObject.Find ("elow(Clone)").transform;
		effectctrl.father = lowpoi;
		effectctrl.mother = elowpoi;
		sonicflag = false;
		GameObject.Find ("low(Clone)").transform.parent = father;
		GameObject.Find ("low(Clone)").transform.localPosition = new Vector3 (-8000, -1200, 0);
		GameObject.Find ("elow(Clone)").transform.parent = father;
		GameObject.Find ("elow(Clone)").transform.localPosition = new Vector3 (-8000, 900, 0);
		isspc = false;
		cardeffect.test = false;
		bpm.test = false;
		newtempoeneny.iseba = false;
		newtempoeneny.isegu = false;
		newtempoeneny.isesm = false;
		newtempoeneny.isepi = false;
		scriptchange.guchange = false;
		scriptchange.painochange = false;
		scriptchange.basschange = false;
		scriptchange.smallchange = false;
		origin.sonic = false;
		damage.isdamage = 0;
	}

	// Update is called once per frame
	void Update ()
	{
	
		if (!pause.stop) {
			if (Input.GetKeyDown (KeyCode.K) && changeflag == true) {

				changeflag = false;
				jk = false;
				Destroy (GameObject.Find ("high(Clone)").gameObject);
				Instantiate (loww);
				lowpoi = GameObject.Find ("low(Clone)").transform;
				effectctrl.father = lowpoi;
				GameObject.Find ("low(Clone)").transform.parent = father;
				GameObject.Find ("low(Clone)").transform.localPosition = new Vector3 (-8000, -1200, 0);
				sonicflag = true;
		
			} else if (Input.GetKeyDown (KeyCode.K) && changeflag == false) {
				changeflag = true;
				jk = true;
				Destroy (GameObject.Find ("low(Clone)").gameObject);
				Instantiate (highh);
				highpoi = GameObject.Find ("high(Clone)").transform;
				effectctrl.father = highpoi;
				GameObject.Find ("high(Clone)").transform.parent = father;
				GameObject.Find ("high(Clone)").transform.localPosition = new Vector3 (-4000, -1200, 0);
				sonicflag = true;
		
			}

			if (jkctrloff) {
				if (enjk == true && enchjk == true) {
			
					enchjk = false;
					enjk = false;
					Destroy (GameObject.Find ("ehigh(Clone)").gameObject);
					Instantiate (eloww);
					elowpoi = GameObject.Find ("elow(Clone)").transform;
					effectctrl.mother = elowpoi;
					GameObject.Find ("elow(Clone)").transform.parent = father;
					GameObject.Find ("elow(Clone)").transform.localPosition = new Vector3 (-8000, 900, 0);
			
				} else if (enjk == false && enchjk == true) {
					enchjk = false;
					enjk = true;
					Destroy (GameObject.Find ("elow(Clone)").gameObject);
					Instantiate (ehighh);
					ehighpoi = GameObject.Find ("ehigh(Clone)").transform;
					effectctrl.mother = ehighpoi;
					GameObject.Find ("ehigh(Clone)").transform.parent = father;
					GameObject.Find ("ehigh(Clone)").transform.localPosition = new Vector3 (-4000, 900, 0);
			
			
				}
			}
			if (Input.GetKeyDown (KeyCode.Q) && ishand [0] == true) {
			
				string find0 = GameObject.Find ("UIRoot/0").GetComponent<UITexture> ().mainTexture.name;
				if (isspc == false) {
					aaaaa.drawcombo = 0;
					cardeffect.nextcard = find0;
					ishand [0] = false;
					GameObject.Find ("UIRoot/0").GetComponent<carddis> ().poi = true;
					//Destroy(GameObject.Find("UIRoot/0").gameObject);
				} else if (isspc == true && find0 != "70" && find0 != "71" && find0 != "72" && find0 != "72" && find0 != "76" && find0 != "77" && find0 != "78" && find0 != "79" && find0 != "80") {
					aaaaa.drawcombo = 0;
					cardeffect.nextcard = find0;
					ishand [0] = false;
					GameObject.Find ("UIRoot/0").GetComponent<carddis> ().poi = true;
					//Destroy(GameObject.Find("UIRoot/0").gameObject);


				}
			
			}
			if (Input.GetKeyDown (KeyCode.W) && ishand [1] == true) {
				string find0 = GameObject.Find ("UIRoot/1").GetComponent<UITexture> ().mainTexture.name;
				if (isspc == false) {
					aaaaa.drawcombo = 0;
					cardeffect.nextcard = find0;
					ishand [1] = false;
					GameObject.Find ("UIRoot/1").GetComponent<carddis> ().poi = true;
				} else if (isspc == true && find0 != "70" && find0 != "71" && find0 != "72" && find0 != "72" && find0 != "76" && find0 != "77" && find0 != "78" && find0 != "79" && find0 != "80") {
					aaaaa.drawcombo = 0;
					cardeffect.nextcard = find0;
					ishand [1] = false;
					GameObject.Find ("UIRoot/1").GetComponent<carddis> ().poi = true;
					;
				
				
				}
			}
			if (Input.GetKeyDown (KeyCode.E) && ishand [2] == true) {
				string find0 = GameObject.Find ("UIRoot/2").GetComponent<UITexture> ().mainTexture.name;
				if (isspc == false) {
					aaaaa.drawcombo = 0;
					cardeffect.nextcard = find0;
					ishand [2] = false;
					GameObject.Find ("UIRoot/2").GetComponent<carddis> ().poi = true;
				} else if (isspc == true && find0 != "70" && find0 != "71" && find0 != "72" && find0 != "72" && find0 != "76" && find0 != "77" && find0 != "78" && find0 != "79" && find0 != "80") {
					aaaaa.drawcombo = 0;
					cardeffect.nextcard = find0;
					ishand [2] = false;
					GameObject.Find ("UIRoot/2").GetComponent<carddis> ().poi = true;
					;
				
				
				}
			}
			if (Input.GetKeyDown (KeyCode.R) && ishand [3] == true) {
				string find0 = GameObject.Find ("UIRoot/3").GetComponent<UITexture> ().mainTexture.name;
				if (isspc == false) {
					aaaaa.drawcombo = 0;
					cardeffect.nextcard = find0;
					ishand [3] = false;
					GameObject.Find ("UIRoot/3").GetComponent<carddis> ().poi = true;
				} else if (isspc == true && find0 != "70" && find0 != "71" && find0 != "72" && find0 != "72" && find0 != "76" && find0 != "77" && find0 != "78" && find0 != "79" && find0 != "80") {
					aaaaa.drawcombo = 0;
					cardeffect.nextcard = find0;
					ishand [3] = false;
					GameObject.Find ("UIRoot/3").GetComponent<carddis> ().poi = true;
				
				
				}
			}
			if (Input.GetKeyDown (KeyCode.T) && ishand [4] == true) {
				string find0 = GameObject.Find ("UIRoot/4").GetComponent<UITexture> ().mainTexture.name;
				if (isspc == false) {
					aaaaa.drawcombo = 0;
					cardeffect.nextcard = find0;
					ishand [4] = false;
					GameObject.Find ("UIRoot/4").GetComponent<carddis> ().poi = true;
				} else if (isspc == true && find0 != "70" && find0 != "71" && find0 != "72" && find0 != "72" && find0 != "76" && find0 != "77" && find0 != "78" && find0 != "79" && find0 != "80") {
					aaaaa.drawcombo = 0;
					cardeffect.nextcard = find0;
					ishand [4] = false;
					GameObject.Find ("UIRoot/4").GetComponent<carddis> ().poi = true;
					;
				}
			}
		}
	}
}
