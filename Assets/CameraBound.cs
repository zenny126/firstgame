using UnityEngine;

public class CameraBoundaries : MonoBehaviour
{
    public Camera mainCamera;
    private Vector2 minBounds;
    private Vector2 maxBounds;

    void Start()
    {
        if (mainCamera == null)
        {
            mainCamera = Camera.main;
        }

        // Calculate the camera boundaries
        float vertExtent = mainCamera.orthographicSize;
        float horzExtent = vertExtent * Screen.width / Screen.height;

        minBounds = new Vector2(mainCamera.transform.position.x - horzExtent, mainCamera.transform.position.y - vertExtent);
        maxBounds = new Vector2(mainCamera.transform.position.x + horzExtent, mainCamera.transform.position.y + vertExtent);
    }

    public Vector2 MinBounds
    {
        get { return minBounds; }
    }

    public Vector2 MaxBounds
    {
        get { return maxBounds; }
    }
}
