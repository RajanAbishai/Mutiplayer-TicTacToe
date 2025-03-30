using UnityEngine;
//using UnityEngine.EventSystems;

public class GridPosition : MonoBehaviour//,IPointerDownHandler
{
    /*
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("On Ponter Down!");
    }

    // add a raycaster to the main camera. Physics 2D raycaster is what is going to allow that function to be called. We also need an EventSystem.
    
    */
    [SerializeField] private int x, y;
    [SerializeField] private GameManager gameManager;


    private void OnMouseDown()
    {
        Debug.Log("Clicked position: " +x +","+ y);
        gameManager.ClickedOnGridPosition(x, y);

    }


}


