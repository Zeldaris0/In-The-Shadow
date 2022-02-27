using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class shadow_validator : MonoBehaviour
{

    string  tag_b;
    string tag_o;
    float angle1;
    float angle2;
    float angle3;
    float angle4;
    Vector3 targetdir1 = Vector3.forward;
    Vector3 targetdir2 = Vector3.up;
    GameObject top;
    int currentlevel;
    void Start ()
    {
        top = GameObject.FindGameObjectWithTag("top");
        tag_o = gameObject.tag;
        currentlevel = PlayerPrefs.GetInt("currentlvl",1);
    }
    // Start is called before the first frame update
    void FixedUpdate()
    {
        angle1 = Vector3.Angle(transform.forward, targetdir1);
        angle2 = Vector3.Angle(transform.up, targetdir2);
        if (top)
        {
            angle3 = Vector3.Angle(top.transform.forward, targetdir1);
            angle4 = Vector3.Angle(top.transform.up, targetdir2);
        }

        if (tag_o == "eleph1")
        {  
            if (IsBetween(angle1,80f,100f) && IsBetween(angle2,90f,110f))
            {
                if(currentlevel < 2)
                {
                    PlayerPrefs.SetInt("currentlvl",2);
                }
               SceneManager.LoadScene(0);
            }
        }
        if (tag_o == "eleph2")
        {
            if (IsBetween(angle1,80f,100f) && IsBetween(angle2,90f,110f))
            {
               if(currentlevel < 3)
                {
                    PlayerPrefs.SetInt("currentlvl",3);
                }
               SceneManager.LoadScene(0);
            }
        }
        if (tag_o == "tea")
        {
            if (IsBetween(angle1,55f,75f) && IsBetween(angle2,60f,80f))
            {
               if(currentlevel < 4)
                {
                    PlayerPrefs.SetInt("currentlvl",4);
                }
               SceneManager.LoadScene(0);
            }
        }
        if (tag_o == "globe")
        {
            if (IsBetween(angle1,80f,100f) && IsBetween(angle2,82f,102f))
            {
                if (IsBetween(angle3,75f,95f) && IsBetween(angle4,65f,85f))
                {
                    if(currentlevel < 5)
                {
                    PlayerPrefs.SetInt("currentlvl",5);
                }
               SceneManager.LoadScene(0);
                }
            }
        }
        if (tag_o == "42")
        {
            Debug.Log(angle4);
            if (IsBetween(angle1,85f,105f) && IsBetween(angle2,1f,10f))
            {
                if (IsBetween(angle3,130f,150f) && IsBetween(angle4,128f,148f))
                {
                    if(currentlevel < 6)
                {
                    PlayerPrefs.SetInt("currentlvl",6);
                }
               SceneManager.LoadScene(0);
                }
            }
        }

        
    }

    public bool IsBetween(float testValue, float bound1, float bound2)
    {
        if(testValue >= Mathf.Min(bound1,bound2) && testValue <= Mathf.Max(bound1,bound2))
            return (true);
        else
            return (false);
    }
}
