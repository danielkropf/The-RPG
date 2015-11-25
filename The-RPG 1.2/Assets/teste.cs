﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class teste : MonoBehaviour {

	public int remainingAP = 500;
	public int str = 0;
	public int dex = 0;
	public int car = 0;
	public int con = 0;
	public int intel = 0;
	public int minAP = 0;
	public int maxAP = 20;

	public int strTotal;
	public int dexTotal;
	public int carTotal;
	public int conTotal;
	public int intelTotal;
	
	public GameObject strBar;
	public GameObject dexBar;
	public GameObject carBar;
	public GameObject conBar;
	public GameObject intBar;
	public GameObject strBarTotal;
	public GameObject dexBarTotal;
	public GameObject carBarTotal;
	public GameObject conBarTotal;
	public GameObject intBarTotal;

	private Slider sld;
	private Text txt;

	// Use this for initialization
	void Update () {

		txt = this.GetComponent<Text>();
		txt.text = "Pontos restantes: " + remainingAP;

		sld = strBar.GetComponent<Slider>();
		sld.value = str;
		sld = strBarTotal.GetComponent<Slider>();
		sld.value = strTotal;

		sld = dexBar.GetComponent<Slider>();
		sld.value = dex;
		sld = dexBarTotal.GetComponent<Slider>();
		sld.value = dexTotal;

		sld = carBar.GetComponent<Slider>();
		sld.value = car;
		sld = carBarTotal.GetComponent<Slider>();
		sld.value = carTotal;

		sld = conBar.GetComponent<Slider>();
		sld.value = con;
		sld = conBarTotal.GetComponent<Slider>();
		sld.value = conTotal;

		sld = intBar.GetComponent<Slider>();
		sld.value = intel;
		sld = intBarTotal.GetComponent<Slider>();
		sld.value = intelTotal;

		sld = null;

		sld = strBarTotal.GetComponent<Slider>();
		if (sld.maxValue - sld.value < 20) {
		
			float dif = sld.maxValue - sld.value;

			sld = strBar.GetComponent<Slider>();
			sld.maxValue = dif;
		}

		sld = dexBarTotal.GetComponent<Slider>();
		if (sld.maxValue - sld.value < 20) {
			
			float dif = sld.maxValue - sld.value;
			
			sld = dexBar.GetComponent<Slider>();
			sld.maxValue = dif;
		}

		sld = carBarTotal.GetComponent<Slider>();
		if (sld.maxValue - sld.value < 20) {
			
			float dif = sld.maxValue - sld.value;
			
			sld = carBar.GetComponent<Slider>();
			sld.maxValue = dif;
		}

		sld = conBarTotal.GetComponent<Slider>();
		if (sld.maxValue - sld.value < 20) {
			
			float dif = sld.maxValue - sld.value;
			
			sld = conBar.GetComponent<Slider>();
			sld.maxValue = dif;
		}

		sld = intBarTotal.GetComponent<Slider>();
		if (sld.maxValue - sld.value < 20) {
			
			float dif = sld.maxValue - sld.value;
			
			sld = intBar.GetComponent<Slider>();
			sld.maxValue = dif;
		}

	}
}
