using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cactusattack : MonoBehaviour
{
    private Animator mAnimator;
    public GameObject cactusAstro;
    public GameObject cactusDrone;

    void Start()
    {
        mAnimator = GetComponent<Animator>();
        mAnimator.SetTrigger("TrgLeave");

    }

    
    void Update()
    {
        if(mAnimator != null)
        {
            if(Vector3.Distance(cactusAstro.transform.position, cactusDrone.transform.position) < 0.1)
            {
                mAnimator.SetTrigger("TrgGetClose");
            }
            else
            {
                mAnimator.SetTrigger("TrgLeave");
            }
        }
    }
}
