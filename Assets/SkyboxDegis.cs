using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxDegis : MonoBehaviour
{
    public Material otherSkybox;
    public GameObject doomObj;
    public GameObject normalObj;

    void Start()
    {
        normalObj.SetActive(true);
        doomObj.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            RenderSettings.skybox = otherSkybox;
            doomObj.SetActive(true);
            normalObj.SetActive(false);
        }
    }
}
