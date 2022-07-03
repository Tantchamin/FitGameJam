using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenInformation : MonoBehaviour
{
    public GameObject information;
    private ItemInfo itemInformation;
    public Text itemName;
    public Text itemInfo;
    public Image itemImage;

    private void Start()
    {
        itemInformation = GetComponent<ItemInfo>();
        information.SetActive(false);

    }

    public void OpenInformationMenu()
    {
        itemName.text = itemInformation.name;
        itemInfo.text = itemInformation.info;
        itemImage.sprite = itemInformation.image;
        information.SetActive(true);
    }

    public void CloseInformationMenu()
    {
        information.SetActive(false);
    }
}
