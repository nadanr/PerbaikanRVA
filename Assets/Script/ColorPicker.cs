using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{

    public Material[] BodyColorMat;
    Material CurrMat;
    Renderer renderer;

    // Use this for initialization
    void Start()
    {

        renderer = this.GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    //render blue color
    public void ChangeColor(Material nextMaterial)
    {
        renderer.material = nextMaterial;
        CurrMat = renderer.material;
    }

}