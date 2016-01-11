using UnityEngine;
using System.Collections;

public class newduo : MonoBehaviour {
	public UITexture duo;
	public float speed;
	public byte num;
	float effecttime;
	public float passtime;
	bool jk;
	GameObject target;
	float efftime;
	float timer;
	byte jtimes;
	short startcombo;
	short nowcombo;
	short maxcombo;
	void Start () {

		cardeffect.isduiru = true;
		if (num == 59) 
		{
			efftime=5f;
			jtimes=1;
			
		}else if (num == 60) 
		{
			efftime=10f;	
			jtimes=2;
		}else if (num == 61) 
		{
			efftime=15f;	
			jtimes=3;
		}
		
		target = GameObject.Find ("musicgogo").gameObject;
		startcombo = aaaaa.combo;
		jk=GameObject.Find("UIRoot").GetComponent<bactrl>().jk;
	}
	
	void Update () {

		
		passtime += Time.deltaTime;
		if (!jk) {
			
			
			
			if (passtime >= 1.8f && passtime < 5f) {
				
				timer += Time.deltaTime;
				if (timer > 1f) {
					target.GetComponent<bpm>().DUCreat();
					timer = 0f;
					
				}
				
			} else if (passtime >= 5f) {
				passtime = 0;
				jtimes--;
				
			}
			
			if (jtimes == 0) {
				
				Destroy (this.gameObject);
				
			}
			
			
			
		} else if (jk) 
		{
			
			
			if(passtime<efftime)
			{
				short combo=aaaaa.combo;
				if(combo==0)
				{startcombo=0;}
				nowcombo=(short)(combo-startcombo);
				
				if(nowcombo>maxcombo)
				{
					maxcombo=nowcombo;
					
				}
				
				jtimes=(byte)(maxcombo/5);
			}else if(passtime>=efftime)
			{
				
				
				
				
				timer += Time.deltaTime;
				if(timer>1f)
				{
					target.GetComponent<bpm>().DUCreat();
					timer = 0f;
					jtimes--;
				}
				
				if(jtimes==0)
				{
					Destroy(this.gameObject);
					
					
				}
				
				
			}
			
			
			
			
			
		}
		

	
	}
}
