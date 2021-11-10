using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    [SerializeField] float _intensity = 1f;
    Light _light = default;
    void Start()
    {
        _light = GetComponent<Light>();
    }
    void Update()
    {
        // _light.intensity = Random.Range(0f, 1f) * _intensity;
        _light.intensity = Mathf.PerlinNoise(Time.time, 0f) * _intensity;
    }
}
