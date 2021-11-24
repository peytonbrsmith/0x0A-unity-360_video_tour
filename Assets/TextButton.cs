using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextButton : MonoBehaviour
{
    public bool isActive = false;
    public GameObject image;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        if (isActive)
        {
            image.SetActive(false);
            isActive = false;
        }
        else
        {
            image.SetActive(true);
            isActive = true;
        }
    }
}
