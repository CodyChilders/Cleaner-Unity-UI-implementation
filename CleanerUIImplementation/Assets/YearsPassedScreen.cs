using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class YearsPassedScreen : MonoBehaviour
{
    public Text yearsLater;
    public float rebuildTime = 3f;

    public void InitScreen()
    {
        int randomYears = Random.Range(200, 600);
        yearsLater.text = string.Format("{0} years later...", randomYears);
        Invoke("BackToMainMenu", rebuildTime);
    }

    void BackToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
