using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sampling_Controller : MonoBehaviour
{
    public Animator samplerAnim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Planting()
    {
        samplerAnim.SetBool("Tree Growing", true);
            
    }
}
