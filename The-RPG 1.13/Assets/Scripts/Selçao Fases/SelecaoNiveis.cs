using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SelecaoNiveis : MonoBehaviour {

	public int lvlMax = 1;
	public int lvlAtual = 1;

    public GameObject twGO;
    private theWay tw;

    public GameObject hpBar;
    public GameObject mpBar;
	
	private Text txt;
	private Slider sld;

    void Start() { 
        tw = twGO.GetComponent<theWay>();
    }

	void Update () {

        sld = hpBar.GetComponent<Slider>();
        sld.maxValue = 50 + (5 * tw.tst.lvlPlayer) + (2 * tw.tst.conTotal);
        sld.value = sld.maxValue;

        sld = mpBar.GetComponent<Slider>();
        sld.maxValue = 30 + (5 * tw.tst.lvlPlayer) + (2 + tw.tst.intelTotal);
        sld.value = sld.maxValue;

		txt = this.GetComponent<Text>();
		txt.text = "Nivel: " + lvlAtual;
		sld = GameObject.Find ("Progressão").GetComponent<Slider>();
		sld.value = lvlAtual;
		sld = GameObject.Find ("ProgressãoMax").GetComponent<Slider>();
		sld.value = lvlMax;
	}
}
