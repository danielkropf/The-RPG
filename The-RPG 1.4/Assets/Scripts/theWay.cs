﻿using UnityEngine;
using System.Collections;

public class theWay : MonoBehaviour {

	public GameObject tstGO;
	public teste tst;

	public GameObject adAPGO;
	public addAP adAP;

	public GameObject mpGO;
	public maxPoints mp;

	public GameObject svGO;
	public save sv;

	public GameObject snGO;
	public SelecaoNiveis sn;

	public GameObject btnsGO;
	public buttons btns;

	void Start () {
	
		sv = svGO.GetComponent<save>();
		tst = tstGO.GetComponent<teste>();
		adAP = adAPGO.GetComponent<addAP>();
		mp = mpGO.GetComponent<maxPoints>();
		sn = snGO.GetComponent<SelecaoNiveis>();
		btns = btnsGO.GetComponent<buttons>();
	}
}
