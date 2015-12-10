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

		// Use this for initialization
		void Start ()
		{
				flag = false;
				where = 1;

				PlayerPrefs.SetFloat ("Level", 1);
				PlayerPrefs.SetFloat ("HP", 70000);
				PlayerPrefs.SetFloat ("ATK", 1200);
				PlayerPrefs.SetFloat ("DEF", 400);
				PlayerPrefs.SetFloat ("REC", 500);
		}
	
		// Update is called once per frame
		void Update ()
		{
//				switch (where) {
//				case 1:
//						if (Input.GetKeyUp (KeyCode.DownArrow)) {
//								GameObject.Find ("Single").GetComponent<UI2DSprite> ().sprite2D = single;
//								GameObject.Find ("Multi").GetComponent<UI2DSprite> ().sprite2D = multi_L;
//								where = 2;
//						}
//
//						if (Input.GetKeyUp (KeyCode.Space) || flag || Input.GetKeyUp (KeyCode.Return)) {
//								Application.LoadLevel ("democardsee");
//						}
//						break;
//				case 2:
//						if (Input.GetKeyUp (KeyCode.UpArrow)) {
//								GameObject.Find ("Multi").GetComponent<UI2DSprite> ().sprite2D = multi;
//								GameObject.Find ("Single").GetComponent<UI2DSprite> ().sprite2D = single_L;
//								where = 1;
//						}
//						
//						if (Input.GetKeyUp (KeyCode.DownArrow)) {
//								GameObject.Find ("Multi").GetComponent<UI2DSprite> ().sprite2D = multi;
//								GameObject.Find ("Tutorial").GetComponent<UI2DSprite> ().sprite2D = tutorial_L;
//								where = 3;
//						}
//
//						if (Input.GetKeyUp (KeyCode.Space) || flag || Input.GetKeyUp (KeyCode.Return)) {
//								GameObject.DontDestroyOnLoad (GameObject.Find ("donotkillme").gameObject);
//								GameObject.Find ("donotkillme").GetComponent<loadscene> ().what = "demoteach";
//								Application.LoadLevel ("load");
//						}
//						break;
//				case 3:
//						if (Input.GetKeyUp (KeyCode.UpArrow)) {
//								GameObject.Find ("Tutorial").GetComponent<UI2DSprite> ().sprite2D = tutorial;
//								GameObject.Find ("Multi").GetComponent<UI2DSprite> ().sprite2D = multi_L;
//								where = 2;
//						}
//						if (Input.GetKeyUp (KeyCode.DownArrow)) {
//								GameObject.Find ("Tutorial").GetComponent<UI2DSprite> ().sprite2D = tutorial;
//								GameObject.Find ("Exit").GetComponent<UI2DSprite> ().sprite2D = exit_L;
//								where = 4;
//						}
//
//						if (Input.GetKeyUp (KeyCode.Space) || flag || Input.GetKeyUp (KeyCode.Return)) {
//				
//								GameObject.DontDestroyOnLoad (GameObject.Find ("donotkillme").gameObject);
//								GameObject.Find ("donotkillme").GetComponent<loadscene> ().what = "demoteach";
//								Application.LoadLevel ("load");
//						}
//						break;
//				case 4:
//						if (Input.GetKeyUp (KeyCode.UpArrow)) {
//								GameObject.Find ("Exit").GetComponent<UI2DSprite> ().sprite2D = exit;
//								GameObject.Find ("Tutorial").GetComponent<UI2DSprite> ().sprite2D = tutorial_L;
//								where = 3;
//						}
//
//						if (Input.GetKeyUp (KeyCode.Space) || flag || Input.GetKeyUp (KeyCode.Return)) {
//								Application.Quit ();
//						}
//						break;
//				}
		}
}
