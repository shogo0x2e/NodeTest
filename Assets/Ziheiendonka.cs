using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ziheiendonka : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private float thickness = 0;
    private float step = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();

        StartCoroutine(UpdateRyoiki());
    }

    // Update is called once per frame
    void Update()
    {

        meshRenderer.materials[1].SetFloat("_OutlineThickness", thickness);
    }

    private IEnumerator UpdateRyoiki()
    {
        while (true)
        {
            thickness += step;

            if (thickness <= 0 || thickness >= 1)
            {
                step = -step;
            }

            Debug.Log(thickness);

            yield return new WaitForSeconds(0.01f);
        }
    }
}
