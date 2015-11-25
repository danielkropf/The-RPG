using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UseSkills : MonoBehaviour {

    private GameObject twGO;
    private theWay tw;

    private bool dragging;
    public int skill = -1;
    public int cd = 0;
    private GameObject newSkill;

    private Slider sld;

    void Start() {
        twGO = GameObject.Find("Main Camera");
        tw = twGO.GetComponent<theWay>();
        sld = this.GetComponent<Slider>();
    }

    public void pressSkill() {
        if (cd <= 0) tw.btl.skillUsed = skill;
    }

    void OnMouseDown() {
        dragging = true;
        newSkill = Instantiate(this.gameObject, this.transform.position, Quaternion.identity) as GameObject;
    }
    void OnMouseUp() {
        dragging = false;
    }

    void Update() { 
        if(dragging) {
            newSkill.transform.position = Input.mousePosition;
        }
    }
}
