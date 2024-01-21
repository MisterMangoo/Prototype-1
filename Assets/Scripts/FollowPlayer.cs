using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 Offset = new Vector3(0, 4, -8);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate() // met LateUpdate update de code pas nadat de method ìs geweest. Zo voorkom je een happerent effect.
    {
        // Camera volgt de player en heeft een standaard waarde achter de auto
        transform.position = player.transform.position + Offset;
    }
}
