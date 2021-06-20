using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ReflectionProbe))]
public class SkyboxCubemapExtractor : MonoBehaviour
{
    public Material fogMaterial;
    ReflectionProbe probe;

    private void Start()
    {
        probe = GetComponent<ReflectionProbe>();
        fogMaterial.SetTexture("skyCubemap", probe.texture);
    }
}
