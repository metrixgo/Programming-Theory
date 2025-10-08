using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public List<GameObject> animals;

    public void Spawn()
    {
        GameObject randAnimal = animals[Random.Range(0,animals.Count)];
        GameObject animal = Instantiate(randAnimal, transform.position, transform.rotation);
    }

}
