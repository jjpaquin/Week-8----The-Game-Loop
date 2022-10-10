using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThisAndThat : MonoBehaviour
{
    [SerializeField] GameObject blueCube, redCube, door;

    bool isRedCubeDetected, isBlueCubeDetected, areBothCubesDetected;

    // DIRECTIONS: This script is missing a crucial "if statement" in the Update() method.
    // Nothing in Update() needs to change, but something must be added...
    //
    // The "if statements" in OnTriggerEnter() also need to be fixed.


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isBlueCubeDetected && isRedCubeDetected)
        {
            areBothCubesDetected = true;
        }
        if (areBothCubesDetected)
        {
            door.GetComponent<MoveToLocation>().enabled = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == blueCube)
        {
            isBlueCubeDetected = true;
        }

        if (other.gameObject == redCube)
        {
            isRedCubeDetected = true;
        }
    }
}
