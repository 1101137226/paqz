using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class NETBS : NetworkBehaviour
{
	public Queue handd = new Queue ();
	public Queue Sub = new Queue ();
	public bool[] ishand = new bool[5];
	public byte leftdeck;
	public Texture2D lowpic;
	public Texture2D highpic;
	GameObject low;
	public GameObject mm;
	public GameObject ff;
	public GameObject rr;
	public GameObject ba;
	public GameObject DIS;
	public GameObject drawF;
	public Vector3 jpos;
	public Vector3 kpos;
	public bool gomm;
	string target;
	bool changeflag;
	[SyncVar(hook="jksync")]
	public bool
		jk = false;
	Transform father;
	bool down;
	float time;
	[SyncVar(hook="combosync")]
	public short
		combo = 0;
	[SyncVar(hook="decksync")]
	public short
		deckleft = 0;
	public short drawcombo;
	public byte team;
	public byte ourteam;
	public bool isspc;
	//\\\\\\\\\\\\\\\\\\\\\\\\\\
	public float guup;
	public float baup;
	public float smup;
	public float piup;
	public float allup;
	float combodamageup;
	public float powerup;
	public float weakup;
	///\\\\\\\\\\\\\\\\\\\\\\\
	public bool isjk;
	//\\\\\\\\\\\\\\\\\\\\\\\\
	GameObject combodis;
	GameObject carddeckdis;
	public GameObject next;
	[SyncVar(hook="dessync")]
	public bool
		isdes = false;
	[SyncVar(hook="SyncStop")]
	public bool
		Stop = false;
	GameObject emeny;
	[SyncVar(hook="SyncDrop")]
	GameObject
		drop;
	// Use this for initialization
	void Start ()
	{


		isjk = false;


		if (this.tag != "Who") 

			return;

	
		down = true;
		changeflag = true;
		father = GameObject.Find ("UIRoot").transform;
		this.transform.parent = father;
		GameObject[] p = GameObject.FindGameObjectsWithTag ("Who");
		if (this.name == p [0].name) {
			jpos = new Vector3 (-8000, -1200, 0);
			kpos = new Vector3 (-4000, -1200, 0);
			ourteam = 1;
			this.transform.localPosition = jpos;
			combodis = GameObject.Find ("COMBOSETP1/combo").gameObject;
			carddeckdis = GameObject.Find ("COMBOSETP1/carddeck").gameObject;
			if (isLocalPlayer) {
				team = 1;
				GameObject.Find ("UIRoot").GetComponent<NETSAVE> ().thisteam = team;
				GameObject.Find ("UIRoot").GetComponent<NETSAVE> ().thisname = this.name;
			}
		} else if (this.name != p [0].name) {
			jpos = new Vector3 (-8000, 400, 0);
			kpos = new Vector3 (-4000, 400, 0);
			ourteam = 2;
			this.transform.localPosition = jpos;
			combodis = GameObject.Find ("COMBOSETP2/combo").gameObject;
			carddeckdis = GameObject.Find ("COMBOSETP2/carddeck").gameObject;
			if (isLocalPlayer) {
				team = 2;
				GameObject.Find ("UIRoot").GetComponent<NETSAVE> ().thisteam = team;
				GameObject.Find ("UIRoot").GetComponent<NETSAVE> ().thisname = this.name;
			}
		}

		GameObject.Find (this.name + "/front").GetComponent<NETBS> ().team = team;
		GameObject.Find (this.name + "/real").GetComponent<NETBS> ().team = team;

		this.transform.localScale = new Vector3 (800, 800, 800);
	
		GetCardinDeck (ourteam);
		isspc = false;
		combodamageup = 1f;
		guup = 1f;
		baup = 1f;
		smup = 1f;
		piup = 1f;
		allup = 1f;
		weakup = 1f;
		powerup = 0f;

	}

	void SyncDrop (GameObject b)
	{

		drop = b;
	
	}

	void OnTriggerStay2D (Collider2D bbb)
	{
	

		drop = bbb.gameObject;
		bool a = false;
		if (drop.tag == "P1") {
			if (drop.GetComponent<NETnewtempo> ().die)
				a = true;
		}
		if (drop.tag == "P2") {
			if (drop.GetComponent<NETnewtempoP2> ().Dead)
				a = true;
		}
		if (a)
			return;
		if (this.tag != "Who") {
			if (bbb.transform.tag == "P" + System.Convert.ToString (team)) {

				if (bbb.gameObject.tag == "P1" || bbb.gameObject.tag == "P2") {
					if (Input.GetKey (KeyCode.J) && down) {
						if (drop.tag == "P1") {
							drop.GetComponent<NETnewtempo> ().die = true;
						}
						if (drop.tag == "P2") {
							drop.GetComponent<NETnewtempoP2> ().Dead = true;
						}
						down = false;

						if (!this.transform.parent.GetComponent<NETBS> ().jk) {
							string a22 = bbb.GetComponent<UITexture> ().mainTexture.name;

							this.transform.parent.GetComponent<NETBS> ().isdes = true;
																
							if (this.name == "front") {
								//damage.hitpois=0.7f;
								this.transform.parent.GetComponent<NETBS> ().CmdCombo ();
								this.transform.parent.GetComponent<NETBS> ().drawcombo++;

								this.transform.parent.GetComponent<NETBS> ().CmdCreatff ();
								this.transform.parent.GetComponent<NETBS> ().Damage (0.7f, a22, false);
								if (this.transform.parent.GetComponent<NETBS> ().combo >= 3) {
									combodamageup += 0.02f;
								}
								
							} else if (this.name == "real") {

								this.transform.parent.GetComponent<NETBS> ().CmdCombo ();
								this.transform.parent.GetComponent<NETBS> ().drawcombo++;

								this.transform.parent.GetComponent<NETBS> ().CmdCreatrr ();
								this.transform.parent.GetComponent<NETBS> ().Damage (0.8f, a22, false);
								if (this.transform.parent.GetComponent<NETBS> ().combo >= 3) {
									combodamageup += 0.02f;
								}
								
							}
																
						} else if (this.transform.parent.GetComponent<NETBS> ().jk) {
																
							string a22 = bbb.GetComponent<UITexture> ().mainTexture.name;
																
							this.transform.parent.GetComponent<NETBS> ().isdes = true;

							if (this.name == "front") {
								this.transform.parent.GetComponent<NETBS> ().CmdCombo ();
								this.transform.parent.GetComponent<NETBS> ().drawcombo++;

								this.transform.parent.GetComponent<NETBS> ().CmdCreatff ();
								this.transform.parent.GetComponent<NETBS> ().Damage (0.7f, a22, true);
								if (this.transform.parent.GetComponent<NETBS> ().combo >= 3) {
									combodamageup += 0.02f;
								}
							} else if (this.name == "real") {
								this.transform.parent.GetComponent<NETBS> ().CmdCombo ();
								this.transform.parent.GetComponent<NETBS> ().drawcombo++;

								this.transform.parent.GetComponent<NETBS> ().CmdCreatrr ();
				
								this.transform.parent.GetComponent<NETBS> ().Damage (0.8f, a22, true);
								if (this.transform.parent.GetComponent<NETBS> ().combo >= 3) {
									combodamageup += 0.02f;
								}
							}
						}
					}
				}
			}
		}
						
		if (!isLocalPlayer)
			return;

		if (bbb.gameObject.tag == "P1" || bbb.gameObject.tag == "P2") {
			if (Input.GetKey (KeyCode.J) && down) {
				if (drop.tag == "P1") {
					drop.GetComponent<NETnewtempo> ().die = true;
				}
				if (drop.tag == "P2") {
					drop.GetComponent<NETnewtempoP2> ().Dead = true;
				}
				
				down = false;
				if (!jk) {
					string a22 = bbb.GetComponent<UITexture> ().mainTexture.name;
					isdes = true;

					if (this.name != "front" && this.name != "real") {
						CmdCombo ();
						drawcombo++;
						Damage (1f, a22, false);
						CmdCreatmm ();
						if (combo >= 3) {
							combodamageup += 0.02f;
						}
					}
				

					//	bbb.GetComponent<NETnewtempo>().die=true;
				} else if (jk) {
					//	Instantiate(mm);
					string a22 = bbb.GetComponent<UITexture> ().mainTexture.name;
												
					isdes = true;

					if (this.name != "front" && this.name != "real") {
						//damage.hitpois=1.0f;
						CmdCombo ();
						drawcombo++;
						Damage (1f, a22, true);
						CmdCreatmm ();
													
						if (combo >= 3) {
							combodamageup += 0.02f;
						}
					}
					//damage22(a22);
				
					//CmdCreatmm();
					//Instantiate(mm);

					//bbb.GetComponent<NETnewtempo>().die=true;
				}
			}
		}
	}

	[Command]
	public void CmdCombo ()
	{
		GameObject.Find (this.name).GetComponent<NETBS> ().combo++;
	}

	[Command]
	public void CmdComboZero ()
	{
		GameObject.Find (this.name).GetComponent<NETBS> ().combo = 0;
	}

	[Command]
	public void CmdDeckPlus ()
	{
		deckleft++;
	}

	[Command]
	public void CmdDeckDraw ()
	{
		deckleft--;
	}

	[Command]
	public void Cmdjkset (bool jork)
	{
		jk = jork;
	}

	void combosync (short c)
	{
		combo = c;
	}

	void dessync (bool d)
	{
		isdes = d;
	}

	void decksync (short d)
	{
		deckleft = d;
	}

	void jksync (bool jork)
	{

		jk = jork;
	
	}

	void SyncStop (bool b)
	{

		Stop = b;
	
	}

	[Command]
	void CmdGoNext ()
	{

		GameObject[] p = GameObject.FindGameObjectsWithTag ("Who");
		if (p [0].name == this.name) {
			
			Stop = true;
			p [1].GetComponent<NETBS> ().Stop = true;
			
		} else if (p [1].name == this.name) {
			
			Stop = true;
			p [0].GetComponent<NETBS> ().Stop = true;
			
		}


		GameObject to = (GameObject)Instantiate (next);

		NetworkServer.Spawn (to);
	
	
	}
	// Update is called once per frame
	void Update ()
	{

		if (!Stop) {	
			

			if (Input.GetKey (KeyCode.J)) {
			
				time += Time.deltaTime;
			
				if (time > 0.1f) {
				
					down = false;
				
				}


			
			}
			if (Input.GetKeyUp (KeyCode.J)) {
				time = 0f;
				down = true;
				if (this.tag != "Who") {
					this.transform.parent.GetComponent<NETBS> ().isdes = false;
				}
			}

			if (this.tag != "Who") 
				return;

			combodis.GetComponent<UILabel> ().text = combo.ToString ();
			carddeckdis.GetComponent<UILabel> ().text = deckleft.ToString ();
		
		
			if (this.transform.position.x > -30) {
				
				this.GetComponent<UITexture> ().mainTexture = highpic;
		
		
			} else if (this.transform.position.x < -30) {
		

				this.GetComponent<UITexture> ().mainTexture = lowpic;
			}

			if (this.GetComponent<NETstaus> ().nowhp < 0f) {
				
				this.GetComponent<NETstaus> ().die++;

				this.GetComponent<NETstaus> ().nowhp = 0;
				CmdGoNext ();
			}


			if (!isLocalPlayer)
				return;

			if (Input.GetKeyDown (KeyCode.J)) {
				bool t = this.GetComponent<Collider2D> ().IsTouchingLayers ();
				bool f = this.transform.GetChild (0).GetComponent<Collider2D> ().IsTouchingLayers ();
				bool r = this.transform.GetChild (1).GetComponent<Collider2D> ().IsTouchingLayers ();

				if (!t && !r && !f && !isdes) {
					CmdComboZero ();		
				}
			}
			if (Input.GetKeyUp (KeyCode.J)) {
				isdes = false;
			}
			
			if (Input.GetKeyDown (KeyCode.K) && changeflag == true && !isjk) {
				this.transform.localPosition = kpos;
				Cmdjkset (true);
				changeflag = false;


			} else if (Input.GetKeyDown (KeyCode.K) && changeflag == false && !isjk) {
				this.transform.localPosition = jpos;
				Cmdjkset (false);
				changeflag = true;


			}



			/////////////////
			if (Input.GetKeyDown (KeyCode.Q) && ishand [0] == true) {
			
				string find0 = GameObject.Find ("UIRoot/0").GetComponent<UITexture> ().mainTexture.name;
				if (isspc == false) {
					drawcombo = 0;
					//		cardeffect.nextcard = find0;
					ishand [0] = false;
					CmdCDis ("0S");
					Usecard (find0);
					GameObject.Find ("UIRoot/0").GetComponent<carddis> ().poi = true;

					//Destroy(GameObject.Find("UIRoot/0").gameObject);
				} else if (isspc == true && find0 != "70" && find0 != "71" && find0 != "72" && find0 != "72" && find0 != "76" && find0 != "77" && find0 != "78" && find0 != "79" && find0 != "80") {
					drawcombo = 0;
					//		cardeffect.nextcard = find0;
					ishand [0] = false;
					CmdCDis ("0S");
					Usecard (find0);
					GameObject.Find ("UIRoot/0").GetComponent<carddis> ().poi = true;
					//Destroy(GameObject.Find("UIRoot/0").gameObject);
				}
			}
			if (Input.GetKeyDown (KeyCode.W) && ishand [1] == true) {
				string find0 = GameObject.Find ("UIRoot/1").GetComponent<UITexture> ().mainTexture.name;
				if (isspc == false) {
					drawcombo = 0;
					//		cardeffect.nextcard = find0;
					ishand [1] = false;
					CmdCDis ("1S");
					Usecard (find0);
					GameObject.Find ("UIRoot/1").GetComponent<carddis> ().poi = true;

					//Destroy(GameObject.Find("UIRoot/0").gameObject);
				} else if (isspc == true && find0 != "70" && find0 != "71" && find0 != "72" && find0 != "72" && find0 != "76" && find0 != "77" && find0 != "78" && find0 != "79" && find0 != "80") {
					drawcombo = 0;
					//		cardeffect.nextcard = find0;
					ishand [1] = false;
					Usecard (find0);
					GameObject.Find ("UIRoot/1").GetComponent<carddis> ().poi = true;
					//Destroy(GameObject.Find("UIRoot/0").gameObject);
					CmdCDis ("1S");
				}
			}
			if (Input.GetKeyDown (KeyCode.E) && ishand [2] == true) {
			
				string find0 = GameObject.Find ("UIRoot/2").GetComponent<UITexture> ().mainTexture.name;
				if (isspc == false) {
					drawcombo = 0;
					ishand [2] = false;
					CmdCDis ("2S");
					//		cardeffect.nextcard = find0;
					Usecard (find0);
					GameObject.Find ("UIRoot/2").GetComponent<carddis> ().poi = true;

					//Destroy(GameObject.Find("UIRoot/0").gameObject);
				} else if (isspc == true && find0 != "70" && find0 != "71" && find0 != "72" && find0 != "72" && find0 != "76" && find0 != "77" && find0 != "78" && find0 != "79" && find0 != "80") {
					drawcombo = 0;
					//		cardeffect.nextcard = find0;
					CmdCDis ("2S");
					ishand [2] = false;
					Usecard (find0);
					GameObject.Find ("UIRoot/2").GetComponent<carddis> ().poi = true;
					//Destroy(GameObject.Find("UIRoot/0").gameObject);
				}
			}
			if (Input.GetKeyDown (KeyCode.R) && ishand [3] == true) {
			
				string find0 = GameObject.Find ("UIRoot/3").GetComponent<UITexture> ().mainTexture.name;
				if (isspc == false) {
					drawcombo = 0;
					//		cardeffect.nextcard = find0;
					ishand [3] = false;
					CmdCDis ("3S");
					Usecard (find0);
					GameObject.Find ("UIRoot/3").GetComponent<carddis> ().poi = true;

					//Destroy(GameObject.Find("UIRoot/0").gameObject);
				} else if (isspc == true && find0 != "70" && find0 != "71" && find0 != "72" && find0 != "72" && find0 != "76" && find0 != "77" && find0 != "78" && find0 != "79" && find0 != "80") {
					drawcombo = 0;
					//		cardeffect.nextcard = find0;
					ishand [3] = false;
					CmdCDis ("3S");
					Usecard (find0);
					GameObject.Find ("UIRoot/3").GetComponent<carddis> ().poi = true;
					//Destroy(GameObject.Find("UIRoot/0").gameObject);
				}
			}
			if (Input.GetKeyDown (KeyCode.T) && ishand [4] == true) {
			
				string find0 = GameObject.Find ("UIRoot/4").GetComponent<UITexture> ().mainTexture.name;
				if (isspc == false) {
					drawcombo = 0;
					//		cardeffect.nextcard = find0;
					ishand [4] = false;
					CmdCDis ("4S");
					Usecard (find0);
					GameObject.Find ("UIRoot/4").GetComponent<carddis> ().poi = true;

					//Destroy(GameObject.Find("UIRoot/0").gameObject);
				} else if (isspc == true && find0 != "70" && find0 != "71" && find0 != "72" && find0 != "72" && find0 != "76" && find0 != "77" && find0 != "78" && find0 != "79" && find0 != "80") {
					drawcombo = 0;
					//		cardeffect.nextcard = find0;
					ishand [4] = false;
					CmdCDis ("4S");
					Usecard (find0);
					GameObject.Find ("UIRoot/4").GetComponent<carddis> ().poi = true;
					//Destroy(GameObject.Find("UIRoot/0").gameObject);
				}
			}
			if (combo == 0) {
				combodamageup = 1f;
			}
	
			if (drawcombo >= 10) {
				drawcombo = 0;
				Draw ();
			}
		}
	}

	public GameObject change;
	public GameObject dmgUper;
	public GameObject eff1;
	public GameObject eff2;
	public GameObject accel;
	public GameObject dc;
	public GameObject vis;
	public GameObject todoke;
	public GameObject jkctrl;
	public GameObject du;
	public GameObject NOE;
	public GameObject boom;
	public GameObject dmgheal;
	public GameObject spc;

	[Command]
	public void CmdChange (string num)
	{
		GameObject to = (GameObject)Instantiate (change);
		to.GetComponent<NETchange> ().team = ourteam;
		to.GetComponent<NETchange> ().num = num;
		NetworkServer.Spawn (to);
	}

	[Command]
	public void CmdAccel (byte num, bool jork)
	{
		GameObject to = (GameObject)Instantiate (accel);
		to.GetComponent<NETaccel> ().num = num;
		to.GetComponent<NETaccel> ().team = ourteam;
		to.GetComponent<NETaccel> ().jk = jork;
		NetworkServer.Spawn (to);
	}

	[Command]
	public void CmdReduce (byte num)
	{
		this.GetComponent<NETstaus> ().Getreduce (num);
	}

	[Command]
	public void CmdDC (byte n, bool jork)
	{
		GameObject to = (GameObject)Instantiate (dc);
		to.GetComponent<NETDC> ().jk = jork;
		to.GetComponent<NETDC> ().num = n;
		to.GetComponent<NETDC> ().team = ourteam;
		NetworkServer.Spawn (to);
	}

	[Command]
	public void CmdVis (byte num)
	{
		GameObject to = (GameObject)Instantiate (vis);
		to.GetComponent<NETVIS> ().num = num;
		to.GetComponent<NETVIS> ().team = ourteam;
		NetworkServer.Spawn (to);
	}

	[Command]
	public void Cmdtodoke (bool jork)
	{
		GameObject to = (GameObject)Instantiate (todoke);
		to.GetComponent<NETtodoke> ().team = ourteam;
		to.GetComponent<NETtodoke> ().jk = jork;
		NetworkServer.Spawn (to);
	}

	[Command]
	public void CmdJKctrl (bool jork)
	{
		GameObject to = (GameObject)Instantiate (jkctrl);
		to.GetComponent<NETJKctrl> ().team = ourteam;
		to.GetComponent<NETJKctrl> ().jk = jork;
		to.GetComponent<NETJKctrl> ().master = this.name;
		NetworkServer.Spawn (to);
	}

	[Command]
	public void CmdJKctrlboom (GameObject c)
	{
		c.GetComponent<NETJKctrl> ().boomflag = true;
	}

	public void JkCtrled (bool jork)
	{
		if (!jork) {
			this.transform.localPosition = jpos;
			Cmdjkset (false);
		} else if (jork) {
			this.transform.localPosition = kpos;
			Cmdjkset (true);
		}
	}

	[Command]
	public void CmdDU (bool jork, byte num)
	{
		GameObject to = (GameObject)Instantiate (du);
		to.GetComponent<NETDU> ().team = ourteam;
		to.GetComponent<NETDU> ().jk = jork;
		to.GetComponent<NETDU> ().num = num;
		to.GetComponent<NETDU> ().master = this.name;
		NetworkServer.Spawn (to);
	}

	[Command]
	public void CmdNOE (byte num)
	{
		GameObject to = (GameObject)Instantiate (NOE);
		to.GetComponent<NETNOE> ().team = ourteam;
		to.GetComponent<NETNOE> ().num = num;
		NetworkServer.Spawn (to);
	}

	[Command]
	public void CmdBoom (byte num)
	{
		GameObject to = (GameObject)Instantiate (boom);
		to.GetComponent<NETboom> ().team = ourteam;
		to.GetComponent<NETboom> ().num = num;
		to.GetComponent<NETboom> ().master = this.name;
		NetworkServer.Spawn (to);
	}

	public void heald (float dmg)
	{
		CmdHealDmg (dmg);
	}

	[Command]
	public void CmdHealDmg (float rec)
	{
		this.GetComponent<NETstaus> ().Heal (rec);
	}

	[Command]
	public void CmdSPC (byte num, bool jork)
	{
		GameObject to = (GameObject)Instantiate (spc);
		to.GetComponent<NETSPC> ().team = ourteam;
		to.GetComponent<NETSPC> ().num = num;
		to.GetComponent<NETSPC> ().master = this.name;
		to.GetComponent<NETSPC> ().jk = jork;
		NetworkServer.Spawn (to);
	}

	public void Usecard (string num)
	{
		byte n = System.Convert.ToByte (num);
		switch (n) {
		case 1:
		case 2:
		case 3:
		case 4:
		case 5:
		case 6:
		case 7:
		case 8:
		case 9:
		case 10:
		case 11:
		case 12:
		case 13:
		case 14:
		case 15:
		case 16:
		case 17:
		case 18:
		case 19:
		case 20:
		case 21:
		case 22:
		case 23:
		case 24:
			CmdChange (num);
			break;
		case 25:
		case 26:
		case 27:
		case 28:
		case 29:
		case 30:
		case 31:
		case 32:
		case 33:
		case 34:
		case 35:
		case 36:
		case 37:
		case 38:
			guup = 1;
			smup = 1;
			baup = 1;
			piup = 1;
			allup = 1;
			GameObject d = (GameObject)Instantiate (dmgUper);
			d.GetComponent<NETdmgup> ().num = n;
			d.GetComponent<NETdmgup> ().master = this.name;
			d.GetComponent<NETdmgup> ().team = ourteam;
			break;
		case 39:
		case 40:
		case 41:
		case 42:
		case 43:
		case 44:
		case 45:
		case 46:
		case 47:
			CmdAccel (n, jk);
			break;
		case 48:
		case 49:
		case 50:
			CmdReduce (n);
			break;
		case 51:
		case 52:
		case 53:
			CmdDC (n, jk);
			break;
		case 54:
		case 55:
		case 56:
			CmdVis (n);
			break;
		case 57:
			Cmdtodoke (jk);
			break;
		case 58:
			CmdJKctrl (jk);
			break;
		case 59:
		case 60:
		case 61:
			CmdDU (jk, n);
			break;
		case 62:
		case 63:
			CmdNOE (n);
			break;
		case 64:
		case 65:
		case 66:
			CmdBoom (n);
			break;
		case 67:
		case 68:
		case 69:
			GameObject to = (GameObject)Instantiate (dmgheal);
			to.GetComponent<NETdmgheal> ().num = n;
			to.GetComponent<NETdmgheal> ().master = this.name;
			break;
		case 70:
		case 71:
		case 72:
		case 73:
		case 74:
		case 75:
		case 80:
			CmdSPC (n, jk);
			break;
		}	
	}

	[Command]
	public void CmdCDis (string qq)
	{
		GameObject to = (GameObject)Instantiate (DIS);
		to.GetComponent<NETCardDis> ().who = qq;
		to.GetComponent<NETCardDis> ().master = this.name;
		NetworkServer.Spawn (to);
	}

	[Command]
	public void CmdDrawfly (byte qq)
	{
		GameObject to = (GameObject)Instantiate (drawF);
		to.GetComponent<NETDrawfly> ().who = qq;
		to.GetComponent<NETDrawfly> ().master = this.name;

		NetworkServer.Spawn (to);
	}

	[Command]
	public void CmdCreatmm ()
	{
		GameObject to = (GameObject)Instantiate (mm);
		to.transform.parent = this.transform;
		to.transform.localPosition = new Vector3 (0, 0, 0);
		NetworkServer.Spawn (to);
	}

	[Command]
	public void CmdCreatff ()
	{
		GameObject to = (GameObject)Instantiate (ff);
		to.transform.parent = this.transform;
		to.transform.localPosition = new Vector3 (0, 0, 0);
		NetworkServer.Spawn (to);
	}

	[Command]
	public void CmdCreatrr ()
	{
		GameObject to = (GameObject)Instantiate (rr);
		to.transform.parent = this.transform;
		to.transform.localPosition = new Vector3 (0, 0, 0);
		NetworkServer.Spawn (to);
	}

	[Command]
	public void CmdDie (GameObject bbb)
	{
		bbb.GetComponent<NETnewtempoP2> ().Dead = true;
	}

	[Command]
	public void CmdAttack (float dmg)
	{
		GameObject[] p = GameObject.FindGameObjectsWithTag ("Who");
			
		if (this.name == p [0].name) {
			target = p [1].name;
		} else if (this.name == p [1].name) {
			target = p [0].name;
		}
		GameObject to = GameObject.Find (target);
	
		to.GetComponent<NETstaus> ().Gethurt (dmg);
	}

	[Command]
	public void CmdBassAtk (bool jork)
	{
		GameObject[] p = GameObject.FindGameObjectsWithTag ("Who");

		if (this.name == p [0].name) {
			target = p [1].name;
		} else if (this.name == p [1].name) {
			target = p [0].name;
		}
		if (!jork) {
			GameObject to = GameObject.Find (target);
			to.GetComponent<NETstaus> ().GetBass (jork);
		} else if (jork) {	
			GameObject to = GameObject.Find (target);
			float up = to.GetComponent<NETstaus> ().nowdeff;
			this.GetComponent<NETstaus> ().CmdBassAttackUPDEF (up);
			to.GetComponent<NETstaus> ().GetBass (jork);
		}
	}

	[Command]
	public void CmdPiano (bool jork, float dmg)
	{
		if (!jork) {
			this.GetComponent<NETstaus> ().GetPiano (false, 0f);
		} else if (jork) {
			this.GetComponent<NETstaus> ().GetPiano (true, dmg * 0.05f);
		}	
	}

	[Command]
	public void CmdHeal (bool jork, float rate, float rec)
	{
		if (!jork) {
			this.GetComponent<NETstaus> ().Heal (rec * rate);
		} else if (jork) {
			this.GetComponent<NETstaus> ().Heal (rec);
		}
	}

	[Command]
	public void CmdGU ()
	{
		this.GetComponent<NETstaus> ().GetGu ();
	}

	[Command]
	public void CmdGO (byte t)
	{
		if (t == 1) {
			GameObject to = (GameObject)Instantiate (eff1);
			NetworkServer.Spawn (to);
		} else if (t == 2) {
			GameObject to = (GameObject)Instantiate (eff2);
			NetworkServer.Spawn (to);
		}
	}

	[Command]
	public void CmdDes (byte t)
	{
		if (t == 1) {
			Destroy (GameObject.Find ("P1eff(Clone)").gameObject);
			NetworkServer.Destroy (GameObject.Find ("P1eff(Clone)").gameObject);
		} else if (t == 2) {
			Destroy (GameObject.Find ("P2eff(Clone)").gameObject);
			NetworkServer.Destroy (GameObject.Find ("P2eff(Clone)").gameObject);
		}
	}

	public void Damage (float pos, string who, bool jork)
	{
		GameObject.Find ("hitSE").GetComponent<AudioSource> ().Play ();
		float atk = this.GetComponent<NETstaus> ().nowatk;
		float dmg;
		if (!jork) {
			if (who == "gu") {
				dmg = 0.8f * 1.1f * atk * pos * (guup * allup + powerup) * combodamageup * weakup;
				CmdAttack (dmg);
			
			} else if (who == "ciang") {
				dmg = 0.8f * atk * pos * (baup * allup + powerup) * combodamageup * weakup;
				CmdAttack (dmg);
				CmdBassAtk (false);

			} else if (who == "piano") {
				dmg = 0.8f * atk * pos * (piup * allup + powerup) * combodamageup * weakup;
				CmdAttack (dmg);
				CmdPiano (false, dmg);

			} else if (who == "di") {
				float rec = this.GetComponent<NETstaus> ().rec;
				dmg = 0.8f * 0.5f * atk * pos * (smup * allup + powerup) * combodamageup * weakup;
				CmdAttack (dmg);
				CmdHeal (false, (smup * allup + powerup) * combodamageup * pos * weakup, rec);

			} else if (who == "ff") {
				float rec = this.GetComponent<NETstaus> ().rec;
				dmg = 0.8f * 1.1f * atk * pos * (guup * baup * piup * smup * allup + powerup) * combodamageup * weakup;
				CmdAttack (dmg);
				CmdBassAtk (false);
				CmdPiano (false, dmg);
				CmdHeal (false, smup * allup * combodamageup * pos * weakup, rec);
			} else if (who == "duo") {
				this.GetComponent<NETstaus> ().nowhp -= this.GetComponent<NETstaus> ().nowhp * 0.05f;

			}
		
		} else if (jork) {
			if (who == "gu") {

				CmdGU ();
			} else if (who == "ciang") {
				dmg = 0.8f * atk * pos * (baup * allup + powerup) * combodamageup * weakup;

				CmdBassAtk (true);
			} else if (who == "piano") {
				dmg = 0.8f * atk * pos * (piup * allup + powerup) * combodamageup * weakup * 0.5f;
				CmdAttack (dmg);
				CmdPiano (true, dmg);
			} else if (who == "di") {
				float rec = this.GetComponent<NETstaus> ().rec;
				dmg = 0.8f * 0.5f * atk * (smup * allup + powerup) * combodamageup * weakup - rec;
				CmdAttack (dmg);
				CmdHeal (true, pos * (smup * allup + powerup) * combodamageup * weakup, rec);
			} else if (who == "ff") {
				float rec = this.GetComponent<NETstaus> ().rec;
				dmg = 0.8f * atk * pos * (guup * baup * piup * smup * allup + powerup) * combodamageup * weakup - rec;
				CmdAttack (dmg);
				CmdBassAtk (true);
				CmdPiano (true, dmg);
				CmdHeal (true, (smup * allup + powerup) * combodamageup * pos * weakup, rec);
			} 
		}
	}

	public void Draw ()
	{
		for (int q=0; q<5; q++) {

			if (ishand [q] == false && handd.Count > 0) {

				GameObject.Find ("drawSE").GetComponent<AudioSource> ().Play ();
				ishand [q] = true;
				CmdDeckDraw ();
				Instantiate (Resources.Load ("hand/" + handd.Peek ()));
				GameObject.Find (handd.Peek () + "(Clone)").transform.parent = GameObject.Find ("UIRoot").transform;
				GameObject.Find (handd.Peek () + "(Clone)").transform.localScale = new Vector3 (1, 1, 1);

				//Here Have To Change
				GameObject.Find (handd.Peek () + "(Clone)").transform.localPosition = new Vector3 (-6600 + q * 1800, -4500 + (team - 1) * 10000, 0);

				if (team == 1) {
					GameObject.Find (handd.Peek () + "(Clone)").GetComponent<cardfly> ().fly = true;
				} else if (team == 2) {
					GameObject.Find (handd.Peek () + "(Clone)").GetComponent<cardfly> ().flydown = true;
				}
				GameObject.Find (handd.Dequeue () + "(Clone)").name = System.Convert.ToString (q);

				CmdDrawfly (System.Convert.ToByte (q));
				break;
			}
		}
	}

	public void DrawFull ()
	{
		for (int q=0; q<5; q++) {
			if (ishand [q] == false && handd.Count > 0) {

				GameObject.Find ("drawSE").GetComponent<AudioSource> ().Play ();
				ishand [q] = true;
				CmdDeckDraw ();
				Instantiate (Resources.Load ("hand/" + handd.Peek ()));
				GameObject.Find (handd.Peek () + "(Clone)").transform.parent = GameObject.Find ("UIRoot").transform;
				GameObject.Find (handd.Peek () + "(Clone)").transform.localScale = new Vector3 (1, 1, 1);

				//Here Have To Change
				GameObject.Find (handd.Peek () + "(Clone)").transform.localPosition = new Vector3 (-6600 + q * 1800, -4500 + (team - 1) * 10000, 0);

				if (team == 1) {
					GameObject.Find (handd.Peek () + "(Clone)").GetComponent<cardfly> ().fly = true;
				} else if (team == 2) {
					GameObject.Find (handd.Peek () + "(Clone)").GetComponent<cardfly> ().flydown = true;
				}
				GameObject.Find (handd.Dequeue () + "(Clone)").name = System.Convert.ToString (q);
				
				CmdDrawfly (System.Convert.ToByte (q));
			}
		}
	}

	void GetCardinDeck (byte t)
	{
		if (isLocalPlayer) {
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
		
		
		
			Random.seed = System.Guid.NewGuid ().GetHashCode ();
		
			for (int q=1; q<1000; q++) {
			
				int o = Random.Range (0, 30);
				int p = Random.Range (0, 30);
			
				string change = deck [o];
				deck [o] = deck [p];
				deck [p] = change;
			}
		
			for (int q=0; q<30; q++) {
				handd.Enqueue (deck [q]);
				CmdDeckPlus ();
			}

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
			for (int q=0; q<20; q++) {
				Sub.Enqueue (deck2 [q]);
			}
		}

		father = GameObject.Find ("UIRoot").transform;
		for (int q=0; q<5; q++) {

			if (isLocalPlayer) {
				Instantiate (Resources.Load ("hand/" + handd.Peek ()));
				CmdDeckDraw ();
				GameObject.Find (handd.Peek () + "(Clone)").transform.parent = GameObject.Find ("UIRoot").transform;
				GameObject.Find (handd.Peek () + "(Clone)").transform.localScale = new Vector3 (1, 1, 1);

				//First 5 Card, X Pos Is Same To Single,
				//Y Pos: t - 1 = 0 -> Host Player, t - 1 = 1 -> Client Player,
				//Use This To Let Client's Card At High Place
				GameObject.Find (handd.Peek () + "(Clone)").transform.localPosition = new Vector3 (-6600 + q * 1800, -3300 + (t - 1) * 6000, 0);

				string qw = q.ToString ();
				GameObject.Find (handd.Dequeue () + "(Clone)").name = qw;
			
			} else if (!isLocalPlayer) {
				Instantiate (ba);
				GameObject.Find ("cardback(Clone)").transform.parent = GameObject.Find ("UIRoot").transform;
				GameObject.Find ("cardback(Clone)").transform.localScale = new Vector3 (1, 1, 1);

				//Card Back
				GameObject.Find ("cardback(Clone)").transform.localPosition = new Vector3 (-6600 + q * 1800, -3300 + (t - 1) * 6000, 0);

				string qw = q.ToString () + "S";
				GameObject.Find ("cardback(Clone)").name = qw;
			}

			ishand [q] = true;
		}
	}
}
