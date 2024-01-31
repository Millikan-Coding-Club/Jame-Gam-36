using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Candle : MonoBehaviour
{
    [SerializeField] private float dimSpeed = 1.0f;
    private float outerRadiusDefault;
    private float intensityDefault;
    private Light2D candle;
    private void Start()
    {
        candle = GetComponent<Light2D>();
        intensityDefault = GetComponent<Light2D>().intensity;
        outerRadiusDefault = GetComponent<Light2D>().pointLightOuterRadius;
    }
    // Update is called once per frame
    void Update()
    {
        candle.intensity = candle.intensity - dimSpeed * Time.deltaTime * intensityDefault;
        candle.pointLightOuterRadius = candle.pointLightOuterRadius - dimSpeed * Time.deltaTime * outerRadiusDefault;
    }
}
