using UnityEngine;

public class Animal : MonoBehaviour
{
    protected float speed;
    protected float size;

    protected virtual void Start()
    {
        speed = MainManager.instance.animalSpeed*2.0f;
        size = MainManager.instance.animalSize/10.0f;
        transform.localScale *= size;
    }

    protected void Move()
    {
        transform.Translate(Vector3.forward*speed*Time.deltaTime);
        if (transform.position.x > 15) Destroy(gameObject);
    }
}
