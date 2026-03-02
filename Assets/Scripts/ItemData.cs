using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Assignment/Item Data")]
public class ItemData : ScriptableObject
{
    public string itemTitle;
    public Sprite itemIcon;
}