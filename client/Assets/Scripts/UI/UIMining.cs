using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UIMining : UIPopup
{
    [SerializeField] private Button Button_Mining; 
    
    protected override void Awake()
    {
        base.Awake();
        
    }

    protected override void Start()
    {
        base.Start();
        Debug.Log($"UIMining Start!");
    }

    // protected override void UIGetComponent()
    // {
    //     Button_Mining = GetComponent<Button>();
    // }
    
    protected override void UIBind()
    {
        base.UIBind();
        Button_Mining.onClick.AddListener(OnClick_Mining);
    }
    
    public void OnClick_Mining()
    {
        Debug.Log("Mining..");
        DogManager.Instance.WorkAllDogs();
    }
}
