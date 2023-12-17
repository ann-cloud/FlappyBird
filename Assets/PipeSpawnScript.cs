using DefaultNamespace;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;

    public float spawnRate = 3;

    private float _timer;

    private PipeAbstractFactory _factory;

    public float heightOffset = 10;
    private Prototype _existing;

    // Start is called before the first frame update
    private void Start()
    {
        CrossScene.spawner = 1;
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Vector3 spawnPosition = new Vector3(30, Random.Range(lowestPoint, highestPoint));
        if (CrossScene.GameMode == "Easy" || CrossScene.GameMode == "Moderate")
        {
            _factory = new EasyPipeFactory();
        }
        else if (CrossScene.GameMode == "Hard")
        {
            _factory = new HardPipeFactory();
        }
        _existing = new PipePrototype(_factory.CreatePipe());
        Instantiate(_factory.CreatePipe(), spawnPosition, Quaternion.identity);
        //SpawnPipe();
    }

    // Update is called once per frame
    private void Update()
    {
        if (_timer < spawnRate)
        {
            _timer += Time.deltaTime;
        }
        else
        {
            if (BirdScript.Singleton.birdIsAlive)
            {
                if (CrossScene.GameMode == "Easy")
                {
                    if (CrossScene.spawner % 4 == 0)
                    {
                        var context = new Context(new EasyPipeStateA());
                        _existing = new PipePrototype(context.Request());
                    }
                    else
                    {
                        _existing = new PipePrototype(_factory.CreatePipe());
                    }
                }

                SpawnPipe();
                _timer = 0;
            }
        }
    }

    private void SpawnPipe()
    {
        CrossScene.spawner++;
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Vector3 spawnPosition = new Vector3(30, Random.Range(lowestPoint, highestPoint));
        GameObject copy = _existing.Clone(spawnPosition);
        Instantiate(copy, spawnPosition, Quaternion.identity);
    }
}
