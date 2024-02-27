using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Assets.Scripts.Items
{
    public class ShopManager : MonoBehaviour
    {
        private const int _maxPrice = 999;

        [SerializeField]  private int _myMoney = 1000;
        [SerializeField] private TMP_Text _myMoneyUI;

        [SerializeField] private Sprite[] _sprites;
        [SerializeField] private RectTransform _scrollViewItem;
        
        [SerializeField] private Items _item;
        [SerializeField] private int _quantityItem = 30;

        [SerializeField] private List<Items> items = new List<Items>();

        [SerializeField] private List<ButtonTest> _buyButton = new();

        



        void Start()
        {
            _myMoneyUI.text = "Money: " + _myMoney.ToString();

            
                ItemInstance();

                items.Add(_item);
            


           // _buyButton.AddListener(BuyItem);
        }
         
        public void ItemInstance()
        {
            for (int i = 0; i < _quantityItem; i++)
            {
                Sprite sprite = _sprites[Random.Range(0, _sprites.Length - 1)];
                int price = Random.Range(1, _maxPrice);

                //_item.Name = name;
                _item.Price = price;
                _item.Image = sprite;

                Items item = Instantiate(_item, _scrollViewItem);
                var itemImage = item.transform.Find("itemImage").GetComponent<Image>();
                itemImage.sprite = _item.Image;
            }


        }

        //private void BuyAccess()
        //{
        //    for (int i =0; i<items.Count; i++)
        //    {
        //        if (_myMoney >= items[i].baseCost);
        //    }
        //}

        private void BuyItem()
        {
            for (int i = 0; i < items.Count ; i++)
            {
                
            }
        }

    }
}