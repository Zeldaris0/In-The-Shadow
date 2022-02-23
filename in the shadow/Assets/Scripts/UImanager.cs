using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    GameObject menu;
    GameObject levels;

    bool testmod = false;

    public Button[] levelbuttons;

    void Start()
    {
        if (testmod)
        {
            for (int i = 0; i < 4; i++)
            {
                levelbuttons[i].interactable = true;
            }
        }
        else
        {
            int currentlevel = PlayerPrefs.GetInt("currentlvl",0);
            for (int i = 0; i < currentlevel; i++)
            {
                levelbuttons[i].interactable = true;
            }
        }
    }

    public void play_button()
    {
        GetComponent<Canvas> ().enabled = false;
        levels = GameObject.FindGameObjectWithTag("levels");
        levels.GetComponent<Canvas> ().enabled = true;

    }

    public void exit()
    {
        Application.Quit();
    }

    public void test_mod()
    {
        
    }

    public void return_tomain()
    {
        GetComponent<Canvas> ().enabled = false;
        menu = GameObject.FindGameObjectWithTag("main");
        menu.GetComponent<Canvas> ().enabled = true;
    }

    public void eleph1_button()
    {
        SceneManager.LoadScene(1);
        
    }

    public void eleph2_button()
    {
        SceneManager.LoadScene(2);
    }

     public void tea()
    {
        SceneManager.LoadScene(3);
    }

     public void globe()
    {
        SceneManager.LoadScene(4);
    }

     public void f42()
    {
        SceneManager.LoadScene(5);
    }
}
