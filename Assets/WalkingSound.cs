using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingSound : MonoBehaviour
{
    public GameObject WalkinSFX;

    void Start()
    {
        WalkinSFX.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)
            || Input.GetKey(KeyCode.W)
            || Input.GetKey(KeyCode.S)
            || Input.GetKey(KeyCode.D))
        {
            WalkinSFX.SetActive(true);
        }
        else
        {
            WalkinSFX.SetActive(false);
        }
    }
}
