using UnityEngine;
using System.Collections;

public class CreateEnemys : MonoBehaviour {

    private GameObject go;
    private theWay tw;

    public GameObject SelFase;
    public GameObject InGame;
    public GameObject jojo;

    private int normalEnemys;
    private int miniBoss;
    private int boss;

    void Start() {
        go = GameObject.Find("Main Camera");
        tw = go.GetComponent<theWay>();
    }
	
	void Update () {
        Debug.Log("normalEnemys = " + normalEnemys);
	}

    public void numEnemys() {

        if (tw.sn.lvlAtual % 2 == 0)
        {   
            normalEnemys = 0;
            normalEnemys = 1 + (tw.sn.lvlAtual / 2);
        }
        else {
            normalEnemys = 0;
            normalEnemys = 1 + ((tw.sn.lvlAtual - 1) / 2 );
        }

        if (tw.sn.lvlAtual % 5 == 0) {
            miniBoss = 0;
            if(tw.sn.lvlAtual / 5 < 3)miniBoss++;
            if(tw.sn.lvlAtual / 5 > 2) miniBoss++;
        }

        if(tw.sn.lvlAtual % 10 == 0) {
            boss = 0;
            boss++;
        }


    }
}
