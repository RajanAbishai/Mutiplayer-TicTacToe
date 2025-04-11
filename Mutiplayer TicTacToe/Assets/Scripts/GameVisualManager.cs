using Unity.Netcode;
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
        //We want no rotation.. hence, quaternion.identity.

        Transform spawnedCrossTransform = Instantiate(crossPrefab);

        // this says that the object SHOULD be spawned across the network.. meaning it should get spawned on all clients.
        spawnedCrossTransform.GetComponent<NetworkObject>().Spawn(true);
        spawnedCrossTransform.position = GetGridWorldPosition(e.x, e.y); // will produce networking error
        
        

    }

    private Vector2 GetGridWorldPosition(int x, int y)
    {
        return new Vector2(-GRID_SIZE + x*GRID_SIZE, -GRID_SIZE + y*GRID_SIZE);

    }
}
