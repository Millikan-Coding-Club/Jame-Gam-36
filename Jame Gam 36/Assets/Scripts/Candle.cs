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
    private float currentIntensity;
    private void Start()
    {
        candle = GetComponent<Light2D>();
        intensityDefault = GetComponent<Light2D>().intensity;
        outerRadiusDefault = GetComponent<Light2D>().pointLightOuterRadius;
        InvokeRepeating("Flicker", 0f, Random.Range(2f, 10f));
    }
    // Update is called once per frame
    void Update()
    {
        if (candle.intensity != 0)
        {
            candle.intensity = candle.intensity - dimSpeed * Time.deltaTime * intensityDefault;
            candle.pointLightOuterRadius = candle.pointLightOuterRadius - dimSpeed * Time.deltaTime * outerRadiusDefault;
        }
    }

    private void Flicker()
    {
        currentIntensity = candle.intensity;
        candle.intensity = 0f;
        Invoke("ResetIntensity", Random.Range(0.1f, 0.3f));
    }
    private void ResetIntensity()
    {
        candle.intensity = currentIntensity;
    }
}
