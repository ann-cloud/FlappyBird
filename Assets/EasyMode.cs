using DefaultNamespace;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EasyMode : MonoBehaviour, IEasyMode
{
    public void load()
    {
        CrossScene.GameMode = "Easy";
        CrossScene.counter = 0;
        SceneManager.LoadScene("SampleScene");
    }
}
