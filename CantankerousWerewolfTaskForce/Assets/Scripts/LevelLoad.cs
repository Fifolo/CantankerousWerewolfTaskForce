
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{
   
    public void randomLevelLoad()
    {
        int index = Random.Range(1, 4);
        SceneManager.LoadScene(index);
    }
    public void mainMenuLoad()
    {
        SceneManager.LoadScene(0);
    }
    public void settingsLoad()
    {

    }
}
