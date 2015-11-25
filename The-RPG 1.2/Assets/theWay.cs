using UnityEngine;
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

	void Start () {
	
		sv = svGO.GetComponent<save>();
		tst = tstGO.GetComponent<teste>();
		adAP = adAPGO.GetComponent<addAP>();
		mp = mpGO.GetComponent<maxPoints>();
	}
}
