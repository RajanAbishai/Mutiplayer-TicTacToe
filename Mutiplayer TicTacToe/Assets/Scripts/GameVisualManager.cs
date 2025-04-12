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

        SpawnObject(e.x, e.y);

        
    }
    // earlier, produced networking error. Fixed by putting in another function and with RPC
    // this says that the object SHOULD be spawned across the network.. meaning it should get spawned on all clients.

    /*This is done so that the below function can be made an RPC rather than the function listening to the event an RPC*/
    private void SpawnObject(int x,int y)
    {
        Transform spawnedCrossTransform = Instantiate(crossPrefab);
        spawnedCrossTransform.GetComponent<NetworkObject>().Spawn(true);
        spawnedCrossTransform.position = GetGridWorldPosition(x, y); 

    }


    private Vector2 GetGridWorldPosition(int x, int y)
    {
        return new Vector2(-GRID_SIZE + x*GRID_SIZE, -GRID_SIZE + y*GRID_SIZE);

    }
}
