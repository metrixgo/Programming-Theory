using UnityEngine;

public class Cow : Animal
{
    protected override void Start()
    {
        base.Start();
        Debug.Log("Cow spawned");
    }

    void Update()
    {
        Move();
    }
}
