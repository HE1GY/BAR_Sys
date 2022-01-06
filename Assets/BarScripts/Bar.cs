using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;


[RequireComponent(typeof(Slider))]
public abstract class Bar: MonoBehaviour
{
    [SerializeField] protected GameObject barUser;
    
    private Slider _slider;
    
    protected abstract void OnEnable();
    protected abstract void OnDisable();
    
    protected void Awake()
    {
        _slider = GetComponent<Slider>();
    }
    protected void OnvalueChange(int value, int maxValue)
    {
        _slider.value = (float)value / maxValue;
    }
}