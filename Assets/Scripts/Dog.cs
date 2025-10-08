using UnityEngine;

public class Dog : Animal
{
    protected override void Start()
    {
        base.Start();
        Debug.Log("Dog spawned");
    }

    void Update()
    {
        Move();
    }
}
