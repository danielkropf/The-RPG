using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ActivateSkills : MonoBehaviour {

    private GameObject twGO;
    private theWay tw;

	public GameObject manaBar;

	public int turn = 0;
    public int cd = 0;

	private Slider sld;
	private bool haveMana;

    void Start()
    {
        twGO = GameObject.Find("Main Camera");
        tw = twGO.GetComponent<theWay>();
		sld = manaBar.GetComponent<Slider>();
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
			switch(skill) {
				case 0:
					if (tw.lus.fireballMana <= sld.value) {
						haveMana = true;
						cd = tw.lus.fireballCd;
					}

					break;
				case 1:
					if (tw.lus.explosionMana <= sld.value) {
						haveMana = true;
						cd = tw.lus.explosionCd;
					}

					break;
				case 2:
					if (tw.lus.healMana <= sld.value) {
						haveMana = true;
						cd = tw.lus.healCd;
					}

					break;
				case 3:
					if (tw.lus.drainMana <= sld.value) {
						haveMana = true;
						cd = tw.lus.drainCd;
					}

					break;
				case 4:
					if (tw.lus.revengeMana <= sld.value) {
						haveMana = true;
						cd = tw.lus.revengeCd;
					}

					break;
				case 5:
					if (tw.lus.doubleHitMana <= sld.value) {
						haveMana = true;
						cd = tw.lus.doubleHitCd;
					}

					break;
			}
        }
		if (haveMana)
		{
			tw.btl.skillUsed = skill;
			tw.btl.usedSkill = true;
			haveMana = false;
		}
    }
}
