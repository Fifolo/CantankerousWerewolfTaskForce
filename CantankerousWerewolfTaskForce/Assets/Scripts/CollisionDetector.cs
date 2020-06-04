
using TMPro;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{

    public GameObject gameOverPanel;
    public TextMeshProUGUI currentScore;
    public TextMeshProUGUI finalScore;
    public TextMeshProUGUI scoreMultiplier;
    public GameObject pointsEarnedPanel;
    public TextMeshProUGUI pointsEarned;

    public TextMeshProUGUI levelsCompleted;

    private static float score = 0;
    private static int lvlsCompleted = 0;


    private void Start()
    {
        currentScore.text = score.ToString();
        gameOverPanel.gameObject.SetActive(false);
        pointsEarnedPanel.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Finish"))
        {
            float multiplier = float.Parse(scoreMultiplier.GetComponent<TMPro.TextMeshProUGUI>().text);

            score +=(10 * multiplier);
            pointsEarned.text = (10 * multiplier).ToString();
            currentScore.text = score.ToString();
            lvlsCompleted++;

            pointsEarnedPanel.gameObject.SetActive(true);
            //currentScore.gameObject.SetActive(false);
        }

        if (collision.gameObject.tag.Equals("Obstacle"))
        {
            finalScore.text = "Final Score:\n" + score.ToString();
            levelsCompleted.text = "Levels Comleted:\n" + lvlsCompleted.ToString();
            gameOverPanel.gameObject.SetActive(true);
        }
    }

}
