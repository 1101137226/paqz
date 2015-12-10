using UnityEngine;
using System.Collections;

public class numbers : MonoBehaviour {
	//Texture2D [] texmube;
	public Texture[] texmube;

	 int number=4545;
	public Texture2D zero;
	public Texture2D one;
	public Texture2D two;
	public Texture2D three;
	public Texture2D four;
	public Texture2D five;
	public Texture2D six;
	public Texture2D seven;
	public Texture2D eight;
	public Texture2D nine;
	// Use this for initialization
	void Start () {
	

		//texmube = Resources.LoadAll("numbers");
		//aa=(Texture2D)Resources.Load("numbers/0");
		texmube= new Texture[10];


		texmube[0]=zero;
		texmube[1]=one;
		texmube[2]=two;
		texmube[3]=three;
		texmube[4]=four;
		texmube[5]=five;
		texmube[6]=six;
		texmube[7]=seven;
		texmube[8]=eight;
		texmube[9]=nine;
		
		

	}
	
	// Update is called once per frame

	void OnGUI()
	{
		DrawImageNumeber(0,100,number,texmube);
		
	}
	void Update () {
	
	}
	private void DrawImageNumeber( int x, int y, int mumber, Object[] texmube )
	{
		char[] chars = mumber.ToString().ToCharArray();
		Texture2D tex = (Texture2D)texmube[0];
		int width = tex.width;
		int height = tex.height;
		foreach(char s in chars)
		{
			int i= int.Parse(s.ToString());
			Debug.Log(i);
			GUI.DrawTexture(new Rect(x,0,width,height),(Texture2D)texmube[i]);

			x+=width;
		}
	}

}
