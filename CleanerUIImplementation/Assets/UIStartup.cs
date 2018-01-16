using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIStartup : MonoBehaviour
{
    public Canvas Tutorial;
    public Canvas EraIntro;
    public Canvas InGameUI;
    public Canvas EndOfEra;
    public Canvas Rebuild;

    void Awake()
    {
        Tutorial.gameObject.SetActive(false);
        EraIntro.gameObject.SetActive(false);
        InGameUI.gameObject.SetActive(false);
        EndOfEra.gameObject.SetActive(false);
        Rebuild.gameObject.SetActive(false);

        //Using lambdas here for simplicity. However, these can be named.
        //Funny enough, this block can be inverted
        //It can be an unconditional call to EventQueue.RaiseEvent, which checks TutorialActive
        //and runs the if/else and associated conditions.
        if (TutorialState.TutorialActive)
        {
            EventQueue.RaiseEvent( () =>
            {
                Tutorial.gameObject.SetActive(true);
                Tutorial.GetComponent<Tutorial>().RunTutorial();
            });
        }
        else
        {
            EventQueue.RaiseEvent( () =>
            {
                EraIntro.gameObject.SetActive(true);
            });
        }
    }
}
