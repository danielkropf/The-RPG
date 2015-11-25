using UnityEngine;
using System.Collections;

public class ExplosionEnded : MonoBehaviour {

    Animator animator;
	// Use this for initialization
	void Start () {
	    animator = GetComponent<Animator>();
	}

    void Awake()
    {

    }

	// Update is called once per frame
	void Update () {
        AnimatorStateInfo animState = animator.GetCurrentAnimatorStateInfo(0);
        if (animState.IsName("Base.Explosion"))
        {
            Debug.Log("Está explodindo");
        }
        else
        {
            animator.SetTrigger("toExplode");
        }
        


        //Debug.Log(animState.IsName("Base.Explosion"));
	}
}
