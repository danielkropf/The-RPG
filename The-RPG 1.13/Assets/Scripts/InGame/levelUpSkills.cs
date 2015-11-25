using UnityEngine;
using System.Collections;

public class levelUpSkills : MonoBehaviour {

    public GameObject twGO;
    private theWay tw;

    private int skillPoints = 5;

	public int fireballLvl = 1;
    public int fireballDmg;
    public int fireballMana;
    public int fireballCd;

	public int explosionLvl = 1;
    public int explosionDmg;
    public int explosionMana;
    public int explosionCd;

	public int healLvl = 1;
    public int healHeal;
    public int healMana;
    public int healCd;

	public int drainLvl = 1;
    public int drainDmg;
    public int drainHeal;
    public int drainMana;
    public int drainCd;

	public int revengeLvl = 1;
    public int revengeDmg;
	public int revengeHeal;
    public int revengeMana;
    public int revengeCd;

	public int doubleHitLvl = 1;
    public int doubleHitDmg1;
    public int doubleHitDmg2;
	public int doubleHitHeal1;
	public int doubleHitHeal2;
    public int doubleHitMana;
    public int doubleHitCd;

	void Start() { 
		tw = twGO.GetComponent<theWay>();
	}
    public void upSkillLvl(string skill) { 
		switch(skill) {
			case "fireball":
				if (fireballLvl < 6)fireballLvl++;
				break;
			case "explosion":
				if (explosionLvl < 6) explosionLvl++;
				break;
			case "heal":
				if (healLvl < 6) healLvl++;
				break;
			case "drain":
				if (drainLvl < 6) drainLvl++;
				break;
			case "revenge":
				if (revengeLvl < 6) revengeLvl++;
				break;
			case "doubleHit":
				if (doubleHitLvl < 6) doubleHitLvl++;
				break;
		
		}
    }

	void Update() { 
		//Fireball
		switch (fireballLvl) { 
			case 1:
				fireballDmg = 5;
				fireballMana = 10;
				fireballCd = 15;
				break;
			case 2:
				fireballDmg = 7;
				fireballMana = 13;
				fireballCd = 13;
				break;
			case 3:
				fireballDmg = 11;
				fireballMana = 15;
				fireballCd = 10;
				break;
			case 4:
				fireballDmg = 15;
				fireballMana = 20;
				fireballCd = 9;
				break;
			case 5:
				fireballDmg = 20;
				fireballMana = 22;
				fireballCd = 7;
				break;
			case 6:
				fireballDmg = 30;
				fireballMana = 25;
				fireballCd = 5;
				break;
		}

		switch (explosionLvl)
		{
			case 1:
				explosionDmg = 4;
				explosionMana = 7;
				explosionCd = 13;
				break;
			case 2:
				explosionDmg = 5;
				explosionMana = 11;
				explosionCd = 11;
				break;
			case 3:
				explosionDmg = 10;
				explosionMana = 15;
				explosionCd = 9;
				break;
			case 4:
				explosionDmg = 13;
				explosionMana = 17;
				explosionCd = 7;
				break;
			case 5:
				explosionDmg = 17;
				explosionMana = 21;
				explosionCd = 5;
				break;
			case 6:
				explosionDmg = 25;
				explosionMana = 23;
				explosionCd = 4;
				break;
		}

		switch (healLvl)
		{
			case 1:
				healHeal = 11;
				healMana = 15;
				healCd = 8;
				break;
			case 2:
				healHeal = 13;
				healMana = 16;
				healCd = 7;
				break;
			case 3:
				healHeal = 16;
				healMana = 18;
				healCd = 6;
				break;
			case 4:
				healHeal = 19;
				healMana = 25;
				healCd = 6;
				break;
			case 5:
				healHeal = 23;
				healMana = 27;
				healCd = 6;
				break;
			case 6:
				healHeal = 30;
				healMana = 32;
				healCd = 5;
				break;
		}

		switch (drainLvl)
		{
			case 1:
				drainDmg = 7;
				drainHeal = 4;
				drainMana = 9;
				drainCd = 21;
				break;
			case 2:
				drainDmg = 11;
				drainHeal = 5;
				drainMana = 11;
				drainCd = 17;
				break;
			case 3:
				drainDmg = 17;
				drainHeal = 8;
				drainMana = 14;
				drainCd = 16;
				break;
			case 4:
				drainDmg = 21;
				drainHeal = 12;
				drainMana = 18;
				drainCd = 13;
				break;
			case 5:
				drainDmg = 27;
				drainHeal = 19;
				drainMana = 25;
				drainCd = 11;
				break;
			case 6:
				drainDmg = 33;
				drainHeal = 27;
				drainMana = 30;
				drainCd = 9;
				break;
		}
		switch (revengeLvl)
		{
			case 1:
				revengeDmg = 15;
				revengeMana = 10;
				revengeCd = 40;
				revengeHeal = 40;
				break;
			case 2:
				revengeDmg = 17;
				revengeMana = 11;
				revengeCd = 37;
				revengeHeal = 45;
				break;
			case 3:
				revengeDmg = 21;
				revengeMana = 12;
				revengeCd = 31;
				revengeHeal = 50;
				break;
			case 4:
				revengeDmg = 27;
				revengeMana = 13;
				revengeCd = 25;
				revengeHeal = 55;
				break;
			case 5:
				revengeDmg = 35;
				revengeMana = 14;
				revengeCd = 23;
				revengeHeal = 60;
				break;
			case 6:
				revengeDmg = 50;
				revengeMana = 15;
				revengeCd = 20;
				revengeHeal = 65;
				break;
		}
		switch (doubleHitLvl)
		{
			case 1:
				doubleHitDmg1 = 6;
				doubleHitDmg2 = 7;
				doubleHitHeal1 = 15;
				doubleHitHeal2 = 30;
				doubleHitMana = 12;
				doubleHitCd = 15;
				break;
			case 2:
				doubleHitDmg1 = 9;
				doubleHitDmg2 = 12;
				doubleHitHeal1 = 17;
				doubleHitHeal2 = 33;
				doubleHitMana = 16;
				doubleHitCd = 13;
				break;
			case 3:
				doubleHitDmg1 = 10;
				doubleHitDmg2 = 15;
				doubleHitHeal1 = 22;
				doubleHitHeal2 = 35;
				doubleHitMana = 20;
				doubleHitCd = 11;
				break;
			case 4:
				doubleHitDmg1 = 13;
				doubleHitDmg2 = 19;
				doubleHitHeal1 = 30;
				doubleHitHeal2 = 40;
				doubleHitMana = 23;
				doubleHitCd = 10;
				break;
			case 5:
				doubleHitDmg1 = 15;
				doubleHitDmg2 = 25;
				doubleHitHeal1 = 33;
				doubleHitHeal2 = 45;
				doubleHitMana = 27;
				doubleHitCd = 9;
				break;
			case 6:
				doubleHitDmg1 = 21;
				doubleHitDmg2 = 32;
				doubleHitHeal1 = 36;
				doubleHitHeal2 = 47;
				doubleHitMana = 32;
				doubleHitCd = 7;
				break;
		}
	}
}
