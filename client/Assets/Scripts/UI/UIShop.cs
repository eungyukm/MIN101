using UnityEngine;
using UnityEngine.UI;

public class UIShop : UIPopup
{
    [SerializeField] Button buyButton;

    protected override void UIBind()
    {
        base.UIBind();
        buyButton.onClick.AddListener(OnClick_Buy);
    }

    private void OnClick_Buy()
    {
        Debug.Log("OnClick_Buy");
        GachaSystem.Instance.PrintGachaData();
    }
}
