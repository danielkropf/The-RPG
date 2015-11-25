using UnityEngine;
using System.Collections;

public class ActivateSkills : MonoBehaviour {

    private GameObject twGO;
    private theWay tw;

	public int turn = 0;
    public int cd = 0;

    void Start()
    {
        twGO = GameObject.Find("Main Camera");
        tw = twGO.GetComponent<theWay>();
    }

	void Update() { 
		if(tw.btl.turn > turn) {
			turn = tw.btl.turn;
			if (cd > 0) {
				cd--;
			}
		}
		if(turn > tw.btl.turn) {
			cd = 0;
			turn = 0;
		}
	}

    public void useSkills(int skill) { 
    
        if(tw.ce.started && cd <= 0) {
            tw.btl.skillUsed = skill;
            tw.btl.usedSkill = true;
        }
    }
	public void setCD(int cd2) {
		if(theWay.cena == "jogo" && cd == 0) cd = cd2;
	}
}
