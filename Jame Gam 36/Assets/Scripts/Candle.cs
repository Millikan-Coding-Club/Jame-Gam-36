using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle : MonoBehaviour
{
    public GameObject source;

    // Update is called once per frame
    void Update()
    {
        transform.position = source.transform.position;
    }
}
