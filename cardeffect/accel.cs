using UnityEngine;
using System.Collections;

public class accel : MonoBehaviour {
	byte nowcard;
	float effecttime;
	public float passtime;
	public GameObject speed;
	public GameObject slow;
	bool jk;
	bool inin;

	void Start () {
		inin = true;
		nowcard = cardeffect.nowcard;
		cardeffect.nowcard = 0;
		if (!cardeffect.test) {
						jk = GameObject.Find ("UIRoot").GetComponent<bactrl> ().jk;
		} else if (cardeffect.test) {
				
			jk=teach.jk;
		
		}
		if (jk == false) {
						cardeffect.isaciru = true;		
			this.name="accelj";
			GameObject.Find("accelSE").GetComponent<AudioSource>().Play();
				} else if (jk == true) {
			this.name="accelk";

			cardeffect.isaciruk=true;
			this.GetComponent<AudioSource>().Play();
		}

	}
	
	void Update () {
	


		passtime += Time.deltaTime;
		switch (nowcard) {

		case 39:

			effecttime = 5f;
			if(jk==false)
			{newtempoeneny.meslowdown=1.5f;
				if(inin){
					Instantiate(speed,new Vector3(15,15,0),Quaternion.identity);


					inin=false;
				}
			}
			else if(jk==true)
			{
				newtempoeneny.meslowdown=0.8f;
				if(inin){
					Instantiate(slow,new Vector3(-15,15,0),Quaternion.identity);

					inin=false;
				}

			}
			if (passtime >= effecttime) {
				if(jk==false)
				{
					newtempoeneny.meslowdown=1f;
					cardeffect.isaciru = false;
					Destroy(GameObject.Find("SPEEDGOGO(Clone)").gameObject);
				}
				else if(jk==true)
				{
					newtempoeneny.meslowdown=1f;
					Destroy(GameObject.Find("SPEEDSLOW(Clone)").gameObject);
					cardeffect.isaciruk=false;
				}
				
				Destroy(this.gameObject);
				
			}
			break;
		case 40:
			effecttime = 10f;
			if(jk==false)
			{
				newtempoeneny.meslowdown=1.5f;
			if(inin){
			Instantiate(speed,new Vector3(15,15,0),Quaternion.identity);
					inin=false;}
			}
			else if(jk==true)
			{
				newtempoeneny.meslowdown=0.8f;
				if(inin){
					Instantiate(slow,new Vector3(-15,15,0),Quaternion.identity);
					
					inin=false;
				}
			}
			if (passtime >= effecttime) {
				if(jk==false)
				{
					newtempoeneny.meslowdown=1f;
					cardeffect.isaciru = false;
					Destroy(GameObject.Find("SPEEDGOGO(Clone)").gameObject);
				}
				else if(jk==true)
				{
					newtempoeneny.meslowdown=1f;
					Destroy(GameObject.Find("SPEEDSLOW(Clone)").gameObject);
					cardeffect.isaciruk=false;
				}
				
				Destroy(this.gameObject);
				
			}
			break;
		case 41:
			effecttime = 15f;
			if(jk==false)
			{newtempoeneny.meslowdown=1.5f;
				if(inin){
					Instantiate(speed,new Vector3(15,15,0),Quaternion.identity);
					
					inin=false;
				}}
			else if(jk==true)
			{
				newtempoeneny.meslowdown=0.8f;
				if(inin){
					Instantiate(slow,new Vector3(-15,15,0),Quaternion.identity);
					
					inin=false;
				}
			}
			if (passtime >= effecttime) {
				if(jk==false)
				{
					newtempoeneny.meslowdown=1f;
					cardeffect.isaciru = false;
					Destroy(GameObject.Find("SPEEDGOGO(Clone)").gameObject);
				}
				else if(jk==true)
				{
					newtempoeneny.meslowdown=1f;
					Destroy(GameObject.Find("SPEEDSLOW(Clone)").gameObject);
					cardeffect.isaciruk=false;
				}
				
				Destroy(this.gameObject);
				
			}
			break;
		case 42:
			effecttime = 5f;
			if(jk==false)
			{newtempoeneny.meslowdown=2f;
				if(inin){
					Instantiate(speed,new Vector3(15,15,0),Quaternion.identity);
					
					inin=false;
				}}
			else if(jk==true)
			{
				newtempoeneny.meslowdown=0.6f;
				if(inin){
					Instantiate(slow,new Vector3(-15,15,0),Quaternion.identity);
					
					inin=false;
				}
			}
			if (passtime >= effecttime) {
				if(jk==false)
				{
					newtempoeneny.meslowdown=1f;
					cardeffect.isaciru = false;
					Destroy(GameObject.Find("SPEEDGOGO(Clone)").gameObject);
				}
				else if(jk==true)
				{
					newtempoeneny.meslowdown=1f;
					Destroy(GameObject.Find("SPEEDSLOW(Clone)").gameObject);
					cardeffect.isaciruk=false;
				}
				
				Destroy(this.gameObject);
				
			}
			break;
		case 43:
			effecttime = 10f;
			if(jk==false)
			{newtempoeneny.meslowdown=2f;
				if(inin){
					Instantiate(speed,new Vector3(15,15,0),Quaternion.identity);
					
					inin=false;
				}}
			else if(jk==true)
			{
				newtempoeneny.meslowdown=0.6f;
				if(inin){
					Instantiate(slow,new Vector3(-15,15,0),Quaternion.identity);
					
					inin=false;
				}
			}
			if (passtime >= effecttime) {
				if(jk==false)
				{
					newtempoeneny.meslowdown=1f;
					cardeffect.isaciru = false;
					Destroy(GameObject.Find("SPEEDGOGO(Clone)").gameObject);
				}
				else if(jk==true)
				{
					newtempoeneny.meslowdown=1f;
					Destroy(GameObject.Find("SPEEDSLOW(Clone)").gameObject);
					cardeffect.isaciruk=false;
				}
				
				Destroy(this.gameObject);
				
			}
			break;
		case 44:
			effecttime = 15f;
			if(jk==false)
			{
				newtempoeneny.meslowdown=2f;
				if(inin){
					Instantiate(speed,new Vector3(15,15,0),Quaternion.identity);

					inin=false;
				}
			}
		
			else if(jk==true)
			{
				newtempoeneny.meslowdown=0.6f;
				if(inin){
					Instantiate(slow,new Vector3(-15,15,0),Quaternion.identity);
					
					inin=false;
				}
				
			}
			if (passtime >= effecttime) {
				if(jk==false)
				{
					newtempoeneny.meslowdown=1f;
					cardeffect.isaciru = false;
					Destroy(GameObject.Find("SPEEDGOGO(Clone)").gameObject);
				}
				else if(jk==true)
				{
					newtempoeneny.meslowdown=1f;
					cardeffect.isaciruk=false;
					Destroy(GameObject.Find("SPEEDSLOW(Clone)").gameObject);
				}
				
				Destroy(this.gameObject);
				
			}
			break;
		case 45:
			effecttime = 5f;
			if(jk==false)
			{newtempoeneny.meslowdown=3f;
				if(inin){
					Instantiate(speed,new Vector3(15,15,0),Quaternion.identity);
					
					inin=false;
				}}
			else if(jk==true)
			{
				newtempoeneny.meslowdown=0.4f;
				if(inin){
					Instantiate(slow,new Vector3(-15,15,0),Quaternion.identity);
					
					inin=false;
				}
			}
			if (passtime >= effecttime) {
				if(jk==false)
				{
					newtempoeneny.meslowdown=1f;
					cardeffect.isaciru = false;
					Destroy(GameObject.Find("SPEEDGOGO(Clone)").gameObject);
				}
				else if(jk==true)
				{
					newtempoeneny.meslowdown=1f;
					Destroy(GameObject.Find("SPEEDSLOW(Clone)").gameObject);
					cardeffect.isaciruk=false;
				}
				
				Destroy(this.gameObject);
				
			}
			break;
		case 46:
			effecttime = 10f;
			if(jk==false)
			{newtempoeneny.meslowdown=3f;
				if(inin){
					Instantiate(speed,new Vector3(15,15,0),Quaternion.identity);
					
					inin=false;
				}}
			else if(jk==true)
			{
				newtempoeneny.meslowdown=0.4f;
				if(inin){
					Instantiate(slow,new Vector3(-15,15,0),Quaternion.identity);
					
					inin=false;
				}
			}
			if (passtime >= effecttime) {
				if(jk==false)
				{
					newtempoeneny.meslowdown=1f;
					cardeffect.isaciru = false;
					Destroy(GameObject.Find("SPEEDGOGO(Clone)").gameObject);
				}
				else if(jk==true)
				{
					newtempoeneny.meslowdown=1f;
					Destroy(GameObject.Find("SPEEDSLOW(Clone)").gameObject);
					cardeffect.isaciruk=false;
				}
				
				Destroy(this.gameObject);
				
			}
			break;
		case 47:
			effecttime = 15f;
			if(jk==false)
			{newtempoeneny.meslowdown=3f;
				if(inin){
					Instantiate(speed,new Vector3(15,15,0),Quaternion.identity);
					
					inin=false;
				}}
			else if(jk==true)
			{
				newtempoeneny.meslowdown=0.4f;
				if(inin){
					Instantiate(slow,new Vector3(-15,15,0),Quaternion.identity);
					
					inin=false;
				}
			}
			if (passtime >= effecttime) {
				if(jk==false)
				{
					newtempoeneny.meslowdown=1f;
				cardeffect.isaciru = false;
					Destroy(GameObject.Find("SPEEDGOGO(Clone)").gameObject);
				}
				else if(jk==true)
				{
					newtempoeneny.meslowdown=1f;
					Destroy(GameObject.Find("SPEEDSLOW(Clone)").gameObject);
					cardeffect.isaciruk=false;
				}

				Destroy(this.gameObject);
				
			}
			break;




				}

	}
}
