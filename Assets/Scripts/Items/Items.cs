using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Items
{ [System.Serializable]
    public class Items : MonoBehaviour
    {
        [SerializeField] private Sprite _itemImage;

        [SerializeField] private int _itemPrice;

        [SerializeField] private string _itemName;

        [SerializeField] private int _idItem;

        public Sprite Image { get => _itemImage; set => _itemImage = value; }
        public int Price { get => _itemPrice; set => _itemPrice = value; }
        public string Name { get => _itemName; set => _itemName = value; }

      

       
    }
}