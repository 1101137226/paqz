using UnityEngine;
using System.Collections;

public class DECKDISPLAY : MonoBehaviour {


	
	public static byte flag=0;
	public static byte poi;
	

	
	public UIGrid grid;
	public UIGrid grid2;

	void Start () {
	
				
				PlayerPrefs.SetString ("1_Att", "P");
				
				PlayerPrefs.SetString ("2_Att", "P");
				
				PlayerPrefs.SetString ("3_Att", "P");
				
				PlayerPrefs.SetString ("4_Att", "C");
				
				PlayerPrefs.SetString ("5_Att", "C");
				
				PlayerPrefs.SetString ("6_Att", "C");
				
				PlayerPrefs.SetString ("7_Att", "W");
			
				PlayerPrefs.SetString ("8_Att", "W");
				
				PlayerPrefs.SetString ("9_Att", "W");
				
				PlayerPrefs.SetString ("10_Att", "K");
				
				PlayerPrefs.SetString ("11_Att", "K");
				
				PlayerPrefs.SetString ("12_Att", "K");
				
				PlayerPrefs.SetString ("13_Att", "P");
				
				PlayerPrefs.SetString ("14_Att", "P");
				
				PlayerPrefs.SetString ("15_Att", "P");
				
				PlayerPrefs.SetString ("16_Att", "C");
			
				PlayerPrefs.SetString ("17_Att", "C");
				
				PlayerPrefs.SetString ("18_Att", "C");
				PlayerPrefs.SetString ("19_Att", "W");
				PlayerPrefs.SetString ("20_Att", "W");
				PlayerPrefs.SetString ("21_Att", "W");
				PlayerPrefs.SetString ("22_Att", "K");
				PlayerPrefs.SetString ("23_Att", "K");
				PlayerPrefs.SetString ("24_Att", "K");
				PlayerPrefs.SetString ("25_Att", "P");
				PlayerPrefs.SetString ("26_Att", "P");
				PlayerPrefs.SetString ("27_Att", "P");
				PlayerPrefs.SetString ("28_Att", "C");
				PlayerPrefs.SetString ("29_Att", "C");
				PlayerPrefs.SetString ("30_Att", "C");
				PlayerPrefs.SetString ("31_Att", "W");
				PlayerPrefs.SetString ("32_Att", "W");
				PlayerPrefs.SetString ("33_Att", "W");
				PlayerPrefs.SetString ("34_Att", "K");
				PlayerPrefs.SetString ("35_Att", "K");
				PlayerPrefs.SetString ("36_Att", "K");
				PlayerPrefs.SetString ("37_Att", "E");
				PlayerPrefs.SetString ("38_Att", "E");
				PlayerPrefs.SetString ("39_Att", "E");
				PlayerPrefs.SetString ("40_Att", "E");
				PlayerPrefs.SetString ("41_Att", "E");
				PlayerPrefs.SetString ("42_Att", "E");
				PlayerPrefs.SetString ("43_Att", "E");
				PlayerPrefs.SetString ("44_Att", "E");
				PlayerPrefs.SetString ("45_Att", "E");
				PlayerPrefs.SetString ("46_Att", "E");
				PlayerPrefs.SetString ("47_Att", "E");
				PlayerPrefs.SetString ("48_Att", "E");
				PlayerPrefs.SetString ("49_Att", "E");
				PlayerPrefs.SetString ("50_Att", "E");
				PlayerPrefs.SetString ("51_Att", "E");
				PlayerPrefs.SetString ("52_Att", "E");
				PlayerPrefs.SetString ("53_Att", "E");
				PlayerPrefs.SetString ("54_Att", "E");
				PlayerPrefs.SetString ("55_Att", "E");
				PlayerPrefs.SetString ("56_Att", "E");
				PlayerPrefs.SetString ("57_Att", "E");
				PlayerPrefs.SetString ("58_Att", "E");
				PlayerPrefs.SetString ("59_Att", "E");
				PlayerPrefs.SetString ("60_Att", "E");
				PlayerPrefs.SetString ("61_Att", "E");
				PlayerPrefs.SetString ("62_Att", "E");
				PlayerPrefs.SetString ("63_Att", "E");
				PlayerPrefs.SetString ("64_Att", "E");
				PlayerPrefs.SetString ("65_Att", "E");
				PlayerPrefs.SetString ("66_Att", "E");
				PlayerPrefs.SetString ("67_Att", "E");
				PlayerPrefs.SetString ("68_Att", "E");
				PlayerPrefs.SetString ("69_Att", "E");
				PlayerPrefs.SetString ("70_Att", "E");
				PlayerPrefs.SetString ("71_Att", "E");
				PlayerPrefs.SetString ("72_Att", "E");
				PlayerPrefs.SetString ("73_Att", "E");
				PlayerPrefs.SetString ("74_Att", "E");
				PlayerPrefs.SetString ("75_Att", "E");
				PlayerPrefs.SetString ("76_Att", "P");
				PlayerPrefs.SetString ("77_Att", "C");
				PlayerPrefs.SetString ("78_Att", "W");
				PlayerPrefs.SetString ("79_Att", "K");
				PlayerPrefs.SetString ("80_Att", "E");



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

				string [] deck2 = new string[20];
				string j2 = "1";
				int i2 = 0;
		
				do {
			
						if ((PlayerPrefs.GetInt (j2 + "_SubAmount")) == 3) {
								deck2 [i2] = j2;
								deck2 [i2 + 1] = j2;
								deck2 [i2 + 2] = j2;
								i2 = i2 + 3;
				
						} else if ((PlayerPrefs.GetInt (j2 + "_SubAmount")) == 2) {
								deck2 [i2] = j2;
								deck2 [i2 + 1] = j2;
								i2 = i2 + 2;
				
						} else if ((PlayerPrefs.GetInt (j2 + "_SubAmount")) == 1) {
								deck2 [i2] = j2;
								i2++;
				
				
						}
			
			
			
			
			
			
						j2 = System.Convert.ToString (System.Int32.Parse (j2) + 1);	
			
						if (j2 == "81") {
								i2 = 20;
						}
			
			
				} while(i2<20);

				
						
						for (int q=0; q<30; q++) {

								if (deck [q] == null) {
										break;
								}  



								Instantiate (Resources.Load ("PIC/PIC_0" + deck [q]));
								GameObject.Find ("PIC_0" + deck [q] + "(Clone)").name = System.Convert.ToString (q);
								GameObject.Find (System.Convert.ToString (q)).transform.parent = grid.transform;
								GameObject.Find (System.Convert.ToString (q)).transform.localPosition = new Vector3 (0, 0, 0);
								GameObject.Find (System.Convert.ToString (q)).transform.localScale = new Vector3 (1, 1, 1);
						
								grid.repositionNow = true;
						}

						
	
				
				
						for (int q=0; q<20; q++) {
			
								if (deck2 [q] == null) {
										break;
								}  
			
			
							GameObject c=(GameObject)Instantiate (Resources.Load ("PIC/PIC_0" + deck2 [q]));
								c.name = System.Convert.ToString (q+"d");
								c.transform.parent = grid2.transform;
								c.transform.localPosition = new Vector3 (0, 0, 0);
								c.transform.localScale = new Vector3 (1, 1, 1);
			
								grid2.repositionNow = true;
						}


				}

		







	
	void Update () {
	









	}



}
 










