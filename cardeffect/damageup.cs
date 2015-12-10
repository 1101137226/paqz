using UnityEngine;
using System.Collections;

public class damageup : MonoBehaviour {
	byte nowcard;
	float effecttime;
	public float passtime;
	// Use this for initialization
	void Start () {
		cardeffect.isdairu = true;
		damage.damageupper=1.0f;
		damage.damageuppergu=1.0f;
		damage.damageuppersm=1.0f;
		damage.damageupperpi=1.0f;
		damage.damageupperba=1.0f;

		nowcard = cardeffect.nowcard;
		cardeffect.nowcard = 0;


		Instantiate(Resources.Load("456789"));
	}
	
	// Update is called once per frame
	void Update () {
	



		passtime += Time.deltaTime;
		switch (nowcard) {
		case 25:

			damage.damageuppergu=1.5f;
			effecttime=15f;
			if(passtime>=effecttime)
			{damage.damageuppergu=1f;cardeffect.isdairu = false;Destroy (GameObject.Find ("456789(Clone)").gameObject);Destroy(this.gameObject);}
				break;
		case 26:
			damage.damageuppergu=2.0f;
			effecttime=13f;
			if(passtime>=effecttime)
			{damage.damageuppergu=1f;cardeffect.isdairu = false;Destroy (GameObject.Find ("456789(Clone)").gameObject);Destroy(this.gameObject);}
			break;
		case 27:
			damage.damageuppergu=3.0f;
			effecttime=10f;
			if(passtime>=effecttime)
			{damage.damageuppergu=1f;cardeffect.isdairu = false;Destroy (GameObject.Find ("456789(Clone)").gameObject);Destroy(this.gameObject);}
			break;
		case 28:
			damage.damageupperba=1.5f;
			effecttime=15f;
			if(passtime>=effecttime)
			{damage.damageupperba=1f;cardeffect.isdairu = false;Destroy (GameObject.Find ("456789(Clone)").gameObject);Destroy(this.gameObject);}
			break;
		case 29:
			damage.damageupperba=2.0f;
			effecttime=13f;
			if(passtime>=effecttime)
			{damage.damageupperba=1f;cardeffect.isdairu = false;Destroy (GameObject.Find ("456789(Clone)").gameObject);Destroy(this.gameObject);}
			break;
		case 30:
			damage.damageupperba=3.0f;
			effecttime=10f;
			if(passtime>=effecttime)
			{damage.damageupperba=1f;cardeffect.isdairu = false;Destroy (GameObject.Find ("456789(Clone)").gameObject);Destroy(this.gameObject);}
			break;
		case 31:
			damage.damageuppersm=1.5f;
			effecttime=15f;
			if(passtime>=effecttime)
			{damage.damageuppersm=1f;cardeffect.isdairu = false;Destroy (GameObject.Find ("456789(Clone)").gameObject);Destroy(this.gameObject);}
			break;
		case 32:
			damage.damageuppersm=2.0f;
			effecttime=13f;
			if(passtime>=effecttime)
			{damage.damageuppersm=1f;cardeffect.isdairu = false;Destroy (GameObject.Find ("456789(Clone)").gameObject);Destroy(this.gameObject);}
			break;
		case 33:
			damage.damageuppersm=3.0f;
			effecttime=10f;
			if(passtime>=effecttime)
			{damage.damageuppersm=1f;cardeffect.isdairu = false;Destroy (GameObject.Find ("456789(Clone)").gameObject);Destroy(this.gameObject);}
			break;
		case 34:
			damage.damageupperpi=1.5f;
			effecttime=15f;
			if(passtime>=effecttime)
			{damage.damageupperpi=1f;cardeffect.isdairu = false;Destroy (GameObject.Find ("456789(Clone)").gameObject);Destroy(this.gameObject);}
			break;
		case 35:
			damage.damageupperpi=2.0f;
			effecttime=13f;
			if(passtime>=effecttime)
			{damage.damageupperpi=1f;cardeffect.isdairu = false;Destroy (GameObject.Find ("456789(Clone)").gameObject);Destroy(this.gameObject);}
			break;
		case 36:
			damage.damageupperpi=3.0f;
			effecttime=10f;
			if(passtime>=effecttime)
			{damage.damageupperpi=1f;cardeffect.isdairu = false;Destroy (GameObject.Find ("456789(Clone)").gameObject);Destroy(this.gameObject);}
			break;
		case 37:
			damage.damageupper=1.5f;
			effecttime=13f;
			if(passtime>=effecttime)
			{damage.damageupper=1f;cardeffect.isdairu = false;Destroy (GameObject.Find ("456789(Clone)").gameObject);Destroy(this.gameObject);}
			break;
		case 38:
			damage.damageuppergu=2.0f;
			effecttime=10f;
			if(passtime>=effecttime)
			{damage.damageupper=1f;cardeffect.isdairu = false;Destroy (GameObject.Find ("456789(Clone)").gameObject);Destroy(this.gameObject);}
			break;
		
		

				}

	}
}
