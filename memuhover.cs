using UnityEngine;
using System.Collections;

public class memuhover : MonoBehaviour
{
	public byte here;


	void Start ()
	{
		GameObject.Find ("Menu").GetComponent<UIPanel> ().alpha = 1;
		GameObject.Find ("Stage").GetComponent<UIPanel> ().alpha = 0;
	}

	void OnHover (bool isOver)
	{
		Sprite single = GameObject.Find ("MainCamera").GetComponent<mainmemu> ().single;
		Sprite single_L = GameObject.Find ("MainCamera").GetComponent<mainmemu> ().single_L;
		Sprite multi = GameObject.Find ("MainCamera").GetComponent<mainmemu> ().multi;
		Sprite multi_L = GameObject.Find ("MainCamera").GetComponent<mainmemu> ().multi_L;
		Sprite tutorial = GameObject.Find ("MainCamera").GetComponent<mainmemu> ().tutorial;
		Sprite tutorial_L = GameObject.Find ("MainCamera").GetComponent<mainmemu> ().tutorial_L;
		Sprite card_edit = GameObject.Find ("MainCamera").GetComponent<mainmemu> ().card_edit;
		Sprite card_edit_L = GameObject.Find ("MainCamera").GetComponent<mainmemu> ().card_edit_L;
		Sprite exit = GameObject.Find ("MainCamera").GetComponent<mainmemu> ().exit;
		Sprite exit_L = GameObject.Find ("MainCamera").GetComponent<mainmemu> ().exit_L;

		if (isOver) {
			switch (here) {
			case 1:
				GameObject.Find ("Single").GetComponent<UI2DSprite> ().sprite2D = single_L;
				GameObject.Find ("Multi").GetComponent<UI2DSprite> ().sprite2D = multi;
				GameObject.Find ("Tutorial").GetComponent<UI2DSprite> ().sprite2D = tutorial;
				GameObject.Find ("Card Edit").GetComponent<UI2DSprite> ().sprite2D = card_edit;
				GameObject.Find ("Exit").GetComponent<UI2DSprite> ().sprite2D = exit;
				break;
			case 2:
				GameObject.Find ("Single").GetComponent<UI2DSprite> ().sprite2D = single;
				GameObject.Find ("Multi").GetComponent<UI2DSprite> ().sprite2D = multi_L;
				GameObject.Find ("Tutorial").GetComponent<UI2DSprite> ().sprite2D = tutorial;
				GameObject.Find ("Card Edit").GetComponent<UI2DSprite> ().sprite2D = card_edit;
				GameObject.Find ("Exit").GetComponent<UI2DSprite> ().sprite2D = exit;
				break;
			case 3:
				GameObject.Find ("Single").GetComponent<UI2DSprite> ().sprite2D = single;
				GameObject.Find ("Multi").GetComponent<UI2DSprite> ().sprite2D = multi;
				GameObject.Find ("Tutorial").GetComponent<UI2DSprite> ().sprite2D = tutorial_L;
				GameObject.Find ("Card Edit").GetComponent<UI2DSprite> ().sprite2D = card_edit;
				GameObject.Find ("Exit").GetComponent<UI2DSprite> ().sprite2D = exit;
				break;
			case 4:
				GameObject.Find ("Single").GetComponent<UI2DSprite> ().sprite2D = single;
				GameObject.Find ("Multi").GetComponent<UI2DSprite> ().sprite2D = multi;
				GameObject.Find ("Tutorial").GetComponent<UI2DSprite> ().sprite2D = tutorial;
				GameObject.Find ("Card Edit").GetComponent<UI2DSprite> ().sprite2D = card_edit_L;
				GameObject.Find ("Exit").GetComponent<UI2DSprite> ().sprite2D = exit;
				break;
			case 5:
				GameObject.Find ("Single").GetComponent<UI2DSprite> ().sprite2D = single;
				GameObject.Find ("Multi").GetComponent<UI2DSprite> ().sprite2D = multi;
				GameObject.Find ("Tutorial").GetComponent<UI2DSprite> ().sprite2D = tutorial;
				GameObject.Find ("Card Edit").GetComponent<UI2DSprite> ().sprite2D = card_edit;
				GameObject.Find ("Exit").GetComponent<UI2DSprite> ().sprite2D = exit_L;
				break;
			}
			GameObject.Find ("MainCamera").GetComponent<mainmemu> ().where = here;
		}
	}

	public void OnPress (bool ispress)
	{
		if (ispress) {
			if (this.name == "Single") {
				GameObject.Find ("Menu").GetComponent<UIPanel> ().alpha = 0;
				GameObject.Find ("Stage").GetComponent<UIPanel> ().alpha = 1;
			}
			if (this.name == "Multi") {
				Application.LoadLevel ("vsroom");
			}
			if (this.name == "Tutorial") {
				Application.LoadLevel ("demoteach");
			}
			if (this.name == "Card Edit") {
				Application.LoadLevel ("edit");
			}
			if (this.name == "Exit") {
				Application.Quit ();
			}
		}
	}
		

	void Update ()
	{
	
	}
}
