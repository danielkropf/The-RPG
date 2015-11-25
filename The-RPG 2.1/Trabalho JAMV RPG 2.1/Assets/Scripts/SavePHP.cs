using UnityEngine;
using System.Collections;

public class SavePHP : MonoBehaviour {

	public string url = "danielkropf.16mb.com";
	public int XP = -1;
	public int Lvl_Max = -1;
	public int Nivel = -1;

	// Use this for initialization
	void Start () {
		//Save ();
		Load ();
	}
	
	IEnumerator SaveToPHP()
	{
		WWWForm form = new WWWForm();
		form.AddField("Service", "Save");
		form.AddField("User", "kirito");
		form.AddField("Nivel", 7);
		form.AddField("Lvl_Max", 42);
		form.AddField("XP", 668);
		WWW w = new WWW(url, form);
		yield return w;
		Debug.Log(w.text);
	}

	IEnumerator LoadFromPHP()
	{
		WWWForm form = new WWWForm();
		form.AddField("Service", "Load");
		form.AddField("User", "teste");
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
						XP = int.Parse(info[1]);
						break;
					case "Nivel":
						Nivel = int.Parse(info[1]);
						break;
					case "Lvl_Max":
						Lvl_Max = int.Parse(info[1]);
						break;
				}
			}
		}
	}

	public void Save()
	{
		StartCoroutine (SaveToPHP ());
	}

	public void Load()
	{
		StartCoroutine (LoadFromPHP ());
	}
}