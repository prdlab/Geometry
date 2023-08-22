using UnityEngine;

public class Toggle_Invis : MonoBehaviour
{
    private Renderer rend;
    private bool isVisible = true;

    void Start()
    {
        rend = GetComponent<Renderer>();
        InvokeRepeating("ToggleVisibilityMethod", 0f, 4f); // Repeats every 4 seconds
    }

    void ToggleVisibilityMethod()
    {
        if (isVisible)
        {
            rend.enabled = false;
            isVisible = false;
            Invoke("MakeVisible", 2f); // Makes the object visible after 2 seconds
        }
    }

    void MakeVisible()
    {
        rend.enabled = true;
        isVisible = true;
    }
}

