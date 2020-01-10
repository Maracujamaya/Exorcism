using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PossessedMovement : MonoBehaviour
{

    public GameObject playerObject;

    public Transform linkeHand;
    public Transform rechteHand;

    private Transform linksOldPosition;
    private Transform linksCurrentPosition;
    private Vector3 linksDistance;

    private Transform rechtsOldPosition;
    private Transform rechtsCurrentPosition;
    private Vector3 rechtsDistance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(linksOldPosition != null)
        {
            linksDistance = (linksOldPosition.position + linksCurrentPosition.position);
        }

        if (rechtsOldPosition != null)
        {
            rechtsDistance = (rechtsOldPosition.position + rechtsCurrentPosition.position);
        }



        playerObject.transform.position += (linksDistance + rechtsDistance);

        linksOldPosition = linksCurrentPosition;
        rechtsOldPosition = rechtsCurrentPosition;


    }
}
