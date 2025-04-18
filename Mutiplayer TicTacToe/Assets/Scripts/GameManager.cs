using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance //Static means this field will belong to the class itself and not an instance of that class
    {
        get;
        private set;
    }
    public event EventHandler<OnClickedOnGridPositionEventArgs> OnClickedOnGridPosition;
    public class OnClickedOnGridPositionEventArgs : EventArgs
    {
        public int x;
        public int y;

    }

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("More than 1 game manager instance");
        }
        Instance = this;
    }

    public void ClickedOnGridPosition(int x, int y)
    {
        Debug.Log("Clicked on Grid Position " + x + ", " + y);
        OnClickedOnGridPosition?.Invoke(this, new OnClickedOnGridPositionEventArgs {x = x,y = y} ) ; //invoking the event

    }




} // class
