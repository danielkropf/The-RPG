using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class addAP : MonoBehaviour {

	public GameObject twGO;
	
	private theWay tw;
	private Text txt;

	public GameObject strPlus;
	public GameObject dexPlus;
	public GameObject carPlus;
	public GameObject conPlus;
	public GameObject intPlus;

	void Start() {

		tw = twGO.GetComponent<theWay>();
	}

	public void addAtributePoint(string atributo) {

		Debug.Log (atributo + " ++");
		switch (atributo) {
		case "STR":

			tw.tst.remainingAP--;
			tw.tst.str++;

			break;

		case "DEX":
			
			tw.tst.remainingAP--;
			tw.tst.dex++;

			break;

		case "CAR":
			
			tw.tst.remainingAP--;
			tw.tst.car++;

			break;

		case "CON":
			
			tw.tst.remainingAP--;
			tw.tst.con++;

			break;

		case "INT":
			
			tw.tst.remainingAP--;
			tw.tst.intel++;

			break;
		
		}
	}

	public void removeAP(string atributo) {

		Debug.Log (atributo + " --");
		switch (atributo) {
		case "STR":
			
			tw.tst.remainingAP++;
			tw.tst.str--;

			break;
			
		case "DEX":
			
			tw.tst.remainingAP++;
			tw.tst.dex--;
			
			break;
			
		case "CAR":
			
			tw.tst.remainingAP++;
			tw.tst.car--;
			
			break;
			
		case "CON":
			
			tw.tst.remainingAP++;
			tw.tst.con--;
			
			break;
			
		case "INT":
			
			tw.tst.remainingAP++;
			tw.tst.intel--;
			
			break;
			
		}
	}

	public void addMaxAP(string atributo) {
		
		int diferenca;
		switch (atributo) {
			
			case "STR":
				
				diferenca = tw.tst.maxAP - tw.tst.str;
				if(tw.tst.remainingAP >= diferenca) {
					tw.tst.str += diferenca;
					tw.tst.remainingAP -= diferenca;
				} else {

					diferenca = tw.tst.remainingAP;
					tw.tst.str += diferenca;
					tw.tst.remainingAP -= diferenca;
				}
				
				break;
				
			case "DEX":
				
				diferenca = tw.tst.maxAP - tw.tst.dex;
				if(tw.tst.remainingAP >= diferenca) {
					tw.tst.dex += diferenca;
					tw.tst.remainingAP -= diferenca;
				} else {
					
					diferenca = tw.tst.remainingAP;
					tw.tst.dex += diferenca;
					tw.tst.remainingAP -= diferenca;
				}

				break;
				
			case "CAR":

				diferenca = tw.tst.maxAP - tw.tst.car;
				if(tw.tst.remainingAP >= diferenca) {
					tw.tst.car += diferenca;
					tw.tst.remainingAP -= diferenca;
				} else {
					
					diferenca = tw.tst.remainingAP;
					tw.tst.car += diferenca;
					tw.tst.remainingAP -= diferenca;
				}

				break;
				
			case "CON":

				diferenca = tw.tst.maxAP - tw.tst.con;
				if(tw.tst.remainingAP >= diferenca) {
					tw.tst.con += diferenca;
					tw.tst.remainingAP -= diferenca;
				} else {
					
					diferenca = tw.tst.remainingAP;
					tw.tst.con += diferenca;
					tw.tst.remainingAP -= diferenca;
				}

				break;
				
			case "INT":

				diferenca = tw.tst.maxAP - tw.tst.intel;
				if(tw.tst.remainingAP >= diferenca) {
					tw.tst.intel += diferenca;
					tw.tst.remainingAP -= diferenca;
				} else {
					
					diferenca = tw.tst.remainingAP;
					tw.tst.intel += diferenca;
					tw.tst.remainingAP -= diferenca;
				}

				break;
		}
	}
	
	public void removeMaxAP(string atributo) {
		
		int diferenca;
		switch (atributo) {
			
		case "STR":
			
			diferenca = tw.tst.str - tw.tst.minAP;
			tw.tst.str -= diferenca;
			tw.tst.remainingAP += diferenca;
			
			break;
			
		case "DEX":
			
			diferenca = tw.tst.dex - tw.tst.minAP;
			tw.tst.dex -= diferenca;
			tw.tst.remainingAP += diferenca;
						
			break;
			
		case "CAR":
			
			diferenca = tw.tst.car - tw.tst.minAP;
			tw.tst.car -= diferenca;
			tw.tst.remainingAP += diferenca;
						
			break;
			
		case "CON":
			
			diferenca = tw.tst.intel - tw.tst.minAP;
			tw.tst.con -= diferenca;
			tw.tst.remainingAP += diferenca;
						
			break;
			
		case "INT":
			
			diferenca = tw.tst.intel - tw.tst.minAP;
			tw.tst.intel -= diferenca;
			tw.tst.remainingAP += diferenca;
						
			break;
		}
	}
	
	void Update() {

		switch(this.name) {
		case "pointsSTR":
			txt = this.GetComponent<Text>();
			txt.text = tw.tst.strTotal.ToString();

			txt = strPlus.GetComponent<Text>();
			txt.text = "+ (" + tw.tst.str.ToString() + ")";
			break;

		case "pointsDEX":
			txt = this.GetComponent<Text>();
			txt.text = tw.tst.dexTotal.ToString();

			txt = dexPlus.GetComponent<Text>();
			txt.text = "+ (" + tw.tst.dex.ToString() + ")";
			break;

		case "pointsCAR":
			txt = this.GetComponent<Text>();
			txt.text = tw.tst.carTotal.ToString();

			txt = carPlus.GetComponent<Text>();
			txt.text = "+ (" + tw.tst.car.ToString() + ")";
			break;

		case "pointsCON":
			txt = this.GetComponent<Text>();
			txt.text = tw.tst.conTotal.ToString();

			txt = conPlus.GetComponent<Text>();
			txt.text = "+ (" + tw.tst.con.ToString() + ")";
			break;

		case "pointsINT":
			txt = this.GetComponent<Text>();
			txt.text = tw.tst.intelTotal.ToString();

			txt = intPlus.GetComponent<Text>();
			txt.text = "+ (" + tw.tst.intel.ToString() + ")";
			break;

		}
	}
}
