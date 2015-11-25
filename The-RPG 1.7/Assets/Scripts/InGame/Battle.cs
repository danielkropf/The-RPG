using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Battle : MonoBehaviour {

    public GameObject twGO;
    private theWay tw;

    public GameObject playerLife;
        public GameObject playerLifeTxt;
    public GameObject enemyLife;
    public GameObject damageTakenPlayer;
    public GameObject damageTakenEnemy;
    public GameObject xpBar;

    private GameObject enemy;

    private int dice;
    private int diceDef;

    private int whoMoves;
    public int dmg;

    public bool usedSkill;
    public int skillUsed = -1;

    private Slider sld;
    private Text txt;

    public GameObject selfases;
    public GameObject inGame;
    public GameObject atributos;
    public GameObject inface;
    public GameObject jojo;

    void Start() {
        InvokeRepeating("PlayerAttack", 2.5f, 5);
        InvokeRepeating("EnemyAttack", 5, 5);
    }

    void PlayerAttack() {

        if(tw.ce.enemySummoned) {
            if (usedSkill) { 
                switch (skillUsed) {
                    case 0:

                        skillUsed = -1;
                        usedSkill = false;
                        break;
                    case 1:

                        skillUsed = -1;
                        usedSkill = false;
                        break;
                    case 2:

                        skillUsed = -1;
                        usedSkill = false;
                        break;
                    case 3:

                        skillUsed = -1;
                        usedSkill = false;
                        break;
                    case 4:

                        skillUsed = -1;
                        usedSkill = false;
                        break;
                    case 5:

                        skillUsed = -1;
                        usedSkill = false;
                        break;
                }
            }
            if (!usedSkill)
            {
                if (whoMoves == 0)
                {
                    txt = damageTakenEnemy.GetComponent<Text>();
                    dice = Random.Range(1, 21);
                    diceDef = Random.Range(1, 5);
                    if (dice > (tw.ce.enemyDEX + diceDef))
                    {
                        dice = Random.Range(1, 5);
                        dmg = dice + tw.tst.strTotal - (tw.ce.enemyCON / 2);
                        sld = enemyLife.GetComponent<Slider>();
                        sld.value -= dmg;
                        txt.text = dmg.ToString();
                        dmg = 0;
                        whoMoves = 1;
                    }
                    else
                    {
                        txt.text = "MISS";
                        whoMoves = 1;
                    }

                    damageTakenEnemy.SetActive(true);
                    damageTakenPlayer.SetActive(false);
                }
            }
        }
    }

    void EnemyAttack() {

        if (tw.ce.enemySummoned) {
            if (whoMoves == 1) {
                txt = damageTakenPlayer.GetComponent<Text>();
                dice = Random.Range(1, 21);
                diceDef = Random.Range(1, 5);
                if (dice > (tw.tst.dexTotal + diceDef)) {
                    dice = Random.Range(1, 5);
                    dmg = dice + tw.ce.enemySTR - (tw.tst.conTotal / 2);
                    sld = playerLife.GetComponent<Slider>();
                    sld.value -= dmg;
                    txt.text = dmg.ToString();
                    dmg = 0;
                    whoMoves = 0;
                } else {
                    txt.text = "MISS";
                    whoMoves = 0;
                }

                damageTakenEnemy.SetActive(false);
                damageTakenPlayer.SetActive(true);
            }
        }
    }

	void Update () {
        sld = playerLife.GetComponent<Slider>();
        if(sld.value <= 0) {
            sld.value = sld.maxValue;
            tw.ce.started = false;
            tw.ce.enemySummoned = false;
            enemy = GameObject.Find("NormalEnemy(Clone)");
            Destroy(enemy);
            enemy = GameObject.Find("MiniBoss(Clone)");
            Destroy(enemy);
            enemy = GameObject.Find("Boss(Clone)");
            Destroy(enemy);
            selfases.SetActive(true);
            atributos.SetActive(false);
            inGame.SetActive(false);
            inface.SetActive(true);
            jojo.SetActive(false);
        }

        sld = enemyLife.GetComponent<Slider>();
        if(sld.value <= 0) {
            enemy = GameObject.Find("NormalEnemy(Clone)");
            Destroy(enemy);
            enemy = GameObject.Find("MiniBoss(Clone)");
            Destroy(enemy);
            enemy = GameObject.Find("Boss(Clone)");
            Destroy(enemy);
            tw.ce.enemySummoned = false;
            sld = xpBar.GetComponent<Slider>();
            sld.value += tw.ce.xpToEarn;
            if (tw.ce.normalEnemys <= 0 && tw.ce.miniBoss <= 0 && tw.ce.boss <= 0) {
                selfases.SetActive(true);
                atributos.SetActive(false);
                inGame.SetActive(false);
                inface.SetActive(true);
                jojo.SetActive(false);
                tw.ce.started = false;
                sld = playerLife.GetComponent<Slider>();
                sld.value = sld.maxValue;
                tw.sn.lvlMax++;
            }
        }

        txt = playerLifeTxt.GetComponent<Text>();
        sld = playerLife.GetComponent<Slider>();
        txt.text = sld.value + "/" + sld.maxValue;
        tw = twGO.GetComponent<theWay>();
	}
}
