using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeOutLineActive : MonoBehaviour
{
    private Outline _outlineSelf;

    private void Start()
    {
        _outlineSelf = GetComponent<Outline>();
    }

    private void OnMouseEnter()
    {
        ChangeEnabled();
    }

    private void OnMouseExit()
    {
        ChangeEnabled();
    }

    private void ChangeEnabled()
    {
        _outlineSelf.enabled = !_outlineSelf.enabled;
    }
}
