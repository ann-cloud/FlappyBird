using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour, ILogic
{
    public int playScore;
    public int highScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public void addScore(int toAdd)
    {
        if (BirdScript.Singleton.birdIsAlive)
        {
            playScore += toAdd;
            scoreText.text = playScore.ToString();
            
            if(PlayerPrefs.HasKey("highScore"))
            {
                if(playScore > PlayerPrefs.GetInt("highScore"))
                {
                    highScore = playScore;
                    PlayerPrefs.SetInt("highScore", highScore);
                    PlayerPrefs.Save();
                }
            }
            else
            {   
                if(playScore > highScore)
                {
                    highScore = playScore;
                    PlayerPrefs.SetInt("highScore", highScore);
                    PlayerPrefs.Save();
                }
            }
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene("TitleScene");
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void changeCharacter()
    {
        int characterNumber = Random.Range(1, 5);
        string characterBody = $"body{characterNumber}";
        string characterWing = $"wing{characterNumber}";
        Sprite bodySprite = Resources.Load<Sprite>(characterBody);
        Sprite wingSprite = Resources.Load<Sprite>(characterWing);
        BirdScript.Singleton.GetComponent<SpriteRenderer>().sprite = bodySprite;
        BirdScript.Singleton.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite = wingSprite;
    }
}
