using UnityEngine;

public class Chicken : Animal
{
    protected override void Start()
    {
        base.Start();
        Debug.Log("Chicken spawned");
    }

    void Update()
    {
        Move();
    }
}
