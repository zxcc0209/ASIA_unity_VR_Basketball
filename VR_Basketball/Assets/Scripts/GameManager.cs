using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("籃球機");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
