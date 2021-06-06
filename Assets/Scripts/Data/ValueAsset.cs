using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ValueAsset<T> : ScriptableObject
{
    private ValueAsset<T> _instance;
    public T value;

    public T GetValue()
    {
        return value;
    }

    public void SetValue(T input)
    {
        value = input;
    }

    

    public void SaveValue(T referance , string saveKey)
    {
        PlayerPrefs.SetString(saveKey, referance.ToString() );
        Debug.Log("SAving " + referance);
    }

    public T LoadValue(string saveKey )
    { 
        return (T)Convert.ChangeType(PlayerPrefs.GetString(saveKey), typeof(T));
    }
}
