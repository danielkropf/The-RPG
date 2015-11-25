using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UseSkills : MonoBehaviour {

    private GameObject twGO;
    private theWay tw;

    private GameObject slotGO;
    private GameObject skillGO;
    private GameObject slotSkill1;
    private GameObject slotSkill2;
    private GameObject slotSkill3;

    private Vector3 slotSkill1Position;
    private Vector3 slotSkill1Scale;

    private Vector3 slotSkill2Position;
    private Vector3 slotSkill2Scale;

    private Vector3 slotSkill3Position;
    private Vector3 slotSkill3Scale;

    private int slot;
    private int skill;

    private Slider sld;

    void Start() {
        twGO = GameObject.Find("Main Camera");
        tw = twGO.GetComponent<theWay>();
    }

    public void pointerClickSlot(int slotv) {
        slot = slotv;
    }
    public void pointerClickSlotGO(GameObject go) {
        slotGO = go;
    }

    public void pointerClickSkill(int skillv) {
        skill = skillv;
    }
    public void pointerClickSkillGO(GameObject go) {
        skillGO = go;
    }

    void Update() { 
    
        if(slot > 0 && skill > 0) {

            switch (slot)
            {
                case 1:

                    if (slotSkill1 != null)
                        {

                        slotSkill1.transform.position = slotSkill1Position;
                        slotSkill1.transform.localScale = slotSkill1Scale;
                    }
                    slotSkill1 = skillGO;
                    slotSkill1Position = slotSkill1.transform.position;
                    slotSkill1Scale = slotSkill1.transform.localScale;
                    break;
                case 2:

                    if (slotSkill2 != null)
                    {

                        slotSkill2.transform.position = slotSkill2Position;
                        slotSkill2.transform.localScale = slotSkill2Scale;
                    }
                    slotSkill2 = skillGO;
                    slotSkill2Position = slotSkill2.transform.position;
                    slotSkill2Scale = slotSkill2.transform.localScale;
                    break;
                case 3:

                    if (slotSkill3 != null)
                    {

                        slotSkill3.transform.position = slotSkill3Position;
                        slotSkill3.transform.localScale = slotSkill3Scale;
                    }
                    slotSkill3 = skillGO;
                    slotSkill3Position = slotSkill3.transform.position;
                    slotSkill3Scale = slotSkill3.transform.localScale;
                    break;

            }

            skillGO.transform.position = slotGO.transform.position;
            skillGO.transform.localScale = slotGO.transform.localScale;

            slot = 0;
            skill = 0;
        }
    }
}
