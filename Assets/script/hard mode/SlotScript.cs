using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class SlotScript : MonoBehaviour, IDropHandler
{
    public int id;

    public void OnDrop(PointerEventData eventData)
    {
        //Debug.Log("Item Dropped");
        if(eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.GetComponent<DragAndDrop>().id == id)
            {
                Debug.Log("Correct!");
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
            }
            else
            {
                Debug.Log("Wrong!");
                eventData.pointerDrag.GetComponent<DragAndDrop>().ResetPosition();
            }
        }
    }
 
}
