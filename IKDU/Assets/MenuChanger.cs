using System;
using UnityEngine;

public class MenuChanger : MonoBehaviour
{
    public GameObject VideoPanel;
    public GameObject MathPanel;
    public GameObject KebabPanel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeThat(string nameOfPanel)
    {
        VideoPanel.SetActive(nameOfPanel == "Video");
        MathPanel.SetActive(nameOfPanel == "Math");
        KebabPanel.SetActive(nameOfPanel == "Kebab");  
    }
}
