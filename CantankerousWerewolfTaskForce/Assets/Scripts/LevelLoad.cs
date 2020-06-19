
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{
    private static int LVLS_AMOUNT = 5;
    private static ArrayList loadedLVLs = new ArrayList();

    public void randomLevelLoad()
    {
        int index = Random.Range(2, LVLS_AMOUNT);
        if (!loadedLVLs.Contains(index))
        {
            loadedLVLs.Add(index);
            SceneManager.LoadScene(index);
        }
        //sprawdz czy sa jakies lvl, ktore nie byly zaliczone
        else if (loadedLVLs.Count < LVLS_AMOUNT-2) randomLevelLoad();
        //laduj randomowo
        else
        {
            loadedLVLs.Clear();
            randomLevelLoad();
        }
    }
    public void mainMenuLoad()
    {
        SceneManager.LoadScene(0);
    }
    public void settingsLoad()
    {
        SceneManager.LoadScene(1);
    }
}
