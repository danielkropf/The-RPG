using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SelecaoNiveis : MonoBehaviour {

	public int lvlMax = 1;
	public int lvlAtual = 1;
	
	private Text txt;
	private Slider sld;
	
	// Update is called once per frame
	void Update () {

		txt = this.GetComponent<Text>();
		txt.text = "Nivel: " + lvlAtual;
		sld = GameObject.Find ("Progressão").GetComponent<Slider>();
		sld.value = lvlAtual;
		sld = GameObject.Find ("ProgressãoMax").GetComponent<Slider>();
		sld.value = lvlMax;
	}
}
