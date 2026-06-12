
using UnityEngine;

public class Door : MonoBehaviour
{
    public KeyHolder playerObject; 

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == playerObject.gameObject)
        {
            playerObject.CheckDoor(this);
        }
    }
}
