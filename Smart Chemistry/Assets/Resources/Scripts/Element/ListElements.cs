using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
public class ListElements : MonoBehaviour
{
    string path;
    string jsonString;
    public GameObject ElementDrag;
    public Transform transformParent;
    void Start()
    {
        path = Application.dataPath + "/Resources/Json/elements.json";
        jsonString = File.ReadAllText(path);
        ElementsCollection elementsCollection = JsonUtility.FromJson<ElementsCollection>(jsonString);

        //Create Objects
        for (int i = 1; i < elementsCollection.elements.Length; i++)
        {
            GameObject elementClone = Instantiate(ElementDrag, transformParent);
            elementClone.transform.GetChild(0).GetComponent<Text>().text = elementsCollection.elements[i].symbol;
        }

        //Find Element
        Element element = this.findByAtomicNumber(1, elementsCollection.elements);
        Debug.Log(element.name);
        Debug.Log(element.symbol);
        Debug.Log(element.atomicNumber);
        Debug.Log(element.initialPosition);
    }

    public Element findByAtomicNumber(int atomicNumber, Element[] elements)
    {
        int pos = 0;
        pos = Array.FindIndex(elements, (x) => (x.atomicNumber == atomicNumber));
        return elements[pos];
    }
}
