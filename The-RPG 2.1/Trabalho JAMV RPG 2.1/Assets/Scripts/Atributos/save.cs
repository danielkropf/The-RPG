using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class save : MonoBehaviour {

	public GameObject strBar;
	public GameObject dexBar;
	public GameObject conBar;
	public GameObject intBar;
	public GameObject lukBar;

	public GameObject strBarTotal;
	public GameObject dexBarTotal;
	public GameObject conBarTotal;
	public GameObject intBarTotal;
	public GameObject lukBarTotal;

	public GameObject twGO;

	private theWay tw;
	private Slider sld;

    public GameObject atributos;
    public GameObject inface;
    public GameObject selFase;

	public void Start() {

		tw = twGO.GetComponent<theWay>();
	}

	public void saveAPChanges() {

		tw.tst.strTotal += tw.tst.str;
		tw.tst.dexTotal += tw.tst.dex;
		tw.tst.conTotal += tw.tst.con;
		tw.tst.intelTotal += tw.tst.intel;
		tw.tst.lukTotal += tw.tst.luk;

		tw = twGO.GetComponent<theWay>();

		sld = strBar.GetComponent<Slider> ();
		sld.value = 0;
		sld = strBarTotal.GetComponent<Slider> ();
		sld.value += tw.tst.strTotal;
		tw.tst.str = 0;

		sld = dexBar.GetComponent<Slider> ();
		sld.value = 0;
		sld = dexBarTotal.GetComponent<Slider> ();
		sld.value += tw.tst.dexTotal;
		tw.tst.dex = 0;

		sld = conBar.GetComponent<Slider> ();
		sld.value = 0;
		sld = conBarTotal.GetComponent<Slider> ();
		sld.value += tw.tst.conTotal;
		tw.tst.con = 0;

		sld = intBar.GetComponent<Slider> ();
		sld.value = 0;
		sld = intBarTotal.GetComponent<Slider> ();
		sld.value += tw.tst.intelTotal;
		tw.tst.intel = 0;

		sld = lukBar.GetComponent<Slider>();
		sld.value = 0;
		sld = lukBarTotal.GetComponent<Slider>();
		sld.value += tw.tst.lukTotal;
		tw.tst.luk = 0;

        inface.SetActive(true);
        atributos.SetActive(false);
        selFase.SetActive(true);
		theWay.cena = "selFase";
		Debug.Log("mudou cena");
	}
}
