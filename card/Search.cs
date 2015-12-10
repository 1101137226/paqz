using UnityEngine;
using System.Collections;

public class Search : MonoBehaviour
{
		public UILabel att;
		public UIGrid grid;
		public GameObject ccc;
		byte flag;

		public void Srart ()
		{
				flag = 0;
		}

		public void OnPress (bool ispress)
		{
				if (ispress) {


						for (int q=1; q<=80; q++) {
								if (att.text == "Wind") {
										if (PlayerPrefs.GetInt (q + "_Get") == 1 && PlayerPrefs.GetString (q + "_Att") == "W") {
												Instantiate (Resources.Load ("SEARCH/" + System.Convert.ToString (q)));
												if (flag != 1) {
														foreach (Transform child in ccc.transform) {
																GameObject.Destroy (child.gameObject);
														}
												}

												GameObject.Find (System.Convert.ToString (q) + "(Clone)").transform.parent = grid.transform;
						
												GameObject.Find (System.Convert.ToString (q) + "(Clone)").transform.localPosition = new Vector3 (0, 0, 0);
												GameObject.Find (System.Convert.ToString (q) + "(Clone)").transform.localScale = new Vector3 (1, 1, 1);
												GameObject.Find (System.Convert.ToString (q) + "(Clone)").name = "SEA_" + System.Convert.ToString (q);
						
												flag = 1;
										}
								}
								if (att.text == "Keyboard") {
										if (PlayerPrefs.GetInt (q + "_Get") == 1 && PlayerPrefs.GetString (q + "_Att") == "K") {
												Instantiate (Resources.Load ("SEARCH/" + System.Convert.ToString (q)));
												if (flag != 2) {
														foreach (Transform child in ccc.transform) {
																GameObject.Destroy (child.gameObject);
														}
												}
						
												GameObject.Find (System.Convert.ToString (q) + "(Clone)").transform.parent = grid.transform;
						
												GameObject.Find (System.Convert.ToString (q) + "(Clone)").transform.localPosition = new Vector3 (0, 0, 0);
												GameObject.Find (System.Convert.ToString (q) + "(Clone)").transform.localScale = new Vector3 (1, 1, 1);
												GameObject.Find (System.Convert.ToString (q) + "(Clone)").name = "SEA_" + System.Convert.ToString (q);
						
												flag = 2;
										}
								}
								if (att.text == "Percussion") {
										if (PlayerPrefs.GetInt (q + "_Get") == 1 && PlayerPrefs.GetString (q + "_Att") == "P") {
												Instantiate (Resources.Load ("SEARCH/" + System.Convert.ToString (q)));
												if (flag != 3) {
														foreach (Transform child in ccc.transform) {
																GameObject.Destroy (child.gameObject);
														}
												}
						
												GameObject.Find (System.Convert.ToString (q) + "(Clone)").transform.parent = grid.transform;
						
												GameObject.Find (System.Convert.ToString (q) + "(Clone)").transform.localPosition = new Vector3 (0, 0, 0);
												GameObject.Find (System.Convert.ToString (q) + "(Clone)").transform.localScale = new Vector3 (1, 1, 1);
												GameObject.Find (System.Convert.ToString (q) + "(Clone)").name = "SEA_" + System.Convert.ToString (q);
						
												flag = 3;
										}
								}
								if (att.text == "Chordophone") {
										if (PlayerPrefs.GetInt (q + "_Get") == 1 && PlayerPrefs.GetString (q + "_Att") == "C") {
												Instantiate (Resources.Load ("SEARCH/" + System.Convert.ToString (q)));
												if (flag != 4) {
														foreach (Transform child in ccc.transform) {
																GameObject.Destroy (child.gameObject);
														}
												}
						
												GameObject.Find (System.Convert.ToString (q) + "(Clone)").transform.parent = grid.transform;
						
												GameObject.Find (System.Convert.ToString (q) + "(Clone)").transform.localPosition = new Vector3 (0, 0, 0);
												GameObject.Find (System.Convert.ToString (q) + "(Clone)").transform.localScale = new Vector3 (1, 1, 1);
												GameObject.Find (System.Convert.ToString (q) + "(Clone)").name = "SEA_" + System.Convert.ToString (q);
						
												flag = 4;
										}
								}
								if (att.text == "Extra") {
										if (PlayerPrefs.GetInt (q + "_Get") == 1 && PlayerPrefs.GetString (q + "_Att") == "E") {
												Instantiate (Resources.Load ("SEARCH/" + System.Convert.ToString (q)));
												if (flag != 5) {
														foreach (Transform child in ccc.transform) {
																GameObject.Destroy (child.gameObject);
														}
												}
						
												GameObject.Find (System.Convert.ToString (q) + "(Clone)").transform.parent = grid.transform;
						
												GameObject.Find (System.Convert.ToString (q) + "(Clone)").transform.localPosition = new Vector3 (0, 0, 0);
												GameObject.Find (System.Convert.ToString (q) + "(Clone)").transform.localScale = new Vector3 (1, 1, 1);
												GameObject.Find (System.Convert.ToString (q) + "(Clone)").name = "SEA_" + System.Convert.ToString (q);
						
												flag = 5;
										}
								}
						}














						/*
		

			if(att.text=="Wind")
			{

				for(int q=1;q<=80;q++)
				{
					if(	PlayerPrefs.GetInt (q+"_Get")==1 && PlayerPrefs.GetString(q+"_Att")=="W")
				{
				
						Instantiate(Resources.Load("SEARCH/"+System.Convert.ToString(q)));
						if(flag==1)
						{
							foreach(Transform child in ccc.transform)
							{GameObject.Destroy(child.gameObject);}
							flag=0;
						}

						GameObject.Find (System.Convert.ToString(q)+"(Clone)").transform.parent=grid.transform;
						
						GameObject.Find (System.Convert.ToString(q)+"(Clone)").transform.localPosition= new Vector3(0,0,0);
						GameObject.Find (System.Convert.ToString(q)+"(Clone)").transform.localScale=new Vector3(1,1,1);
						GameObject.Find (System.Convert.ToString(q)+"(Clone)").name="SEA_"+System.Convert.ToString(q);

						flag=1;

					grid.repositionNow = true;
				}
				}
			}
			if(att.text=="Keyboard")
			{
				
				for(int q=1;q<=80;q++)
				{
					if(	PlayerPrefs.GetInt (q+"_Get")==1 && PlayerPrefs.GetString(q+"_Att")=="K")
					{
						
						Instantiate(Resources.Load("SEARCH/"+System.Convert.ToString(q)));
						
						if(flag==1)
						{
							foreach(Transform child in ccc.transform)
							{GameObject.Destroy(child.gameObject);}
							flag=0;
						}

						GameObject.Find (System.Convert.ToString(q)+"(Clone)").transform.parent=grid.transform;
						
						GameObject.Find (System.Convert.ToString(q)+"(Clone)").transform.localPosition= new Vector3(0,0,0);
						GameObject.Find (System.Convert.ToString(q)+"(Clone)").transform.localScale=new Vector3(1,1,1);
						GameObject.Find (System.Convert.ToString(q)+"(Clone)").name="SEA_"+System.Convert.ToString(q);
						flag=1;
						grid.repositionNow = true;
					}
				}
			}
			if(att.text=="Percussion")
			{
				
				for(int q=1;q<=80;q++)
				{
					if(	PlayerPrefs.GetInt (q+"_Get")==1 && PlayerPrefs.GetString(q+"_Att")=="P")
					{
						
						Instantiate(Resources.Load("SEARCH/"+System.Convert.ToString(q)));
						if(flag==1)
						{
							foreach(Transform child in ccc.transform)
							{GameObject.Destroy(child.gameObject);}
							flag=0;

						}


						GameObject.Find (System.Convert.ToString(q)+"(Clone)").transform.parent=grid.transform;

						GameObject.Find (System.Convert.ToString(q)+"(Clone)").transform.localPosition= new Vector3(0,0,0);
						GameObject.Find (System.Convert.ToString(q)+"(Clone)").transform.localScale=new Vector3(1,1,1);
						GameObject.Find (System.Convert.ToString(q)+"(Clone)").name="SEA_"+System.Convert.ToString(q);
						flag=1;
						grid.repositionNow = true;
					}
				}
			}
			if(att.text=="Chordophone")
			{
				
				for(int q=1;q<=80;q++)
				{
					if(	PlayerPrefs.GetInt (q+"_Get")==1 && PlayerPrefs.GetString(q+"_Att")=="C")
					{
						
						Instantiate(Resources.Load("SEARCH/"+System.Convert.ToString(q)));
						if(flag==1)
						{
							foreach(Transform child in ccc.transform)
							{GameObject.Destroy(child.gameObject);}
							flag=0;
						}

						GameObject.Find (System.Convert.ToString(q)+"(Clone)").transform.parent=grid.transform;
						
						GameObject.Find (System.Convert.ToString(q)+"(Clone)").transform.localPosition= new Vector3(0,0,0);
						GameObject.Find (System.Convert.ToString(q)+"(Clone)").transform.localScale=new Vector3(1,1,1);
						GameObject.Find (System.Convert.ToString(q)+"(Clone)").name="SEA_"+System.Convert.ToString(q);
						flag=1;
						grid.repositionNow = true;
					}
				}
			}
			if(att.text=="Extra")
			{
				
				for(int q=1;q<=80;q++)
				{
					if(	PlayerPrefs.GetInt (q+"_Get")==1 && PlayerPrefs.GetString(q+"_Att")=="E")
					{
						
						Instantiate(Resources.Load("SEARCH/"+System.Convert.ToString(q)));
						if(flag==1)
						{
							foreach(Transform child in ccc.transform)
							{GameObject.Destroy(child.gameObject);}
							flag=0;
						}

						GameObject.Find (System.Convert.ToString(q)+"(Clone)").transform.parent=grid.transform;
						
						GameObject.Find (System.Convert.ToString(q)+"(Clone)").transform.localPosition= new Vector3(0,0,0);
						GameObject.Find (System.Convert.ToString(q)+"(Clone)").transform.localScale=new Vector3(1,1,1);
						GameObject.Find (System.Convert.ToString(q)+"(Clone)").name="SEA_"+System.Convert.ToString(q);
						flag=1;
						grid.repositionNow = true;
					}
				}
			}
			*/
						grid.repositionNow = true;
				}
		}
}
