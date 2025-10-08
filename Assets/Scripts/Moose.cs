using UnityEngine;

public class Moose : Animal
{
    protected override void Start()
    {
        base.Start();
        Debug.Log("Moose spawned");
    }

    void Update()
    {
        Move();
    }
}
