using UnityEngine;
using System.Collections;

public class damage : MonoBehaviour {
	public GameObject defupup;
	public static bool isgu;
	public static bool isbass;
	public static bool ispiano;
	public static bool issmall;
	public static bool ispois;
	public static bool issonic;
	public static bool isksonic;
	public static bool isksmall;
	public static bool iskpiano;
	public static float isdamage;

	public static float damageupper=1.0f;
	public static float damageuppergu=1.0f;
	public static float damageuppersm=1.0f;
	public static float damageupperpi=1.0f;
	public static float damageupperba=1.0f;
	public static bool isdeffdown;
	public static float hitpois=1.0f;
	public static byte weakdamage=1;
	public static byte powerboneup=0;
	public static float combodamage=1.0f;
	void Start () {
		 
		
		 damageupper=1.0f;
		damageuppergu=1.0f;
		damageuppersm=1.0f;
		 damageupperpi=1.0f;
		damageupperba=1.0f;
		isdeffdown=false;
		hitpois=1.0f;
		weakdamage=1;
		powerboneup=0;
		combodamage=1.0f;
	}
	
	void Update () {





		if (isgu) {
			isgu=false;
		

			isdamage=charstuas.nowatk*0.8f*1.1f*damageupper*(damageuppergu+(float)powerboneup)*(float)weakdamage*combodamage*hitpois;
			dmgheal.dmg=isdamage;
				}
		if (isbass) {
			isbass=false;
			isdeffdown=true;

			
			isdamage=charstuas.nowatk*0.8f*damageupper*(damageupperba+(float)powerboneup)*(float)weakdamage*combodamage*hitpois;
			dmgheal.dmg=isdamage;
		}
		if (ispiano) {
			ispiano=false;



			Instantiate(defupup);
			isdamage=charstuas.nowatk*0.8f*damageupper*(damageupperpi+(float)powerboneup)*(float)weakdamage*combodamage*hitpois;
			dmgheal.dmg=isdamage;
		}
		if (issmall) {
			issmall=false;

			isdamage=charstuas.nowatk*0.8f*0.5f*(damageuppersm+(float)powerboneup)*damageupper*hitpois;
			dmgheal.dmg=isdamage;
			charstuas.nowhp+=PlayerPrefs.GetFloat("REC")*(damageuppersm+(float)powerboneup)*(float)weakdamage*combodamage*damageupper*hitpois;
			if(charstuas.nowhp>charstuas.maxhp)
			{
				charstuas.nowhp=charstuas.maxhp;
			}
			
		}
		if (iskpiano) {
			iskpiano=false;		
			float isdamageturndef=charstuas.nowatk*0.8f*(damageuppersm+(float)powerboneup)*0.5f*combodamage*damageupper*hitpois;
			charstuas.nowdeff+=isdamageturndef*0.05f;
			isdamage=isdamageturndef;
			dmgheal.dmg=isdamage;
		
		}
		if (isksmall) {
			isksmall=false;		
			float rec=PlayerPrefs.GetFloat("REC");
			isdamage=rec*(damageuppersm+(float)powerboneup)*(float)weakdamage*combodamage*damageupper*hitpois-rec;
			dmgheal.dmg=isdamage;
			charstuas.nowhp+=rec;
			if(charstuas.nowhp>charstuas.maxhp)
			{
				charstuas.nowhp=charstuas.maxhp;
			}

		}
		if(issonic){
			issonic=false;
			isdeffdown=true;
		
			isdamage=charstuas.nowatk*0.8f*1.1f*damageupper*damageuppergu*damageupperpi*damageuppersm*combodamage*damageupperba*hitpois;
			dmgheal.dmg=isdamage;
			Instantiate(defupup);
			charstuas.nowhp+=PlayerPrefs.GetFloat("REC")*damageuppersm;


		}

		if (isksonic) {
				
			isksonic=false;
			float rec=PlayerPrefs.GetFloat("REC");
			float isdamageturndef=charstuas.nowatk*0.8f*damageuppersm*0.5f*combodamage*damageupper*hitpois;
			charstuas.nowdeff+=isdamageturndef*0.3f;
			isdamage=isdamageturndef-rec;
			dmgheal.dmg=isdamage;
			charstuas.nowhp+=rec;
			if(charstuas.nowhp>charstuas.maxhp)
			{
				charstuas.nowhp=charstuas.maxhp;
			}
		}
	
	}
}
