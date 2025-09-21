using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class OwnerBuyButton : MonoBehaviour
{
    [SerializeField] TMP_Text ownerNameText;
    [SerializeField] Button buyButton;
    
    [SerializeField] private CollectionSO collectionSO;

    private Owenr owenrData;

    void Start()
    {
        Debug.Log($"OwnerBuyButton {gameObject.name}");
        buyButton.onClick.AddListener(OnClick_BuyButton);
    }

    public void SetOwnerData(Owenr owner)
    {
        owenrData = owner;

        SetOwnerName(owenrData.name);
    }

    private void SetOwnerName(string ownerName)
    {
        ownerNameText.text = ownerName;
    }

    private void OnClick_BuyButton()
    {
        Debug.Log("Buy Button Clicked!");
        bool isBuyable = GameManager.Instance.SubtractGold(owenrData.price);

        if (isBuyable)
        {
            // TODO : 도감 처리
            Debug.Log($"{owenrData.name}을 구출했습니다.");
            // collectionSO 주인과 강아지의 데이터
            // 주인을 구출했을 때, 컬렉션에 등록되어야함.
            // Collection Data에서 주인 ID 검색
            int index = collectionSO.GetIndexByOwnerID(owenrData.id);
            Debug.Log($"Index: {index}");
            if (index != -1)
            {
                CollectionManager.Instance.ChangeCollection(index);
            }
            
        }
    }
}
