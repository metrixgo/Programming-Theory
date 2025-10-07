using UnityEditor.IMGUI.Controls;
using UnityEngine;

public class SpawnLogic : MonoBehaviour
{
    public GameObject[] animals;
    public float xBound = 18.0f;
    private float delay = 0.5f;
    public float spawnSpeed = 0.2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal",delay,spawnSpeed);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int idx = Random.Range(0, animals.Length);
        float x = Random.Range(-xBound, xBound);
        Instantiate(animals[idx], new Vector3(x, 0, 25), animals[idx].transform.rotation);
    }

}
