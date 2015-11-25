using UnityEngine;
using System.Collections;

public class buttons : MonoBehaviour {
	
	private theWay tw;

	public GameObject atributos;
	public GameObject selNiveis;
    public GameObject inface;

	void Start() {

		tw = this.GetComponent<theWay>();
	}

	public void nextLvl() {

		if (tw.sn.lvlAtual < tw.sn.lvlMax) {
		
			tw.sn.lvlAtual++;
		}
	}
	public void previousLvl() {
		
		if (tw.sn.lvlAtual > 1) {
			
			tw.sn.lvlAtual--;
		}
	}
	public void toAtributos() {
	
		selNiveis.SetActive (false);
		atributos.SetActive (true);
        inface.SetActive(false);
		theWay.cena = "atributos";
		Debug.Log("mudou cena");
	}
}