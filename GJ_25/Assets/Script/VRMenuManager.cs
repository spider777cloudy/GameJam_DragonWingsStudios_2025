using UnityEngine;
using UnityEngine.SceneManagement;

public class VRMenuManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GameJamTest");
    }

    public void ExitGame()
    {
        Debug.Log("Exit button pressed");
        Application.Quit();
    }
}
