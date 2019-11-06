using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
public class ListElements : MonoBehaviour
{
    string path;
    string jsonString;

    void Start()
    {
        path = Application.dataPath + "/Resources/Json/elements.json";
        jsonString = File.ReadAllText(path);
        ElementsCollection elementsCollection = JsonUtility.FromJson<ElementsCollection>(jsonString);
        Element element = this.findByAtomicNumber(1, elementsCollection.elements);
        Debug.Log(element.name);
        Debug.Log(element.symbol);
        Debug.Log(element.atomicNumber);
        Debug.Log(element.initialPosition);
    }

    public Element findByAtomicNumber(int atomicNumber, Element[] elements)
    {
        int pos = 0;
        pos = Array.FindIndex(elements , (x) => (x.atomicNumber == atomicNumber));
        return elements[pos];
    }
}
