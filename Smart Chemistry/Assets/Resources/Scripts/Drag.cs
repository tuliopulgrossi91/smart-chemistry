using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class Drag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public static GameObject itemBeingDragged;
    Vector3 startPosition;

    #region IBeginDragHandler implementation

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log(gameObject.GetComponentInChildren<Text>().name);
        itemBeingDragged = gameObject;
        startPosition = transform.position;
    }

    #endregion

    #region IDragHandler implementation

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    #endregion

    #region IEndDragHandler implementation

    public void OnEndDrag(PointerEventData eventData)
    {
        itemBeingDragged = null;
        Debug.Log(GameObject.FindGameObjectWithTag("element").transform.localPosition);
        // transform.position = startPosition;

    }

    #endregion
}
