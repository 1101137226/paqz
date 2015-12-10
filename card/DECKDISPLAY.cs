using UnityEngine;
using System.Collections;

public class DECKDISPLAY : MonoBehaviour {


	
	public static byte flag=0;
	public static byte poi;
	

	
	public UIGrid grid;
	public UIGrid grid2;
	// Use this for initialization
	void Start () {
	
				//PlayerPrefs.SetInt ("1_amount", 3);
				//PlayerPrefs.SetInt ("2_amount", 3);
				//PlayerPrefs.SetInt ("3_amount", 3);
				//PlayerPrefs.SetInt ("4_amount", 3);
				//PlayerPrefs.SetInt ("5_amount", 3);
				PlayerPrefs.SetInt ("1_Get", 1);
				PlayerPrefs.SetString ("1_Att", "P");
				PlayerPrefs.SetInt ("2_Get", 1);
				PlayerPrefs.SetString ("2_Att", "P");
				PlayerPrefs.SetInt ("3_Get", 1);
				PlayerPrefs.SetString ("3_Att", "P");
				PlayerPrefs.SetInt ("4_Get", 1);
				PlayerPrefs.SetString ("4_Att", "C");
				PlayerPrefs.SetInt ("5_Get", 1);
				PlayerPrefs.SetString ("5_Att", "C");
				PlayerPrefs.SetInt ("6_Get", 1);
				PlayerPrefs.SetString ("6_Att", "C");
				PlayerPrefs.SetInt ("7_Get", 1);
				PlayerPrefs.SetString ("7_Att", "W");
				PlayerPrefs.SetInt ("8_Get", 1);
				PlayerPrefs.SetString ("8_Att", "W");
				PlayerPrefs.SetInt ("9_Get", 1);
				PlayerPrefs.SetString ("9_Att", "W");
				PlayerPrefs.SetInt ("10_Get", 1);
				PlayerPrefs.SetString ("10_Att", "K");
				PlayerPrefs.SetInt ("11_Get", 1);
				PlayerPrefs.SetString ("11_Att", "K");
				PlayerPrefs.SetInt ("12_Get", 1);
				PlayerPrefs.SetString ("12_Att", "K");
				PlayerPrefs.SetInt ("13_Get", 1);
				PlayerPrefs.SetString ("13_Att", "P");
				PlayerPrefs.SetInt ("14_Get", 1);
				PlayerPrefs.SetString ("14_Att", "P");
				PlayerPrefs.SetInt ("15_Get", 1);
				PlayerPrefs.SetString ("15_Att", "P");
				PlayerPrefs.SetInt ("16_Get", 1);
				PlayerPrefs.SetString ("16_Att", "C");
				PlayerPrefs.SetInt ("17_Get", 1);
				PlayerPrefs.SetString ("17_Att", "C");
				PlayerPrefs.SetInt ("18_Get", 1);
				PlayerPrefs.SetString ("18_Att", "C");
				PlayerPrefs.SetInt ("19_Get", 1);
				PlayerPrefs.SetString ("19_Att", "W");
				PlayerPrefs.SetInt ("20_Get", 1);
				PlayerPrefs.SetString ("20_Att", "W");
				PlayerPrefs.SetInt ("21_Get", 1);
				PlayerPrefs.SetString ("21_Att", "W");
				PlayerPrefs.SetInt ("22_Get", 1);
				PlayerPrefs.SetString ("22_Att", "K");
				PlayerPrefs.SetInt ("23_Get", 1);
				PlayerPrefs.SetString ("23_Att", "K");
				PlayerPrefs.SetInt ("24_Get", 1);
				PlayerPrefs.SetString ("24_Att", "K");
				PlayerPrefs.SetInt ("25_Get", 1);
				PlayerPrefs.SetString ("25_Att", "P");
				PlayerPrefs.SetInt ("26_Get", 1);
				PlayerPrefs.SetString ("26_Att", "P");
				PlayerPrefs.SetInt ("27_Get", 1);
				PlayerPrefs.SetString ("27_Att", "P");
				PlayerPrefs.SetInt ("28_Get", 1);
				PlayerPrefs.SetString ("28_Att", "C");
				PlayerPrefs.SetInt ("29_Get", 1);
				PlayerPrefs.SetString ("29_Att", "C");
				PlayerPrefs.SetInt ("30_Get", 1);
				PlayerPrefs.SetString ("30_Att", "C");
				PlayerPrefs.SetInt ("31_Get", 1);
				PlayerPrefs.SetString ("31_Att", "W");
				PlayerPrefs.SetInt ("32_Get", 1);
				PlayerPrefs.SetString ("32_Att", "W");
				PlayerPrefs.SetInt ("33_Get", 1);
				PlayerPrefs.SetString ("33_Att", "W");
				PlayerPrefs.SetInt ("34_Get", 1);
				PlayerPrefs.SetString ("34_Att", "K");
				PlayerPrefs.SetInt ("35_Get", 1);
				PlayerPrefs.SetString ("35_Att", "K");
				PlayerPrefs.SetInt ("36_Get", 1);
				PlayerPrefs.SetString ("36_Att", "K");
				PlayerPrefs.SetInt ("37_Get", 1);
				PlayerPrefs.SetString ("37_Att", "E");
				PlayerPrefs.SetInt ("38_Get", 1);
				PlayerPrefs.SetString ("38_Att", "E");
				PlayerPrefs.SetInt ("39_Get", 1);
				PlayerPrefs.SetString ("39_Att", "E");
				PlayerPrefs.SetInt ("40_Get", 1);
				PlayerPrefs.SetString ("40_Att", "E");
				PlayerPrefs.SetInt ("41_Get", 1);
				PlayerPrefs.SetString ("41_Att", "E");
				PlayerPrefs.SetInt ("42_Get", 1);
				PlayerPrefs.SetString ("42_Att", "E");
				PlayerPrefs.SetInt ("43_Get", 1);
				PlayerPrefs.SetString ("43_Att", "E");
				PlayerPrefs.SetInt ("44_Get", 1);
				PlayerPrefs.SetString ("44_Att", "E");
				PlayerPrefs.SetInt ("45_Get", 1);
				PlayerPrefs.SetString ("45_Att", "E");
				PlayerPrefs.SetInt ("46_Get", 1);
				PlayerPrefs.SetString ("46_Att", "E");
				PlayerPrefs.SetInt ("47_Get", 1);
				PlayerPrefs.SetString ("47_Att", "E");
				PlayerPrefs.SetInt ("48_Get", 1);
				PlayerPrefs.SetString ("48_Att", "E");
				PlayerPrefs.SetInt ("49_Get", 1);
				PlayerPrefs.SetString ("49_Att", "E");
				PlayerPrefs.SetInt ("50_Get", 1);
				PlayerPrefs.SetString ("50_Att", "E");
				PlayerPrefs.SetInt ("51_Get", 1);
				PlayerPrefs.SetString ("51_Att", "E");
				PlayerPrefs.SetInt ("52_Get", 1);
				PlayerPrefs.SetString ("52_Att", "E");
				PlayerPrefs.SetInt ("53_Get", 1);
				PlayerPrefs.SetString ("53_Att", "E");
				PlayerPrefs.SetInt ("54_Get", 1);
				PlayerPrefs.SetString ("54_Att", "E");
				PlayerPrefs.SetInt ("55_Get", 1);
				PlayerPrefs.SetString ("55_Att", "E");
				PlayerPrefs.SetInt ("56_Get", 1);
				PlayerPrefs.SetString ("56_Att", "E");
				PlayerPrefs.SetInt ("57_Get", 1);
				PlayerPrefs.SetString ("57_Att", "E");
				PlayerPrefs.SetInt ("58_Get", 1);
				PlayerPrefs.SetString ("58_Att", "E");
				PlayerPrefs.SetInt ("59_Get", 1);
				PlayerPrefs.SetString ("59_Att", "E");
				PlayerPrefs.SetInt ("60_Get", 1);
				PlayerPrefs.SetString ("60_Att", "E");
				PlayerPrefs.SetInt ("61_Get", 1);
				PlayerPrefs.SetString ("61_Att", "E");
				PlayerPrefs.SetInt ("62_Get", 1);
				PlayerPrefs.SetString ("62_Att", "E");
				PlayerPrefs.SetInt ("63_Get", 1);
				PlayerPrefs.SetString ("63_Att", "E");
				PlayerPrefs.SetInt ("64_Get", 1);
				PlayerPrefs.SetString ("64_Att", "E");
				PlayerPrefs.SetInt ("65_Get", 1);
				PlayerPrefs.SetString ("65_Att", "E");
				PlayerPrefs.SetInt ("66_Get", 1);
				PlayerPrefs.SetString ("66_Att", "E");
				PlayerPrefs.SetInt ("67_Get", 1);
				PlayerPrefs.SetString ("67_Att", "E");
				PlayerPrefs.SetInt ("68_Get", 1);
				PlayerPrefs.SetString ("68_Att", "E");
				PlayerPrefs.SetInt ("69_Get", 1);
				PlayerPrefs.SetString ("69_Att", "E");
				PlayerPrefs.SetInt ("70_Get", 1);
				PlayerPrefs.SetString ("70_Att", "E");
				PlayerPrefs.SetInt ("71_Get", 1);
				PlayerPrefs.SetString ("71_Att", "E");
				PlayerPrefs.SetInt ("72_Get", 1);
				PlayerPrefs.SetString ("72_Att", "E");
				PlayerPrefs.SetInt ("73_Get", 1);
				PlayerPrefs.SetString ("73_Att", "E");
				PlayerPrefs.SetInt ("74_Get", 1);
				PlayerPrefs.SetString ("74_Att", "E");
				PlayerPrefs.SetInt ("75_Get", 1);
				PlayerPrefs.SetString ("75_Att", "E");
				PlayerPrefs.SetInt ("76_Get", 1);
				PlayerPrefs.SetString ("76_Att", "P");
				PlayerPrefs.SetInt ("77_Get", 1);
				PlayerPrefs.SetString ("77_Att", "C");
				PlayerPrefs.SetInt ("78_Get", 1);
				PlayerPrefs.SetString ("78_Att", "W");
				PlayerPrefs.SetInt ("79_Get", 1);
				PlayerPrefs.SetString ("79_Att", "K");
				PlayerPrefs.SetInt ("80_Get", 1);
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
								}  //test



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
								}  //test
			
			
			
							GameObject c=(GameObject)Instantiate (Resources.Load ("PIC/PIC_0" + deck2 [q]));
								c.name = System.Convert.ToString (q+"d");
								c.transform.parent = grid2.transform;
								c.transform.localPosition = new Vector3 (0, 0, 0);
								c.transform.localScale = new Vector3 (1, 1, 1);
			
								grid2.repositionNow = true;
						}


				}

		







	
	// Update is called once per frame
	void Update () {
	









	}



}
 










