using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator playerAnim;
    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();

        
    }

    // Update is called once per frame
    void Update()
    {
        playerAnim.SetTrigger("Walk_Static");
    }
}
