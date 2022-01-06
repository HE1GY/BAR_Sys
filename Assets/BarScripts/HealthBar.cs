using System;
using UnityEngine;

class HealthBar : Bar
{
    private IHasHealthBar _HasHealthBarObj;
    private void Awake()
    {
        base.Awake();
        
        _HasHealthBarObj= barUser.GetComponent<IHasHealthBar>();
        if (_HasHealthBarObj == null) Debug.LogError($"{barUser.name} doesn't implement {typeof(IHasHealthBar).Name}");
    }
    protected override void OnEnable()
    {
        _HasHealthBarObj.HealthChange += OnvalueChange;
    }
    
    protected override void OnDisable()
    {
        _HasHealthBarObj.HealthChange -= OnvalueChange;
    }
}