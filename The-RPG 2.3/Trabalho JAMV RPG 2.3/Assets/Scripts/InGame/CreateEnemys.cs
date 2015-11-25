using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CreateEnemys : MonoBehaviour {

    //Instantiate(brick, new Vector3(x, y, 0), Quaternion.identity);

    public GameObject go;
    private theWay tw;

    public GameObject SelFase;
    public GameObject InGame;
    public GameObject jojo;
    public GameObject slotsSkill;
    public GameObject panel;

    public GameObject enemy;
    public GameObject enemyLife;
    private float enemyX;
    private float enemyY;
    private float enemyZ;
    public int xpToEarn;

    public Transform normalEnemysPrf;
    public Transform miniBossPrf;
    public Transform bossPrf;
    private GameObject instantiatedEnemy;

    public int normalEnemys;
    public int miniBoss;
    public int boss;
    public bool started;
    public bool enemySummoned;

    private int remainingEnemyPoints;
    public int enemySTR;
    public int enemyDEX;
    public int enemyINT;
    public int enemyCON;
	public int enemyLUK;

    private Slider sld;

    void Start() {
        tw = go.GetComponent<theWay>();
        enemyX = enemy.transform.position.x;
        enemyY = enemy.transform.position.y;
        enemyZ = enemy.transform.position.z;
    }
	
	void Update () {
        if(started) {
            if(!enemySummoned) {
                if(normalEnemys > 0) {
                    sld = enemyLife.GetComponent<Slider>();
                    Instantiate(normalEnemysPrf, new Vector3(enemyX, enemyY, enemyZ), Quaternion.identity);
                    remainingEnemyPoints = 8 + (3 * tw.sn.lvlAtual);
                    enemySTR = 3;
                    enemyDEX = 1;
                    enemyCON = 3;
                    enemyINT = 0;
					enemyLUK = 4;
					for (remainingEnemyPoints = remainingEnemyPoints; remainingEnemyPoints > 0; remainingEnemyPoints--) {
						switch (Random.Range(1, 6)) {
							case 1:
								enemySTR++;
								break;
							case 2:
								enemyDEX++;
								break;
							case 3:
								enemyCON++;
								break;
							case 4:
								enemyINT++;
								break;
							case 5:
								enemyLUK++;
								break;
						}
					}
					sld.maxValue = 30 + ((5 * tw.sn.lvlAtual) + (2 * enemyCON));
					sld.value = sld.maxValue;
                    xpToEarn = 5 + ((5 * tw.sn.lvlAtual) / 2); ;
                    normalEnemys--;
                    enemySummoned = true;
                } else if (normalEnemys <= 0 && miniBoss > 0) {
                    sld = enemyLife.GetComponent<Slider>();
                    Instantiate(miniBossPrf, new Vector3(enemyX, enemyY, enemyZ), Quaternion.identity);
                    remainingEnemyPoints = 10 * tw.sn.lvlAtual;
                    enemySTR = 6;
                    enemyDEX = 2;
                    enemyCON = 6;
                    enemyINT = 0;
					enemyLUK = 8;
					for (remainingEnemyPoints = remainingEnemyPoints; remainingEnemyPoints > 0; remainingEnemyPoints--) {
						switch (Random.Range(1, 6)) {
							case 1:
								enemySTR++;
								break;
							case 2:
								enemyDEX++;
								break;
							case 3:
								enemyCON++;
								break;
							case 4:
								enemyINT++;
								break;
							case 5:
								enemyLUK++;
								break;
						}
					}
					sld.maxValue = 60 + ((7 * tw.sn.lvlAtual) + (3 * enemyCON));
					sld.value = sld.maxValue;
                    xpToEarn = 15 + ((15 * tw.sn.lvlAtual) / 2); ;
                    miniBoss--;
                    enemySummoned = true;
                } else if (normalEnemys <= 0 && miniBoss <= 0 && boss > 0) {
                    sld = enemyLife.GetComponent<Slider>();
                    Instantiate(bossPrf, new Vector3(enemyX, enemyY, enemyZ), Quaternion.identity);
                    remainingEnemyPoints = 13 * tw.sn.lvlAtual;
                    enemySTR = 12;
                    enemyDEX = 4;
                    enemyCON = 12;
                    enemyINT = 0;
					enemyLUK = 16;
					for (remainingEnemyPoints = remainingEnemyPoints; remainingEnemyPoints > 0; remainingEnemyPoints--) {
						switch (Random.Range(1, 6)) {
							case 1:
								enemySTR++;
								break;
							case 2:
								enemyDEX++;
								break;
							case 3:
								enemyCON++;
								break;
							case 4:
								enemyINT++;
								break;
							case 5:
								enemyLUK++;
								break;
						}
					}
					sld.maxValue = 120 + ((10 * tw.sn.lvlAtual) +(5 * enemyCON));
					sld.value = sld.maxValue;
                    xpToEarn = 45 + ((45 * tw.sn.lvlAtual)/2);
                    boss--;
                    enemySummoned = true;
                }
            }
        }
	}

    public void numEnemys() {
        tw = go.GetComponent<theWay>();
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
        started = true;
        SelFase.SetActive(false);
        InGame.SetActive(true);
        jojo.SetActive(true);
        slotsSkill.SetActive(false);
        panel.SetActive(true);
		theWay.cena = "jogo";
		Debug.Log("mudou cena");
    }
}
