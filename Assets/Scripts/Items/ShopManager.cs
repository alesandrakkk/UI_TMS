using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Assets.Scripts.Items
{
    public class ShopManager : MonoBehaviour
    {
        [SerializeField]  private int myMoney = 1000;

        
        [SerializeField] private Items _item;

        
        [SerializeField] private ButtonTest _buyButton;

        private List<Items> items = new List<Items>();



        void Awake()
        {
            _buyButton.AddListener(BuyItem);
        }

        private void BuyItem()
        {
            for (int i = 0; i < items.Count; i++)
            {
                //if (items[i] <= myMoney)
                //{

                //}
            }
        }

    }
}