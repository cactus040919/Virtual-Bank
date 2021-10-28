using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Character
{
    Jelly0,
    Jelly1,
    Jelly2,
    Jelly3,
    Jelly4,
    Jelly5,
    Jelly6,
    Jelly7,
    Jelly8,
    Jelly9,
    Jelly10,
    Jelly11
}
public class DataMgr : MonoBehaviour
{
    public static DataMgr instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != null)
        {
            return;
        }
        DontDestroyOnLoad(gameObject);
    }

    public Character currentCharacter;
}
