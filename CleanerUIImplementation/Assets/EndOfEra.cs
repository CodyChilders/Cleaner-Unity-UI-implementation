using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfEra : MonoBehaviour
{
    public Canvas rebuild;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RebuildLevel()
    {
        this.gameObject.SetActive(false);
        rebuild.gameObject.SetActive(true);
        rebuild.GetComponent<YearsPassedScreen>().InitScreen();
    }
}
