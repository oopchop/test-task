using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GetFormulaResult : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI formulaResult;
    [SerializeField] private TextMeshProUGUI strengthResult;
    [SerializeField] private TextMeshProUGUI alternatingResult;
    [SerializeField] private TextMeshProUGUI voltageResult;
    
    private float _resistance = 1000;
    private float _power = 400;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Null"))
        {
            RefreshAllResults();
            
            ChangeResult(0, formulaResult);
        }
        else if(other.CompareTag("Strength"))
        {
            float formula = _power / _resistance;

            RefreshAllResults();
            
            ChangeResult(GetResultOfFormula(formula), formulaResult);
            ChangeResult(GetResultOfFormula(formula), strengthResult);
        }
        else if (other.CompareTag("Voltage"))
        {
            float formula = _power * _resistance;

            RefreshAllResults();
            
            ChangeResult(GetResultOfFormula(formula), formulaResult);
            ChangeResult(GetResultOfFormula(formula), voltageResult);
        }
        else if (other.CompareTag("Alternating"))
        {
            RefreshAllResults();

            ChangeResult(0.01, formulaResult);
            ChangeResult(0.01, alternatingResult);
        }
        else if (other.CompareTag("Resistance"))
        {
            RefreshAllResults();
            
            ChangeResult(1000, formulaResult);
        }
    }

    private void RefreshAllResults()
    {
        strengthResult.text = "0";
        alternatingResult.text = "0";
        voltageResult.text = "0";
    }
    
    private double GetResultOfFormula(float formula)
    {
        return Math.Round(Math.Sqrt(formula), 2);
    }
    
    private void ChangeResult(double result, TextMeshProUGUI textBlockResult)
    {
        textBlockResult.text = result.ToString();
    }
}
