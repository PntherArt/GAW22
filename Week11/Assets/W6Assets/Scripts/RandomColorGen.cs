using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColorGen : MonoBehaviour
{

    public MeshRenderer[] renderers;

    public void Start()
    {
        Color newColor = Random.ColorHSV();


        ApplyMaterial(newColor, 0);

    }


    void ApplyMaterial(Color color, int targetMatIndex)
    {
        Material generatedMaterial = new Material(Shader.Find("Universal Render Pipeline/Lit"));
        generatedMaterial.SetColor("_BaseColor", color);
        for (int i = 0; i < renderers.Length; i++)
        {
            renderers[i].material = generatedMaterial;
        }
    }
    
}
