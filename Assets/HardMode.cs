using DefaultNamespace;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HardMode : MonoBehaviour
{
    public void load()
    {
        CrossScene.GameMode = "Hard";
        CrossScene.counter = 0;
        SceneManager.LoadScene("SampleScene");
    }
}
