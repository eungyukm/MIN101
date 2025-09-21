using UnityEngine;

public enum PopupType
{
    Collection = 0,
    Shelter,
    Shop,
    Owner,
    Setting,
    Mining
}

public class PopupManager : MonoBehaviour
{
    private static PopupManager instance;
    
    [SerializeField] GameObject[] popups;
    
    public static PopupManager Get()
    {
        if (instance == null)
        {
            instance = FindObjectOfType<PopupManager>();
        }
        
        return instance;
    }

    void Start()
    {
        InitUI();
    }

    void InitUI()
    {
        ActivatePopup(PopupType.Mining);
    }

    void HideAllPopups()
    {
        foreach (GameObject popup in popups)
        {
            popup.SetActive(false);
        }
    }

    public void ActivatePopup(PopupType popupType)
    {
        HideAllPopups();
        // type casting => enum -> int
        // 0 => Collection => popups[0].SetActive(true)
        // 상위 클래스의 UI Popup에 Open을 불러 코드가 단 한줄로 구동
        popups[(int)popupType].GetComponent<UIPopup>().Open();
    }
    
    // DeActive
}
