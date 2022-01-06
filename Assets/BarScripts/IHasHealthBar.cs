using UnityEngine.Events;

internal interface IHasHealthBar
{
    public event UnityAction<int, int> HealthChange;
}