using UnityEngine;
using System.Collections;

public class cardeffect : MonoBehaviour {


	public static string nextcard;

	public GameObject change;
	public GameObject damageupp;
	public GameObject accel;
	public GameObject reduce;
	public GameObject vis;
	public GameObject duoo;
	public GameObject soul;
	public GameObject no;
	public GameObject weak;
	public GameObject powerbone;
	public GameObject bass;
	public GameObject ori;
	public GameObject jkctrl;
	public UITexture dark;
	public GameObject boom;
	public GameObject dmgheal;
	public GameObject rucard;
	public float effecttime;
	public float passtime;
	public static bool ischiru=false;
	public static bool isdairu=false;
	public static bool isaciru=false;
	public static bool isaciruk = false;
	public static bool isreiru=false;
	public static bool isviiru=false;
	public static bool isduiru=false;
	public static bool isnoiru=false;
	public static bool test;
	public static byte nowcard;


	void Start () {
		ischiru=false;
		isdairu=false;
		isaciru=false;
		isaciruk=false;
		isreiru=false;
		isviiru=false;
		isduiru=false;
		isnoiru=false;

	}
	
	void Update () {
	
		if (System.Convert.ToInt32(nextcard) != nowcard) 
		{






			nowcard=System.Convert.ToByte(nextcard);
			nextcard="0";
			passtime=0f;


		}
	

		passtime += Time.deltaTime;

		switch (nowcard) {
		case 0:
			break;
		case 1:
		case 2:
		case 3:
		case 4:
		case 5:
		case 6:
		case 7:
		case 8:
		case 9:
		case 10:
		case 11:
		case 12:
		case 13:
		case 14:
		case 15:
		case 16:
		case 17:
		case 18:
		case 19:
		case 20:
		case 21:
		case 22:
		case 23:
		case 24:

			if(ischiru){
				ischiru=false;
				bpm.tempobpm = 0.8f;
				Destroy(GameObject.Find("change(Clone)").gameObject);
			}

			Instantiate(change);

			break;
		case 25:
		case 26:
		case 27:
		case 28:
		case 29:
		case 30:
		case 31:
		case 32:
		case 33:
		case 34:
		case 35:
		case 36:
		case 37:
		case 38:
			if(isdairu){
				Destroy (GameObject.Find ("456789(Clone)").gameObject);
				isdairu=false;
				Destroy(GameObject.Find("damageup(Clone)").gameObject);
			}

			Instantiate(damageupp);
			break;

		case 39:
		case 40:
		case 41:
		case 42:
		case 43:
		case 44:
		case 45:
		case 46:
		case 47:
			if(!test){
			if(isaciru==true && GameObject.Find("UIRoot").GetComponent<bactrl>().jk==false){
				isaciru=false;
				Destroy(GameObject.Find("SPEEDGOGO(Clone)").gameObject);
				Destroy(GameObject.Find("accelj").gameObject);
			}
			if(isaciruk==true && GameObject.Find("UIRoot").GetComponent<bactrl>().jk==true)
			{
				isaciruk=false;
				Destroy(GameObject.Find("SPEEDSLOW(Clone)").gameObject);
				Destroy(GameObject.Find("accelk").gameObject);
			}
			}


			Instantiate(accel);
			break;
		case 48:
		case 49:
		case 50:
			if(isreiru){
				isreiru=false;
				Destroy(GameObject.Find("reduce(Clone)").gameObject);
			}
			Instantiate(reduce);
			break;
		case 51:
		case 52:
		case 53:
			Instantiate(dark);
		
			break;
		case 54:
		case 55:
		case 56:
			if(isviiru){
				isviiru=false;
				Destroy(GameObject.Find("vis(Clone)").gameObject);
			}
			Instantiate(vis);
			break;
		case 57:


			GameObject.Find("todoke").GetComponent<AudioSource>().Play();
			if(GameObject.Find("UIRoot").GetComponent<bactrl>().jk==false){
				GameObject.Find("backgr").GetComponent<Animator>().SetBool("cibeat",true);
				GameObject.Find("backgr").GetComponent<Animator>().SetBool("cibeatback",true);
			foreach(GameObject fooObj in GameObject.FindGameObjectsWithTag("early"))
			{
				
				if(fooObj.name == "ennoeff(Clone)")
				{
					fooObj.GetComponent<newtempoeneny>().give=true;
				}
				if(fooObj.name == "du(Clone)")
				{
					fooObj.GetComponent<dudu>().give=true;
				}
				}
			
			}else if(GameObject.Find("UIRoot").GetComponent<bactrl>().jk==true)
			{
				Instantiate(Resources.Load("flyboommany"),new Vector3(0,-0.8f,0),Quaternion.identity);
				GameObject.Find("give").GetComponent<AudioSource>().Play();
				foreach(GameObject fooObj in GameObject.FindGameObjectsWithTag("early"))
				{
					if(fooObj.name == "noeff(Clone)")
					{
						fooObj.GetComponent<newtempo>().todoke=true;
					}
					if(fooObj.name == "due(Clone)")
					{
						fooObj.GetComponent<dudue>().todoke=true;
					}
				}


			}
			break;
		case 58:

			Instantiate(jkctrl);

			break;
		case 59:
		case 60:
		case 61:
			if(isduiru){
				isduiru=false;
				Destroy(GameObject.Find("duo(Clone)").gameObject);
			}
			GameObject dd=(GameObject)Instantiate(duoo);
			dd.GetComponent<newduo>().num=nowcard;
			nowcard=0;
			break;
		case 62:
		case 63:
			Instantiate(no);
			break;
		case 64:
		case 65:
		case 66:
			GameObject bo=(GameObject)Instantiate(boom);
			bo.GetComponent<boom>().num=nowcard;
			nowcard=0;
			break;
		case 67:
		case 68:
		case 69:
			GameObject dm=(GameObject)Instantiate(dmgheal);
			dm.GetComponent<dmgheal>().num=nowcard;
			nowcard=0;
			break;
		case 70:
			Instantiate(soul);
			break;
		case 71:
			Instantiate(weak);
			break;
		case 72:
			Instantiate(powerbone);
			break;
		case 73:
		case 74:
		case 75:
			GameObject ru=(GameObject)Instantiate(rucard);
			ru.GetComponent<rucard>().num=nowcard;
			nowcard=0;
			break;
			break;
		case 80:
			Instantiate(ori);

			
			break;


				}




	}
}
