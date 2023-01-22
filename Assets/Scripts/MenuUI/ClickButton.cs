using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MenuUI
{
    public class ClickButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {

        [SerializeField] private Image _img;
        [SerializeField] private Sprite _default, _pressed;
        [SerializeField] private AudioClip _compressClip, _uncompressClip;
        [SerializeField] private AudioSource _source;
        
        public void OnPointerDown(PointerEventData eventData)
        {
            _img.sprite = _pressed;
            _source.PlayOneShot(_compressClip);
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            _img.sprite = _pressed;
            _source.PlayOneShot(_uncompressClip);
        }

        public void IWasClicked()
        {
            Debug.Log("Click! ");
        }
    }
}
