using DefaultNamespace;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;
    
    // Start is called before the first frame update
    private void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        CrossScene.counter++;
        if (col.gameObject.layer == 3 && BirdScript.Singleton.birdIsAlive)
        {
            Facade facade = new Facade(logic);
            facade.Operation();
        }
    }
}
