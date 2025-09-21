using UnityEngine;

public class BottomUIComponent : MonoBehaviour
{
    // On/Off Collection
    // On/Off => Off/On
    public void OnClick_Collection()
    {
        PopupManager.Get().ActivatePopup(PopupType.Collection);
    }

    public void OnClick_Shelter()
    {
        PopupManager.Get().ActivatePopup(PopupType.Shelter);
    }

    public void OnClick_Shop()
    {
        PopupManager.Get().ActivatePopup(PopupType.Shop);
    }

    public void OnClick_Owner()
    {
        PopupManager.Get().ActivatePopup(PopupType.Owner);
    }

    public void OnClick_Setting()
    {
        PopupManager.Get().ActivatePopup(PopupType.Setting);
    }
}
