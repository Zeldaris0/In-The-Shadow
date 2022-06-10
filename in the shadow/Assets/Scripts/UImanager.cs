using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    GameObject menu;
    GameObject levels;

    int testmod;

    static int play = 1;

    public Button[] levelbuttons;

    void Start()
    {
        testmod = PlayerPrefs.GetInt("testmod", 0);
        levels = GameObject.FindGameObjectWithTag("levels");
        menu = GameObject.FindGameObjectWithTag("main");
        if (play == 0)
        {
            menu.GetComponent<Canvas> ().enabled = false;
            levels.GetComponent<Canvas> ().enabled = true;

        }
        if (testmod == 1 && gameObject.tag == "levels")
        {
            for (int i = 0; i < 5; i++)
            {
                levelbuttons[i].interactable = true;
            }
        }
        else if (gameObject.tag == "levels")
        {
            int currentlevel = PlayerPrefs.GetInt("currentlvl",1);
            for (int i = 0; i < currentlevel; i++)
            {
                levelbuttons[i].interactable = true;
            }
        }
    }

    public void play_button()
    {
        GetComponent<Canvas> ().enabled = false;
        levels.GetComponent<Canvas> ().enabled = true;

    }

    public void exit()
    {
        Application.Quit();
    }

    public void test_mod()
    {
        play = 0;
        PlayerPrefs.SetInt("testmod", 1);
       SceneManager.LoadScene(0);
    }

    public void return_tomain()
    {
        GetComponent<Canvas> ().enabled = false;
        menu = GameObject.FindGameObjectWithTag("main");
        menu.GetComponent<Canvas> ().enabled = true;
        if(testmod == 1)
        {
            PlayerPrefs.SetInt("testmod", 0);
            play = 1;
            SceneManager.LoadScene(0);
        }
    }

    public void eleph1_button()
    {
        SceneManager.LoadScene(1);
        play = 0;
        if(testmod == 1)
        {
            PlayerPrefs.SetInt("testmod", 0);
        }
    }

    public void eleph2_button()
    {
        SceneManager.LoadScene(2);
        play = 0;
        if(testmod == 1)
        {
            PlayerPrefs.SetInt("testmod", 0);
        }
    }

     public void tea()
    {
        SceneManager.LoadScene(3);
        play = 0;
        if(testmod == 1)
        {
            PlayerPrefs.SetInt("testmod", 0);
        }
    }

     public void globe()
    {
        SceneManager.LoadScene(4);
        play = 0;
        if(testmod == 1)
        {
            PlayerPrefs.SetInt("testmod", 0);
        }
    }

     public void f42()
    {
        SceneManager.LoadScene(5);
        play = 0;
        if(testmod == 1)
        {
            PlayerPrefs.SetInt("testmod", 0);
        }
    }
}