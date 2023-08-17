using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GTexture : MonoBehaviour
{
    [SerializeField] private float _gtSpeed;
    [SerializeField] Renderer _gtRenderer;

    private void Update()
    {
        _gtRenderer.material.mainTextureOffset += new Vector2(_gtSpeed * Time.deltaTime, 0f);
    }

}
