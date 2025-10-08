using UnityEngine;

public class Horse : Animal
{
    protected override void Start()
    {
        base.Start();
        Debug.Log("Horse spawned");
    }

    void Update()
    {
        Move();
    }
}
