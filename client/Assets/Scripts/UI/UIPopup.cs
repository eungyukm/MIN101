using UnityEngine;
using UnityEngine.UI;

public class UIPopup : MonoBehaviour
{
    [SerializeField] private Button Button_Close;
    
    #region LifeCycle
    protected virtual void Awake()
    {
        
    }
    
    protected virtual void Start()
    {
        Debug.Log($"UIPopup start");
        // UIGetComponent();
        UIBind();
    }
    
    /// <summary>
    /// 해당 함수는 UI를 Bind하기 위한 함수입니다.
    /// virtual 가상 함수라는 뜻으로 하위에서 재정의 가능합니다.
    /// </summary>
    protected virtual void UIBind()
    {
        Button_Close.onClick.AddListener(OnClick_Close);
    }

    // protected virtual void UIGetComponent()
    // {
    //     
    // }
    #endregion
    
    public void Open()
    {
        Debug.Log("Open");
        Debug.Log($"gameObject: {gameObject.name}");
        gameObject.SetActive(true);
    }
    
    public void OnClick_Close()
    {
        Debug.Log("Close");
        gameObject.SetActive(false);

        OpenMainUI();
    }

    void OpenMainUI()
    {
        PopupManager.Get().ActivatePopup(PopupType.Mining);
    }
}

public class A1
{
    protected string name;
}

public class B1 : A1
{
    protected int age;
}

public class C1 : B1
{
    // C1()은 생성자입니다.
    // 생성자는 클래스가 생성될 때 호출됩니다.
    public C1()
    {
        Debug.Log($"name: {name}");
        Debug.Log($"age: {age}");
    }
}