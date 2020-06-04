
using UnityEngine;

public class PathPanelController : MonoBehaviour
{
    public GameObject panel;

    private void Start()
    {
        panel.gameObject.SetActive(false);
    }

    public void openPanel()
    {
        panel.gameObject.SetActive(true);
    }
    public void closePanel()
    {
        panel.gameObject.SetActive(false);
    }
}
