using UnityEngine;
using System.Collections;

public class ActivateSkills : MonoBehaviour {

    private GameObject twGO;
    private theWay tw;

    public int cd = 0;

    void Start()
    {
        twGO = GameObject.Find("Main Camera");
        tw = twGO.GetComponent<theWay>();
    }

    public void useSkills(int skill) { 
    
        if(tw.ce.started && cd <= 0) {
            tw.btl.skillUsed = skill;
            tw.btl.usedSkill = true;
        }
    }
}
