using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartWithTutorial()
    {
        TutorialState.TutorialActive = true;
        SceneManager.LoadScene("Game");
    }

    public void StartWithoutTutorial()
    {
        TutorialState.TutorialActive = false;
        SceneManager.LoadScene("Game");
    }
}
