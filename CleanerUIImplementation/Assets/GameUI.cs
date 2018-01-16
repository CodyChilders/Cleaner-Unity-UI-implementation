using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    public Canvas endOfEraTally;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EndEra()
    {
        EventQueue.RaiseEvent(EndEraSteps);
    }

    void EndEraSteps()
    {
        this.gameObject.SetActive(false);
        endOfEraTally.gameObject.SetActive(true);
        //TODO: transmit game data tracked for kills, power uses, etc to the end of era screen
    }
}
