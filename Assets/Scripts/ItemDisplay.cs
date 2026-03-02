using UnityEngine;
using UnityEngine.UI;

public class ItemDisplay : MonoBehaviour
{
    public ItemData itemData;
    public Text titleText;
    public Image iconImage;

    void Start()
    {
        titleText.text = itemData.itemTitle;
        iconImage.sprite = itemData.itemIcon;
    }
}