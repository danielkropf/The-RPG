using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class maxPoints : MonoBehaviour {

	public GameObject btn_Add;
	public GameObject btn_Remove;
	public GameObject btn_Max;
	public GameObject btn_Min;
	public GameObject twGO;

	private theWay tw;

	private Slider sld;
	private Button btn;
	private Image img;

	// Use this for initialization
	void Start () {
		tw = twGO.GetComponent<theWay>();
	}
	
	// Update is called once per frame
	void Update () {
		sld = this.GetComponent<Slider>();
		if (sld.value >= sld.maxValue || tw.tst.remainingAP <= 0) {

			img = btn_Add.GetComponent<Image> ();
			img.color = new Color32 (131, 131, 131, 255);

			btn = btn_Add.GetComponent<Button> ();
			btn.interactable = false;

			img = btn_Max.GetComponent<Image> ();
			img.color = new Color32 (131, 131, 131, 255);
			
			btn = btn_Max.GetComponent<Button> ();
			btn.interactable = false;
		} else {
			img = btn_Add.GetComponent<Image> ();
			img.color = new Color32 (255, 255, 255, 255);

			btn = btn_Add.GetComponent<Button> ();
			btn.interactable = true;

			img = btn_Max.GetComponent<Image> ();
			img.color = new Color32 (255, 255, 255, 255);
			
			btn = btn_Max.GetComponent<Button> ();
			btn.interactable = true;
		}
		if (sld.value <= sld.minValue) {

			img = btn_Remove.GetComponent<Image>();
			img.color = new Color32(131, 131, 131, 255);

			btn = btn_Remove.GetComponent<Button>();
			btn.interactable = false;

			img = btn_Min.GetComponent<Image>();
			img.color = new Color32(131, 131, 131, 255);
			
			btn = btn_Min.GetComponent<Button>();
			btn.interactable = false;
		} else {
			img = btn_Remove.GetComponent<Image> ();
			img.color = new Color32 (255, 255, 255, 255);

			btn = btn_Remove.GetComponent<Button> ();
			btn.interactable = true;

			img = btn_Min.GetComponent<Image>();
			img.color = new Color32(255, 255, 255, 255);
			
			btn = btn_Min.GetComponent<Button>();
			btn.interactable = true;
		}
	}
}
