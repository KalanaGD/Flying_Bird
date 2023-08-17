using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FgLoop : MonoBehaviour
{
    [SerializeField] private float _fgSpeed;
    [SerializeField] Renderer _fgRenderer;

    private void Update()
    {
        _fgRenderer.material.mainTextureOffset += new Vector2(_fgSpeed * Time.deltaTime, 0f);
    }

}
