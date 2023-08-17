using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    [SerializeField] private float _bgSpeed;
    [SerializeField] private Renderer _bgRenderer;

    private void Update()
    {
        _bgRenderer.material.mainTextureOffset += new Vector2(_bgSpeed * Time.deltaTime, 0f);
    }


}
