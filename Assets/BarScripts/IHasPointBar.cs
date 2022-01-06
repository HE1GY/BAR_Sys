using UnityEngine.Events;

internal interface IHasPointBar
{
    public event UnityAction<int, int> PointChange;
}