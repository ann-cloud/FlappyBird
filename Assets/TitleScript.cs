using UnityEngine.UI;
using UnityEngine;

public class TitleScript : MonoBehaviour
{
    public Text highestScoreText;
    // Start is called before the first frame update
    private void Start()
    {
        highestScoreText.text = "Highest score: " + PlayerPrefs.GetInt("highScore");
    }
}
