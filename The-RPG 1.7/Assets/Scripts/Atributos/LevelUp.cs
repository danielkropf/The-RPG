using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelUp : MonoBehaviour {

    public GameObject twGO;
    private theWay tw;

    private bool showBonusStats;
    public GameObject xpBar;
    public GameObject hpBar;
    public GameObject mpBar;

    private Slider sld;

    void Start() { 
        tw = twGO.GetComponent<theWay>();
    }

	// Update is called once per frame
	void Update () {
        sld = xpBar.GetComponent<Slider>();
        if (sld.value >= sld.maxValue) {
            tw.tst.lvlPlayer++;
            sld.maxValue = sld.maxValue * 1.1f;
            sld.value = sld.minValue;
            tw.tst.remainingAP += 7;
            if (!tw.ce.started)
            {
                sld = hpBar.GetComponent<Slider>();
                sld.maxValue = sld.maxValue * (1 + (tw.tst.lvlPlayer / 10));
                sld.value = sld.maxValue;
                sld = mpBar.GetComponent<Slider>();
                sld.maxValue = sld.maxValue * (1 + (tw.tst.lvlPlayer / 10));
                sld.value = sld.maxValue;
            }
        }
	}
}
