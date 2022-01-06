using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

internal class ExamplePlayer :MonoBehaviour, IHasHealthBar,IHasPointBar
{
    public event UnityAction<int, int> HealthChange;
    public event UnityAction<int, int> PointChange;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            HealthChange?.Invoke(50,100);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            PointChange?.Invoke(30,100);
        }
    }

}