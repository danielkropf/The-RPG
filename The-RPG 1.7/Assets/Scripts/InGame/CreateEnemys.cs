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

    public int enemySTR;
    public int enemyDEX;
    public int enemyINT;
    public int enemyCON;

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
                    sld.maxValue = 30;
                    sld.value = sld.maxValue;
                    Instantiate(normalEnemysPrf, new Vector3(enemyX, enemyY, enemyZ), Quaternion.identity);
                    enemySTR = 3;
                    enemyDEX = 1;
                    enemyCON = 3;
                    enemyINT = 0;
                    xpToEarn = 5 + (tw.tst.lvlPlayer * tw.sn.lvlAtual);
                    normalEnemys--;
                    enemySummoned = true;
                } else if (normalEnemys <= 0 && miniBoss > 0) {
                    sld = enemyLife.GetComponent<Slider>();
                    sld.maxValue = 60;
                    sld.value = sld.maxValue;
                    Instantiate(miniBossPrf, new Vector3(enemyX, enemyY, enemyZ), Quaternion.identity);
                    enemySTR = 6;
                    enemyDEX = 2;
                    enemyCON = 6;
                    enemyINT = 0;
                    xpToEarn = 15 + (tw.tst.lvlPlayer * tw.sn.lvlAtual);
                    miniBoss--;
                    enemySummoned = true;
                } else if (normalEnemys <= 0 && miniBoss <= 0 && boss > 0) {
                    sld = enemyLife.GetComponent<Slider>();
                    sld.maxValue = 120;
                    sld.value = sld.maxValue;
                    Instantiate(bossPrf, new Vector3(enemyX, enemyY, enemyZ), Quaternion.identity);
                    enemySTR = 12;
                    enemyDEX = 4;
                    enemyCON = 12;
                    enemyINT = 0;
                    xpToEarn = 45 + (tw.tst.lvlPlayer * tw.sn.lvlAtual);
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
    }
}
