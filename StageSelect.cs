using UnityEngine;
using System.Collections;

public class StageSelect : MonoBehaviour
{
		
		// Use this for initialization
		void Start ()
		{
			
		}
		
		public void OnPress (bool isPress)
		{
				GameObject selected = GameObject.Find ("Selected Stage");
				GameObject next = GameObject.Find ("Next Stage");
		GameObject previous = GameObject.Find ("Previous Stage");
				Texture2D[] stage = GameObject.Find ("Stage").GetComponent<StageManager> ().stage;
				Texture2D temp = null;
				
				if (isPress) {
						if (this.name == "Play") {
								for (int i = 0; i <= stage.Length-1; i++) {
										if (stage [i] == selected.GetComponent<UITexture> ().mainTexture) {
												switch (i + 1) {
												case 1:
														Application.LoadLevel ("map1-mura");
														break;
												case 2:
														Application.LoadLevel ("map2-mura");
														break;
												case 3:
														Application.LoadLevel ("map3-mura");
														break;
												case 4:
														Application.LoadLevel ("map4-mura");
														break;
												case 5:
														Application.LoadLevel ("map5-mura");
														break;
												case 6:
														Application.LoadLevel ("map6-mura");
														break;
												case 7:
														Application.LoadLevel ("map7-mura");
														break;
												case 8:
														Application.LoadLevel ("demokai");
														break;
												case 9:
														Application.LoadLevel ("map9-mura");
														break;
												case 10:
														Application.LoadLevel ("map10-mura -");
														break;
												}
										}
								}
								//Application.LoadLevel ("edit_new");
						}
						if (this.name == "Next") {
								for (int i = 0; i <= stage.Length-1; i++) {
										if (stage [i] == selected.GetComponent<UITexture> ().mainTexture) {
												if (i + 1 == stage.Length - 1) {
														selected.GetComponent<UITexture> ().mainTexture = stage [i + 1];
														next.GetComponent<UITexture> ().mainTexture = stage [0];
							previous.GetComponent<UITexture> ().mainTexture = stage [i];
														break;
												}
												if (i == stage.Length - 1) {
														selected.GetComponent<UITexture> ().mainTexture = stage [0];
														next.GetComponent<UITexture> ().mainTexture = stage [1];
							previous.GetComponent<UITexture> ().mainTexture = stage [i];
														break;
												} else {
														selected.GetComponent<UITexture> ().mainTexture = stage [i + 1];
														next.GetComponent<UITexture> ().mainTexture = stage [i + 2];
							previous.GetComponent<UITexture> ().mainTexture = stage [i];
														break;
												}
										}
								}
						}
						if (this.name == "Previous") {
								for (int i = 0; i <= stage.Length-1; i++) {
										if (stage [i] == selected.GetComponent<UITexture> ().mainTexture) {
												if (i - 1 == 0) {
														selected.GetComponent<UITexture> ().mainTexture = stage [0];
														next.GetComponent<UITexture> ().mainTexture = stage [i];
							previous.GetComponent<UITexture> ().mainTexture = stage [stage.Length - 1];
														break;
												}
												if (i == 0) {
														selected.GetComponent<UITexture> ().mainTexture = stage [stage.Length - 1];
														next.GetComponent<UITexture> ().mainTexture = stage [i];
							previous.GetComponent<UITexture> ().mainTexture = stage [stage.Length - 2];
														break;
												} else {
														selected.GetComponent<UITexture> ().mainTexture = stage [i - 1];
														next.GetComponent<UITexture> ().mainTexture = stage [i];
							previous.GetComponent<UITexture> ().mainTexture = stage [i - 2];
														break;
												}
										}
								}
						}
						if (this.name == "Back") {
								GameObject.Find ("Menu").GetComponent<UIPanel> ().alpha = 1;
								GameObject.Find ("Stage").GetComponent<UIPanel> ().alpha = 0;
						}
				}
		}
	
		// Update is called once per frame
		void Update ()
		{
		
		}
}

