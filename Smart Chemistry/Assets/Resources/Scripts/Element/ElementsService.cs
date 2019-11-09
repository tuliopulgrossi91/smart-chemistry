using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
using System.Globalization;
public class ElementsService : MonoBehaviour
{
    string path;
    string jsonString;
    public GameObject ElementDrag;
    public GameObject ElementFixed;
    public Transform transformPanel;
    public Transform transformTable;
    public static ElementsCollection elementsCollection;
    void Start()
    {
        path = Application.dataPath + "/Resources/Json/elements.json";
        jsonString = File.ReadAllText(path);
        elementsCollection = new ElementsCollection();
        elementsCollection = JsonUtility.FromJson<ElementsCollection>(jsonString);
        //Create Objects
        for (int i = 0; i < elementsCollection.elements.Length; i++)
        {

            GameObject elementDragClone = Instantiate(ElementDrag, transformPanel);
            GameObject elementFixedClone = Instantiate(ElementFixed, transformTable);
            elementDragClone.transform.GetChild(0).GetComponent<Text>().text = elementsCollection.elements[i].symbol;
            elementFixedClone.transform.GetChild(0).GetComponent<Text>().text = elementsCollection.elements[i].atomicNumber.ToString();
            elementFixedClone.transform.position = convertStringtoVector3(elementsCollection.elements[i].startPosition);
            elementFixedClone.name = elementsCollection.elements[i].symbol;
        }
        ElementFixed.SetActive(false);
        ElementDrag.SetActive(false);
        //Find Element
        Element element = findByAtomicNumber(1);
    }

    public static Element findByAtomicNumber(int atomicNumber)
    {
        int pos = 0;
        pos = Array.FindIndex(elementsCollection.elements, (x) => (x.atomicNumber == atomicNumber));
        return elementsCollection.elements[pos];
    }

    public static Element findBySymbol(string symbol)
    {
        int pos = 0;
        pos = Array.FindIndex(elementsCollection.elements, (x) => (x.symbol == symbol));
        return elementsCollection.elements[pos];
    }


    public static Vector3 convertStringtoVector3(string stringV3)
    {
        var culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
        culture.NumberFormat.NumberDecimalSeparator = ".";
        string[] stringV3Array = stringV3.Split(","[0]);
        return new Vector3(float.Parse(stringV3Array[0], culture), float.Parse(stringV3Array[1], culture), float.Parse(stringV3Array[2], culture));
    }
}
