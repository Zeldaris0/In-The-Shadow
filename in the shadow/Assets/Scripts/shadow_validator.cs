using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    void Start ()
    {
        top = GameObject.FindGameObjectWithTag("top");
        tag_o = gameObject.tag;
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
               Debug.Log("tsuuu");
            }
        }
        if (tag_o == "eleph2")
        {
            if (IsBetween(angle1,80f,100f) && IsBetween(angle2,90f,110f))
            {
               Debug.Log("tsuuu");
            }
        }
        if (tag_o == "tea")
        {
            if (IsBetween(angle1,55f,75f) && IsBetween(angle2,60f,80f))
            {
               Debug.Log("tsuuu");
            }
        }
        if (tag_o == "globe")
        {
            if (IsBetween(angle1,80f,100f) && IsBetween(angle2,82f,102f))
            {
                if (IsBetween(angle3,75f,95f) && IsBetween(angle4,65f,85f))
                {
                    Debug.Log("tsuuu");
                }
            }
        }
        if (tag_o == "42")
        {
            if (IsBetween(angle1,80f,100f) && IsBetween(angle2,82f,102f))
            {
                if (IsBetween(angle3,75f,95f) && IsBetween(angle4,65f,85f))
                {
                    Debug.Log("tsuuu");
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
