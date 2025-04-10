using UnityEngine;

public class GameVisualManager : MonoBehaviour
{
    private const float GRID_SIZE = 3.1f;

    [SerializeField] private Transform crossPrefab;  //can also say private GameObject
    [SerializeField] private Transform circlePrefab;

    private void Start()
    {
        GameManager.Instance.OnClickedOnGridPosition += GameManager_OnClickedOnGridPosition;
    }

    private void GameManager_OnClickedOnGridPosition(object sender, GameManager.OnClickedOnGridPositionEventArgs e)
    {
        //Instantiate(crossPrefab)

    }

    private Vector2 GetGridWorldPosition(int x, int y)
    {
        return new Vector2();
    }
}
