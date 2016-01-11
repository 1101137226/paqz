	using UnityEngine;
using System.Collections;

public class mainmemu : MonoBehaviour
{
		public Sprite single;
		public Sprite single_L;
		public Sprite multi;
		public Sprite multi_L;
		public Sprite tutorial;
		public Sprite tutorial_L;
		public Sprite card_edit;
		public Sprite card_edit_L;
		public Sprite exit;
		public Sprite exit_L;
		public bool flag;
		public byte where;
	
		void Start ()
		{
				flag = false;
				where = 1;	
				if (PlayerPrefs.GetInt ("p4") != 1)
		{
			PlayerPrefs.SetFloat ("Level", 1);
			PlayerPrefs.SetFloat ("HP", 25000);
			PlayerPrefs.SetFloat ("ATK", 800);
			PlayerPrefs.SetFloat ("DEF", 250);
			PlayerPrefs.SetFloat ("REC", 200);
			PlayerPrefs.SetFloat ("Left", 50);
			PlayerPrefs.SetInt ("3_Get", 0);
			PlayerPrefs.SetInt ("6_Get", 0);
			PlayerPrefs.SetInt ("9_Get", 0);
			PlayerPrefs.SetInt ("12_Get", 0);
			PlayerPrefs.SetInt ("15_Get", 0);
			PlayerPrefs.SetInt ("18_Get", 0);
			PlayerPrefs.SetInt ("21_Get", 0);
			PlayerPrefs.SetInt ("24_Get", 0);
			PlayerPrefs.SetInt ("27_Get", 0);
			PlayerPrefs.SetInt ("30_Get", 0);
			PlayerPrefs.SetInt ("33_Get", 0);
			PlayerPrefs.SetInt ("36_Get", 0);
			PlayerPrefs.SetInt ("37_Get", 0);
			PlayerPrefs.SetInt ("38_Get", 0);
			PlayerPrefs.SetInt ("48_Get", 0);
			PlayerPrefs.SetInt ("49_Get", 0);
			PlayerPrefs.SetInt ("50_Get", 0);
			PlayerPrefs.SetInt ("51_Get", 0);
			PlayerPrefs.SetInt ("52_Get", 0);
			PlayerPrefs.SetInt ("53_Get", 0);
			PlayerPrefs.SetInt ("54_Get", 0);
			PlayerPrefs.SetInt ("55_Get", 0);
			PlayerPrefs.SetInt ("56_Get", 0);
			PlayerPrefs.SetInt ("57_Get", 0);
			PlayerPrefs.SetInt ("58_Get", 0);
			PlayerPrefs.SetInt ("59_Get", 0);
			PlayerPrefs.SetInt ("60_Get", 0);
			PlayerPrefs.SetInt ("61_Get", 0);
			PlayerPrefs.SetInt ("62_Get", 0);
			PlayerPrefs.SetInt ("63_Get", 0);
			PlayerPrefs.SetInt ("64_Get", 0);
			PlayerPrefs.SetInt ("65_Get", 0);
			PlayerPrefs.SetInt ("66_Get", 0);
			PlayerPrefs.SetInt ("67_Get", 0);
			PlayerPrefs.SetInt ("68_Get", 0);
			PlayerPrefs.SetInt ("69_Get", 0);
			PlayerPrefs.SetInt ("70_Get", 0);
			PlayerPrefs.SetInt ("71_Get", 0);
			PlayerPrefs.SetInt ("72_Get", 0);
			PlayerPrefs.SetInt ("73_Get", 0);
			PlayerPrefs.SetInt ("74_Get", 0);
			PlayerPrefs.SetInt ("75_Get", 0);
			PlayerPrefs.SetInt ("76_Get", 0);
			PlayerPrefs.SetInt ("77_Get", 0);
			PlayerPrefs.SetInt ("78_Get", 0);
			PlayerPrefs.SetInt ("79_Get", 0);
			PlayerPrefs.SetInt ("80_Get", 0);
			PlayerPrefs.SetInt ("1_Get", 1);
			PlayerPrefs.SetInt ("2_Get", 1);
			PlayerPrefs.SetInt ("4_Get", 1);
			PlayerPrefs.SetInt ("5_Get", 1);
			PlayerPrefs.SetInt ("7_Get", 1);
			PlayerPrefs.SetInt ("8_Get", 1);
			PlayerPrefs.SetInt ("10_Get", 1);
			PlayerPrefs.SetInt ("11_Get", 1);
			PlayerPrefs.SetInt ("13_Get", 1);
			PlayerPrefs.SetInt ("14_Get", 1);
			PlayerPrefs.SetInt ("16_Get", 1);
			PlayerPrefs.SetInt ("17_Get", 1);
			PlayerPrefs.SetInt ("19_Get", 1);
			PlayerPrefs.SetInt ("20_Get", 1);
			PlayerPrefs.SetInt ("22_Get", 1);
			PlayerPrefs.SetInt ("23_Get", 1);
			PlayerPrefs.SetInt ("25_Get", 1);
			PlayerPrefs.SetInt ("26_Get", 1);
			PlayerPrefs.SetInt ("28_Get", 1);
			PlayerPrefs.SetInt ("29_Get", 1);
			PlayerPrefs.SetInt ("31_Get", 1);
			PlayerPrefs.SetInt ("32_Get", 1);
			PlayerPrefs.SetInt ("34_Get", 1);
			PlayerPrefs.SetInt ("35_Get", 1);
			PlayerPrefs.SetInt ("39_Get", 1);
			PlayerPrefs.SetInt ("40_Get", 1);
			PlayerPrefs.SetInt ("41_Get", 1);
			PlayerPrefs.SetInt ("42_Get", 1);
			PlayerPrefs.SetInt ("43_Get", 1);
			PlayerPrefs.SetInt ("44_Get", 1);
			PlayerPrefs.SetInt ("45_Get", 1);
			PlayerPrefs.SetInt ("46_Get", 1);
			PlayerPrefs.SetInt ("47_Get", 1);
		}
		PlayerPrefs.SetInt ("p4", 1);
	
		}
				
		void Update ()
		{

		}
}
