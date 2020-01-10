using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distances4 : MonoBehaviour
{
    // Start is called before the first frame update

    private enum Distance
    {
        Space,
        XYPlane
    }

    [SerializeField]
    private GameObject object5;
    [SerializeField]
    private GameObject object2;
    [SerializeField]
    private TextMesh distanceIndicator;
    [SerializeField]
    private Distance distanceType;

    private float distance;

    private LineRenderer lineRenderer;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        lineRenderer.SetPosition(0, object5.transform.position);
        lineRenderer.SetPosition(1, object2.transform.position);

        switch (distanceType)
        {
            case Distance.Space:
                distance = CalculateDistanceInSpace();
                distanceIndicator.text = "Distance in Space: " + distance.ToString();
                break;
            case Distance.XYPlane:
                distance = CalculateDistanceXYPlane();
                distanceIndicator.text = "Distance in XY Plane: " + distance.ToString();

                break;
        }

    }
    private float CalculateDistanceInSpace()
    {
        return Vector3.Distance(object5.transform.position, object2.transform.position);
    }
    private float CalculateDistanceXYPlane()
    {
        Vector2 v1 = new Vector2(object5.transform.position.x, object5.transform.position.y);
        Vector2 v2 = new Vector2(object2.transform.position.x, object2.transform.position.y);
        return Vector2.Distance(v1, v2);
    }
}
