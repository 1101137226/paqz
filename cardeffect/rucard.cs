using UnityEngine;
using System.Collections;

public class rucard : MonoBehaviour {
	bool inin;
	float passtime;
	byte mecounter=0;
	byte targetcounter=0;
	public byte num;
	bool ininin;
	void Start () {
		inin = true;
		ininin = true;
	}
	
	void Update () {
		passtime += Time.deltaTime;
		switch(num)
		{
		case 73:
		if(inin && passtime>0.8f && passtime<1.5f)
		{
			for(int i=0;i<5;i++)
			{
				

					if(bactrl.ishand[i]) 
					{
						
						
						bactrl.ishand[i]=false;
						GameObject.Find(i.ToString()).GetComponent<carddis>().poi=true;
						
						mecounter++;
						
						
					}
				
			
				
			}
			
			inin=false;
		}
		
		if(passtime>1.5f && !inin)
		{

				for(int i=0;i<mecounter;i++)
				{
					GameObject.Find("UIRoot").GetComponent<deck>().Draw();
					
					
				}
			

			inin=true;
		}
		if(passtime>1.8f)
		{
			num=0;
		}
		break;
		case 75:

				if(inin)
				{
					int [] b = new int[5];
					
					for(int i=0;i<5;i++)
					{
						if(!bactrl.ishand[i])
						{
							mecounter++;
							
						}else if(bactrl.ishand[i])
						{
							
							
							b[targetcounter]=i;
							targetcounter++;
						}
						
					}
					if(mecounter==5)
					{
						num=0;
						
					}
					Random.seed = System.Guid.NewGuid().GetHashCode();	
					int j= Random.Range(0,System.Convert.ToInt16(targetcounter));
					
					bactrl.ishand[b[j]]=false;
					GameObject.Find(b[j].ToString()).GetComponent<carddis>().poi=true;

					
					
					inin=false;
				}
				
				if(passtime>1f & ininin)
				{
					GameObject.Find("UIRoot").GetComponent<deck>().Draw();
					GameObject.Find("UIRoot").GetComponent<deck>().Draw();
					
				ininin=false;
				}
				
			
			if(passtime>1.5f)
			{
				
				num=0;
			}
			break;




		}
	}
}
