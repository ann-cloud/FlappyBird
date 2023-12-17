using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class BirdScript : MonoBehaviour, ISubject
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public static BirdScript Singleton { get; private set; }
    public List<IObserver> _observers = new List<IObserver>();
    
    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.UpdatePipes(this);
        }
    }
    private void Awake()
    {
        if (Singleton != null && Singleton != this) 
        { 
            Destroy(this); 
        } 
        else 
        { 
            Singleton = this; 
        }
    }
    
    // Start is called before the first frame update
    private void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        if (CrossScene.GameMode == "Hard")
        {
            flapStrength = 30;
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }

        // if (transform.position.y > 17 || transform.position.y < -17)
        // {
        //     logic.gameOver();
        //     birdIsAlive = false;
        // }
        var logicProxy = new Proxy(logic);
        var client = new Client(logicProxy);
        client.gameOver();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        logic.gameOver();
        birdIsAlive = false;
        Notify();
    }
}
