using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgLoop : MonoBehaviour
{
    [SerializeField] private float _igSpeed;
    [SerializeField] Renderer _igRenderer;

    private void Update()
    {
        _igRenderer.material.mainTextureOffset += new Vector2(_igSpeed * Time.deltaTime, 0f);
    }

}
