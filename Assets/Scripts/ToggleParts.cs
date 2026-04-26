using UnityEngine;

public class ToggleParts : MonoBehaviour
{
    public GameObject turbineObj;
    private bool isActive = true;
    void Start()
    {
        
    }

    public void Toggle()
    {
        if(isActive)
        {
            turbineObj.SetActive(false);
            isActive = false;
        }
        else
        {
            turbineObj.SetActive(true);
            isActive = true;
        }
    }
}
