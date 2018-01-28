﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Localizer : MonoBehaviour {
    public static Localizer instance;


    #region RARITY STATIC TRANSLATE

    public static string EN_COMMON = "Common";
    public static string EN_RARE = "Rare";
    public static string EN_LGD = "Legendary";
    public static string EN_ANCIENT = "Ancient";

    public static string KR_COMMON      = "일반";
    public static string KR_RARE        = "희귀";
    public static string KR_LGD         = "전설";
    public static string KR_ANCIENT     = "고대";

    public static string JP_COMMON = "一般";
    public static string JP_RARE = "まれな";
    public static string JP_LGD = "伝説の";
    public static string JP_ANCIENT = "古代";

    public static string CN_COMMON = "共同";
    public static string CN_RARE = "罕见";
    public static string CN_LGD = "传奇的";
    public static string CN_ANCIENT = "古";

    public static string CNT_COMMON = "共同";
    public static string CNT_RARE = "罕見";
    public static string CNT_LGD = "傳奇的";
    public static string CNT_ANCIENT = "古";

    #endregion

    #region UI KEY

    private readonly string t_ATown_key = "t_ATown_key";
    private readonly string t_BTown_key = "t_BTown_key";
    private readonly string t_CTown_key = "t_CTown_key";

    private readonly string t_Cancel_key = "t_Cancel_key";
    private readonly string t_Confirm_key = "t_Confirm_key";
    private readonly string t_Farming_key = "t_Farming_key";
    private readonly string t_ForgingItem_key = "t_ForgingItem_key";
    private readonly string t_ItemFound_key = "t_ItemFound_key";
    private readonly string t_ForgeNow_key = "t_ForgeNow_key";
    private readonly string t_Probability_Holder_key = "t_Probability_Holder_key";
    private readonly string t_ForgeSuccess_key = "t_ForgeSuccess_key";
    private readonly string t_SellingPrice_key = "t_SellingPrice_key";


    #endregion

    // Dictionary
    private Dictionary<string, string> dict;

    private void Awake()
    {
        if (instance == null) instance = this;
        dict = new Dictionary<string, string>();

        if (PlayerManager.instance.LANGUAGE == PlayerManager.DEVICE_LANGUAGE.EN)
        {
            FillDictionaryEN();
        }
        else if (PlayerManager.instance.LANGUAGE == PlayerManager.DEVICE_LANGUAGE.KR)
        {
            FillDictionaryKR();
        }
        else if (PlayerManager.instance.LANGUAGE == PlayerManager.DEVICE_LANGUAGE.JP)
        {
            FillDictionaryJP();
        }
        else if (PlayerManager.instance.LANGUAGE == PlayerManager.DEVICE_LANGUAGE.CN)
        {
            FillDictionaryCN();
        }
        else if (PlayerManager.instance.LANGUAGE == PlayerManager.DEVICE_LANGUAGE.CNT)
        {
            FillDictionaryCNT();
        }
        else
        {
            FillDictionaryEN();
        }
    }

    #region EN
    private void FillDictionaryEN(){

    }
    #endregion


    #region KR
    private void FillDictionaryKR()
    {
        dict.Add(t_ATown_key, "A 마을 시세");
        dict.Add(t_BTown_key, "B 마을 시세");
        dict.Add(t_CTown_key, "C 마을 시세");
        dict.Add(t_Cancel_key, "취소하기");
        dict.Add(t_Confirm_key  , "확인");
        dict.Add(t_Farming_key, "아이템 파밍 중");
        dict.Add(t_ForgingItem_key, "아이템 강화");
        dict.Add(t_ItemFound_key, "아이템 발견!");
        dict.Add(t_ForgeNow_key, "강화하기");
        dict.Add(t_Probability_Holder_key, "성공 확률");
        dict.Add(t_ForgeSuccess_key, "강화 성공!");
        dict.Add(t_SellingPrice_key, "판매 가격");

        /* dict interface
        dict.Add(t_ATown_key, "");
        dict.Add(t_BTown_key, "");
        dict.Add(t_CTown_key, "");
        dict.Add(t_Cancel_key, "");
        dict.Add(t_Confirm_key, "");
        dict.Add(t_Farming_key, "");
        dict.Add(t_ForgingItem_key, "");
        dict.Add(t_ItemFound_key, "");
        dict.Add(t_ForgeNow_key, "");
        dict.Add(t_Probability_Holder_key, "");
        dict.Add(t_ForgeSuccess_key, "");
        dict.Add(t_SellingPrice_key, "");
        */
    }
    #endregion


    #region JP
    private void FillDictionaryJP()
    {

    }
    #endregion


    #region CN
    private void FillDictionaryCN()
    {

    }
    #endregion


    #region CNT
    private void FillDictionaryCNT()
    {

    }
    #endregion

    public string GetTextFromLocal(string _key)
    {
        return dict[_key];
    }

    public static string GetENRarity(Item item){
        if(item.rarity == Item.Rarity.COMMON){
            return EN_COMMON;
        }
        else if(item.rarity == Item.Rarity.RARE){
            return EN_RARE;
        }
        else if (item.rarity == Item.Rarity.LEGENDARY)
        {
            return EN_LGD;
        }
        else{
            return EN_ANCIENT;
        }
    }

    public static string GetKRRarity(Item item)
    {
        if (item.rarity == Item.Rarity.COMMON)
        {
            return KR_COMMON;
        }
        else if (item.rarity == Item.Rarity.RARE)
        {
            return KR_RARE;
        }
        else if (item.rarity == Item.Rarity.LEGENDARY)
        {
            return KR_LGD;
        }
        else
        {
            return KR_ANCIENT;
        }
    }

    public static string GetJPRarity(Item item)
    {
        if (item.rarity == Item.Rarity.COMMON)
        {
            return JP_COMMON;
        }
        else if (item.rarity == Item.Rarity.RARE)
        {
            return JP_RARE;
        }
        else if (item.rarity == Item.Rarity.LEGENDARY)
        {
            return JP_LGD;
        }
        else
        {
            return JP_ANCIENT;
        }
    }

    public static string GetCNRarity(Item item)
    {
        if (item.rarity == Item.Rarity.COMMON)
        {
            return CN_COMMON;
        }
        else if (item.rarity == Item.Rarity.RARE)
        {
            return CN_RARE;
        }
        else if (item.rarity == Item.Rarity.LEGENDARY)
        {
            return CN_LGD;
        }
        else
        {
            return CN_ANCIENT;
        }
    }

    public static string GetCNTRarity(Item item)
    {
        if (item.rarity == Item.Rarity.COMMON)
        {
            return CNT_COMMON;
        }
        else if (item.rarity == Item.Rarity.RARE)
        {
            return CNT_RARE;
        }
        else if (item.rarity == Item.Rarity.LEGENDARY)
        {
            return CNT_LGD;
        }
        else
        {
            return CNT_ANCIENT;
        }
    }
}
