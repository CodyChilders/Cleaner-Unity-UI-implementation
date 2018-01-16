using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public Text displayText;
    public Button clickToContinue;
    public GameObject eraIntro;

    int currentTutorialState;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ClickToContinue()
    {
        switch(currentTutorialState)
        {
            case 0:
                RunStage1();
                break;
            case 1:
                RunStage2();
                break;
            case 2:
                //These two can be condensed into a single function that does both.
                //Doing it this way just shows off the flexibility of the EventQueue
                EventQueue.RaiseEvent(() => { this.gameObject.SetActive(false); });
                EventQueue.RaiseEvent(() => { eraIntro.gameObject.SetActive(true); });
                break;
            default:
                //error
                break;
        }
    }

    public void RunTutorial()
    {
        this.gameObject.SetActive(true);
        RunStage0();
    }
    
    void RunStage0()
    {
        currentTutorialState = 0;
        displayText.text = "This is the first line to appear.";
    }

    void RunStage1()
    {
        currentTutorialState = 1;
        displayText.text = "This is the second line to appear.";
    }

    void RunStage2()
    {
        currentTutorialState = 2;
        displayText.text = "This is the last line to appear.";
    }
}
