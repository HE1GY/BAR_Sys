using UnityEngine;

class PointBar : Bar
{
    private IHasPointBar _hasPointBarObj;

    private void Awake()
    {
        base.Awake();
        
        _hasPointBarObj = base.barUser.GetComponent<IHasPointBar>();
        if(_hasPointBarObj==null)Debug.LogError($"{base.barUser.name } didn't implement {typeof(IHasPointBar).Name}");
    }
    protected override void OnEnable()
    {
        _hasPointBarObj.PointChange += base.OnvalueChange;
    }

    protected override void OnDisable()
    { 
        _hasPointBarObj.PointChange -= base.OnvalueChange;
    }
}