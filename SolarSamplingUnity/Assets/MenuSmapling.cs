using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSmapling : MonoBehaviour
{
    public Animator samplerAnim;

    // Start is called before the first frame update
    void Start()
    {
        samplerAnim.SetBool("Tree Growing", true);
    }

    // Update is called once per frame
    void Update()
    {

    }


    
}

