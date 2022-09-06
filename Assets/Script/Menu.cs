using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    /*public Button StartButton;
    public Button propertiesButton;
    public Button helpButton;
    public Button closeButton;*/

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayButtonClicked(string Level1)
    {
        SceneManager.LoadScene("Level1");
    }

    public void QuitButtonClicked(string Quit)
    {
        SceneManager.LoadScene("Quit");
    }

    public void HelpButtonClicked(string Help)
    {
        SceneManager.LoadScene("Help");
    }

}
