using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Save_User : MonoBehaviour {

	public string Nick;

	GameObject botao;
	// Use this for initialization
	void Start () {
		botao = GameObject.Find ("Canvas/InputField");
		botao.gameObject.GetComponent<InputField>();
	
	}
	
	// Update is called once per frame
	public void Save () {
		if(botao.gameObject.GetComponent<InputField>().text != null){
			Nick = botao.gameObject.GetComponent<InputField>().text;
		}
		Debug.Log (Nick);
	}

	public void Jogar () {
		if (Nick != "") {
			Application.LoadLevel ("Jogo");
		}
	}
	public void Sair () {
		Application.Quit ();
	}
}
