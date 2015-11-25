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
	public GameObject healTaken;
	public GameObject secondDamage;
    public GameObject xpBar;

    public GameObject anmExplosion;
    private Animator animatorExplosion;
    private AnimatorStateInfo animStateExplosion;

	public GameObject anmFireball;
	private Animator animatorFireball;
	private AnimatorStateInfo animStateFireball;

	public GameObject anmHeal;
	private Animator animatorHeal;
	private AnimatorStateInfo animStateHeal;

	public GameObject anmDrain;
	private Animator animatorDrain;
	private AnimatorStateInfo animStateDrain;

    private GameObject enemy;

    private int dice;
    private int diceDef;

    private int whoMoves;
    public int dmg;
	private int lastDamage;
	public int turn;

    public bool usedSkill;
    public int skillUsed = -1;

    private Slider sld;
    private Text txt;

    public GameObject selfases;
    public GameObject inGame;
    public GameObject atributos;
    public GameObject inface;
    public GameObject jojo;
    public GameObject slotSkill;
    public GameObject panel;

    void Start() {
        animatorExplosion = anmExplosion.GetComponent<Animator>();
		animatorFireball = anmFireball.GetComponent<Animator>();
		animatorHeal = anmHeal.GetComponent<Animator>();
		animatorDrain = anmDrain.GetComponent<Animator>();
        InvokeRepeating("PlayerAttack", 2.5f, 5);
        InvokeRepeating("EnemyAttack", 5, 5);
    }

    void PlayerAttack() {

		animStateExplosion = animatorExplosion.GetCurrentAnimatorStateInfo(0);

        if(tw.ce.enemySummoned) {
            if (usedSkill) { 
                switch (skillUsed) {
                    case 0:
						Debug.Log("explosion");
                        txt = damageTakenEnemy.GetComponent<Text>();
                        dice = Random.Range(1, 9);
						animatorExplosion.SetTrigger("toExplode");
                        if (dice + tw.tst.lukTotal > tw.ce.enemyDEX) {
                            dice = Random.Range(1, 5);
							dmg = dice + tw.tst.intelTotal - ((tw.ce.enemyCON / 4) * 3);
                            sld = enemyLife.GetComponent<Slider>();
                            sld.value -= dmg;
                            txt.text = dmg.ToString();
                            dmg = 0;
                        } else {
                            txt.text = "MISS";
                        }
						secondDamage.SetActive(false);
                        damageTakenEnemy.SetActive(true);
                        damageTakenPlayer.SetActive(false);
						healTaken.SetActive(false);
                        whoMoves = 1;
                        usedSkill = false;
                        skillUsed = -1;

                        break;
                    case 1:
						Debug.Log("fireball");
						txt = damageTakenEnemy.GetComponent<Text>();
                        dice = Random.Range(1, 9);
						animatorFireball.SetTrigger("toShot");
                        if (dice + tw.tst.lukTotal > tw.ce.enemyDEX) {
                            dice = Random.Range(1, 5);
							dmg = dice + tw.tst.intelTotal - ((tw.ce.enemyCON / 4) * 3);
                            sld = enemyLife.GetComponent<Slider>();
                            sld.value -= dmg;
                            txt.text = dmg.ToString();
                            dmg = 0;
                        } else {
                            txt.text = "MISS";
                        }
						secondDamage.SetActive(false);
                        damageTakenEnemy.SetActive(true);
                        damageTakenPlayer.SetActive(false);
						healTaken.SetActive(false);
                        whoMoves = 1;
                        usedSkill = false;
                        skillUsed = -1;

                        break;
                    case 2:
						Debug.Log("heal");
                        txt = healTaken.GetComponent<Text>();
						dice = Random.Range(1, 5);
						animatorHeal.SetTrigger("toHeal");
						dmg = dice += tw.tst.intelTotal / 2;
						sld = playerLife.GetComponent<Slider>();
						sld.value += dmg;
						txt.text = dmg.ToString();
						dmg = 0;

						secondDamage.SetActive(false);
						damageTakenEnemy.SetActive(false);
						damageTakenPlayer.SetActive(false);
						healTaken.SetActive(true);
						whoMoves = 1;
						usedSkill = false;
						skillUsed = -1;

                        break;
                    case 3:
						Debug.Log("drain");
                        txt = damageTakenEnemy.GetComponent<Text>();
                        dice = Random.Range(1, 9);
						animatorDrain.SetTrigger("toDrain");
                        if (dice + tw.tst.lukTotal > tw.ce.enemyDEX) {
                            dice = Random.Range(1, 5);
							dmg = dice + tw.tst.intelTotal - ((tw.ce.enemyCON / 4) * 2);
                            sld = enemyLife.GetComponent<Slider>();
                            sld.value -= dmg;
                            txt.text = dmg.ToString();

							dmg /= 3;
							txt = healTaken.GetComponent<Text>();
							sld = playerLife.GetComponent<Slider>();
							sld.value += dmg;
							txt.text = dmg.ToString();

                            dmg = 0;
                        } else {
                            txt.text = "MISS";
                        }
						secondDamage.SetActive(false);
                        damageTakenEnemy.SetActive(true);
                        damageTakenPlayer.SetActive(false);
						healTaken.SetActive(true);
                        whoMoves = 1;
                        usedSkill = false;
                        skillUsed = -1;

                        break;
                    case 4:
						Debug.Log("revenge");
                        txt = damageTakenEnemy.GetComponent<Text>();
                        dice = Random.Range(1, 9);
                        if (dice + ((tw.tst.lukTotal / 4) * 3) > tw.ce.enemyDEX + (tw.ce.enemyDEX/4)) {
							dmg = lastDamage * 3;
                            sld = enemyLife.GetComponent<Slider>();
                            sld.value -= dmg;
                            txt.text = dmg.ToString();
                            dmg = 0;
                        } else {
                            txt.text = "MISS";
                        }
						secondDamage.SetActive(false);
                        damageTakenEnemy.SetActive(true);
                        damageTakenPlayer.SetActive(false);
						healTaken.SetActive(false);
                        whoMoves = 1;
                        usedSkill = false;
                        skillUsed = -1;
						
                        break;
                    case 5:
						Debug.Log("2hits");
                        txt = damageTakenEnemy.GetComponent<Text>();
                        dice = Random.Range(1, 9);
                        if (dice + ((tw.tst.lukTotal/4) *3) > tw.ce.enemyDEX) {
                            dice = Random.Range(1, 5);
							dmg = dice + tw.tst.strTotal - ((tw.ce.enemyCON / 4) * 3);
                            sld = enemyLife.GetComponent<Slider>();
                            sld.value -= dmg;
                            txt.text = dmg.ToString();
                            dmg = 0;
                        } else {
                            txt.text = "MISS";
                        }

						txt = secondDamage.GetComponent<Text>();
                        dice = Random.Range(1, 5);
						dmg = dice + tw.tst.strTotal - ((tw.ce.enemyCON / 4) * 3);
                        sld = enemyLife.GetComponent<Slider>();
                        sld.value -= dmg;
                        txt.text = dmg.ToString();
                        dmg = 0;

						secondDamage.SetActive(true);
                        damageTakenEnemy.SetActive(true);
                        damageTakenPlayer.SetActive(false);
						healTaken.SetActive(false);
                        whoMoves = 1;
                        usedSkill = false;
                        skillUsed = -1;

                        break;
                }
            } else if (!usedSkill)
            {
                if (whoMoves == 0) {
                    txt = damageTakenEnemy.GetComponent<Text>();
                    dice = Random.Range(1, 9);
                    if (dice + tw.tst.lukTotal > tw.ce.enemyDEX) {
                        dice = Random.Range(1, 5);
                        dmg = dice + tw.tst.strTotal - ((tw.ce.enemyCON / 4) * 3);
                        sld = enemyLife.GetComponent<Slider>();
                        sld.value -= dmg;
                        txt.text = dmg.ToString();
                        dmg = 0;
                        whoMoves = 1;
                    } else {
                        txt.text = "MISS";
                        whoMoves = 1;
                    }

					secondDamage.SetActive(false);
                    damageTakenEnemy.SetActive(true);
                    damageTakenPlayer.SetActive(false);
					healTaken.SetActive(false);
                }
            }
        }
		turn++;
    }

    void EnemyAttack() {

        if (tw.ce.enemySummoned) {
            if (whoMoves == 1) {
                txt = damageTakenPlayer.GetComponent<Text>();
                dice = Random.Range(1, 9);
                if (dice + tw.ce.enemyLUK > tw.tst.dexTotal) {
                    dice = Random.Range(1, 5);
                    dmg = dice + tw.ce.enemySTR - ((tw.tst.conTotal / 4) * 3);
                    sld = playerLife.GetComponent<Slider>();
                    sld.value -= dmg;
                    txt.text = dmg.ToString();
					lastDamage = dmg;
                    dmg = 0;
                    whoMoves = 0;
                } else {
                    txt.text = "MISS";
                    whoMoves = 0;
                }

				secondDamage.SetActive(false);
                damageTakenEnemy.SetActive(false);
                damageTakenPlayer.SetActive(true);
				healTaken.SetActive(false);
            }
        }
		turn++;
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
            slotSkill.SetActive(true);
            panel.SetActive(false);
			theWay.cena = "selFase";
			Debug.Log("mudou cena");
			turn = 0;
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
                slotSkill.SetActive(true);
                panel.SetActive(false);
                tw.ce.started = false;
				Debug.Log("mudou cena");
				theWay.cena = "selFase";
                sld = playerLife.GetComponent<Slider>();
                sld.value = sld.maxValue;
                if(tw.sn.lvlAtual == tw.sn.lvlMax) tw.sn.lvlMax++;
				turn = 0;
            }
        }

        txt = playerLifeTxt.GetComponent<Text>();
        sld = playerLife.GetComponent<Slider>();
        txt.text = sld.value + "/" + sld.maxValue;
        tw = twGO.GetComponent<theWay>();
	}
}
