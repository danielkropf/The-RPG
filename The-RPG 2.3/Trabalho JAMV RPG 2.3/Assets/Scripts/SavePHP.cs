using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SavePHP : MonoBehaviour {

	public GameObject twGO;
	private theWay tw;

	public string url = "danielkropf.16mb.com";

	private Slider sld;

	// Use this for initialization
	void Start () {
		tw = twGO.GetComponent<theWay>();
		sld = tw.lu.xpBar.GetComponent<Slider>();
	}

	IEnumerator SaveToPHP()
	{
		WWWForm form = new WWWForm();
		form.AddField("Service", "Save");
		form.AddField("User", tw.su.Nick);
		form.AddField("Nivel", tw.tst.lvlPlayer);
		form.AddField("Lvl_Max", tw.sn.lvlMax);
		form.AddField("XP", Mathf.FloorToInt(sld.value));
		form.AddField("STR", tw.tst.strTotal);
		form.AddField("DEX", tw.tst.dexTotal);
		form.AddField("CON", tw.tst.conTotal);
		form.AddField("INT", tw.tst.intelTotal);
		form.AddField("LUK", tw.tst.lukTotal);
		form.AddField("Atributos", tw.tst.remainingAP);
		form.AddField("FIRE", tw.lus.fireballLvl);
		form.AddField("EXPL", tw.lus.explosionLvl);
		form.AddField("HEAL", tw.lus.healLvl);
		form.AddField("DOUBLE", tw.lus.doubleHitLvl);
		form.AddField("REVENGE", tw.lus.revengeLvl);
		form.AddField("LIFE", tw.lus.drainLvl);
		form.AddField("Skill_P", tw.lus.skillPoints);

		WWW w = new WWW(url, form);
		yield return w;
		Debug.Log(w.text);
	}

	IEnumerator LoadFromPHP()
	{
		WWWForm form = new WWWForm();
		form.AddField("Service", "Load");
		form.AddField ("User", tw.su.Nick);
		WWW w = new WWW(url, form);
		yield return w;
		Debug.Log(w.text);
		if (w.text == "error") {
			//USUARIO NAO EXISTE
			Debug.Log ("NAO ECZISTE!");
		} else
		{
			string[] datas = w.text.Split(';');
			foreach(string data in datas)
			{
				string[] info = data.Split('=');
				switch(info[0])
				{
					case "XP":
						sld.value = int.Parse(info[1]);
						break;
					case "Nivel":
						tw.tst.lvlPlayer = int.Parse(info[1]);
						break;
					case "Lvl_Max":
						tw.sn.lvlMax = int.Parse(info[1]);
						tw.sn.lvlAtual = 1;
						break;
					case "STR":
						tw.tst.strTotal = int.Parse(info[1]);
						break;
					case "DEX":
						tw.tst.dexTotal = int.Parse(info[1]);
						break;
					case "CON":
						tw.tst.conTotal = int.Parse(info[1]);
						break;
					case "INT":
						tw.tst.intelTotal = int.Parse(info[1]);
						break;
					case "LUK":
						tw.tst.lukTotal = int.Parse(info[1]);
						break;
					case "Atributos":
						tw.tst.remainingAP = int.Parse(info[1]);
						break;
					case "FIRE":
						tw.lus.fireballLvl = int.Parse(info[1]);
						break;
					case "EXPL":
						tw.lus.explosionLvl = int.Parse(info[1]);
						break;
					case "HEAL":
						tw.lus.healLvl = int.Parse(info[1]);
						break;
					case "DOUBLE":
						tw.lus.doubleHitLvl = int.Parse(info[1]);
						break;
					case "REVENGE":
						tw.lus.revengeLvl = int.Parse(info[1]);
						break;
					case "LIFE":
						tw.lus.drainLvl = int.Parse(info[1]);
						break;
					case "Skill_P":
						tw.lus.skillPoints = int.Parse(info[1]);
						break;
				}
			}
		}
	}

	public void Save()
	{
		if(tw.su.Nick != "") StartCoroutine (SaveToPHP ());
	}

	public void Load()
	{
		if(tw.su.Nick != "") StartCoroutine (LoadFromPHP ());
	}
}