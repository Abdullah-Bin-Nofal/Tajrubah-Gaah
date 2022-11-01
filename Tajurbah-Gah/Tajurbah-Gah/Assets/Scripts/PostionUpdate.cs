using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostionUpdate : MonoBehaviour
{
    public GameObject bobPostion;

    void Update()
    {
        this.transform.position = new Vector3(bobPostion.transform.position.x, bobPostion.transform.position.y, bobPostion.transform.position.z);
    }
}
