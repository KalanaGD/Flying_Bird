using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgLoop : MonoBehaviour
{
    [SerializeField] private float _bgSpeed;
    [SerializeField] Renderer _bgRenderer;

    private void Update()
    {
        _bgRenderer.material.mainTextureOffset += new Vector2(_bgSpeed * Time.deltaTime, 0f);
    }

}
