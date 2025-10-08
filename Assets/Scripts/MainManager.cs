using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainManager : MonoBehaviour
{
    public static MainManager instance;
    public float animalSpeed { get; private set; }
    public float animalSize { get; private set; }
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void SetSpeed(string x)
    {
        if (float.TryParse(x, out float value))
        {
            if (value < 0)
            {
                Debug.LogError("Speed cannot be negative!");
                return;
            }
            animalSpeed = value;
        }
        else
        {
            Debug.LogError("Invalid speed input! Please enter a number.");
        }
        Debug.Log(animalSpeed);
    }

    public void SetSize(string x)
    {
        if (float.TryParse(x, out float value))
        {
            if (value < 0)
            {
                Debug.LogError("Size cannot be negative!");
                return;
            }
            animalSize = value;
        }
        else
        {
            Debug.LogError("Invalid size input! Please enter a number.");
        }
        Debug.Log(animalSize);
    }

    public void ToMain()
    {
        SceneManager.LoadScene(1);
    }


}
