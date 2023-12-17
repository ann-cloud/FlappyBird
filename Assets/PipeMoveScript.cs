using System;
using DefaultNamespace;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour, IObserver
{
    public float moveSpeed = 5;

    public float deadZone = -45;

    private void Start()
    {
        BirdScript.Singleton.Attach(this);
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position += Vector3.left * (moveSpeed * Time.deltaTime);
        if (CrossScene.GameMode == "Moderate")
        {
            if (BirdScript.Singleton.birdIsAlive)
            {
                if (CrossScene.counter % 2 == 0)
                {
                    transform.position += transform.up * (2 * Time.deltaTime);
                }
                else
                {
                    transform.position += -transform.up * (2 * Time.deltaTime);
                }
            }
        }
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
            BirdScript.Singleton.Detach(this);
        }
    }

    public void UpdatePipes(ISubject subject)
    {
        if (!(subject as BirdScript).birdIsAlive)
        {
            Destroy(gameObject);
            //BirdScript.Singleton.Detach(this);
        }
    }
}
