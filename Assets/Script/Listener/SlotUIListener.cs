﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotUIListener : MonoBehaviour {
    private Image thisImage;
    public Image i_SpriteItem, i_SpriteOuter, i_SpriteInner;
    public Sprite sp_CommonOuter, sp_CommonInner;
    public Sprite sp_RareOuter, sp_RareInner;
    public Sprite sp_LegendaryOuter, sp_LegendaryInner;
    public Sprite sp_AncientOuter, sp_AncientInner;
    public Image i_Coin;
    public Text t_ItemName, t_Rarity, t_SellingCost;

    public Button b_Forge, b_Drop;

    [SerializeField ]private GameItem thisItem;

    private void Awake()
    {
        thisImage = GetComponent<Image>();
        b_Forge.onClick.AddListener(Forge);
        b_Drop.onClick.AddListener(Drop);
    }

    public void ActiveAllHolders(){
        thisImage.enabled = true;
        i_Coin.gameObject.SetActive(true);
        i_SpriteItem.gameObject.SetActive(true);
        i_SpriteOuter.gameObject.SetActive(true);
        i_SpriteInner.gameObject.SetActive(true);
        t_ItemName.gameObject.SetActive(true);
        t_Rarity.gameObject.SetActive(true);
        t_SellingCost.gameObject.SetActive(true);
        b_Forge.gameObject.SetActive(true);
        b_Drop.gameObject.SetActive(true);
    }

    public void InactiveAllHolders(){
        thisItem = null;
        thisImage.enabled = false;
        i_Coin.gameObject.SetActive(false);
        i_SpriteItem.gameObject.SetActive(false);
        i_SpriteOuter.gameObject.SetActive(false);
        i_SpriteInner.gameObject.SetActive(false);
        t_ItemName.gameObject.SetActive(false);
        t_Rarity.gameObject.SetActive(false);
        t_SellingCost.gameObject.SetActive(false);
        b_Forge.gameObject.SetActive(false);
        b_Drop.gameObject.SetActive(false);
    }


    public void OnNotify(GameItem item){
        thisItem = item;

        ActiveAllHolders();

        if (item.rarity == Item.Rarity.COMMON)
        {
            t_ItemName.color = ItemColorDefine.COMMON_TEXT_COLOR;
            t_Rarity.color = ItemColorDefine.COMMON_TEXT_COLOR;
            i_SpriteOuter.sprite = sp_CommonOuter;
            i_SpriteInner.sprite = sp_CommonInner;
        }
        else if (item.rarity == Item.Rarity.RARE)
        {
            t_ItemName.color = ItemColorDefine.RARE_TEXT_COLOR;
            t_Rarity.color = ItemColorDefine.RARE_TEXT_COLOR;
            i_SpriteOuter.sprite = sp_RareOuter;
            i_SpriteInner.sprite = sp_RareInner;
        }
        else if (item.rarity == Item.Rarity.LEGENDARY)
        {
            t_ItemName.color = ItemColorDefine.LGD_TEXT_COLOR;
            t_Rarity.color = ItemColorDefine.LGD_TEXT_COLOR;
            i_SpriteOuter.sprite = sp_LegendaryOuter;
            i_SpriteInner.sprite = sp_LegendaryInner;
        }
        else
        {
            t_ItemName.color = ItemColorDefine.ANCIENT_TEXT_COLOR;
            t_Rarity.color = ItemColorDefine.ANCIENT_TEXT_COLOR;
            i_SpriteOuter.sprite = sp_AncientOuter;
            i_SpriteInner.sprite = sp_AncientInner;
        }

        t_ItemName.text = item.nameNative;
        t_Rarity.text = item.rarityNative;
        t_SellingCost.text = item.sellingCost.ToString();
        i_SpriteItem.sprite = item.sprite;
    }

    private void Forge(){
        Debug.LogFormat("Forging {0}", thisItem.nameNative);
    }

    private void Drop(){
        Inventory.instance.DeleteItem(thisItem.uid);
    }
}