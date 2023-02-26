using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SaveLoadSystem : MonoBehaviour
{
    public GameObject prefab;
    public GameObject content;
    public GameObject butt;
    
    public void TopLoad(){
        //Загрузка топологии из файла
        //var copy = Instantiate(prefab, content.transform);

        // Присвоение полей если надо
        // copy.GetComponentsInChildren<ObjectPars>()[0].id = ind;
        // copy.GetComponentsInChildren<ObjectPars>()[0].name = FTName.text;
        // copy.GetComponentsInChildren<ObjectPars>()[0].par1 = int.Parse(FTVolume.text);
        // copy.GetComponentsInChildren<ObjectPars>()[0].fuel_id = db.FuelList[fuelType.value].id;
        // copy.GetComponentsInChildren<ObjectPars>()[0].fuel_name = db.FuelList[fuelType.value].name;

        //Вывод топологии
        // copy.GetComponentsInChildren<LayoutElement>()[0].GetComponentInChildren<TextMeshProUGUI>().text = FTName.text;
        // copy.GetComponentsInChildren<TextMeshProUGUI>()[3].text = FTVolume.text + " Л";
        // copy.GetComponentsInChildren<TextMeshProUGUI>()[4].text = db.FuelList[fuelType.value].name;
        // setLinks(copy);
    }
    public void setLinks(GameObject Top){

    }

    public void setPrefab(GameObject prefab) {
        GameObject.Find("SaveLoadSystem").GetComponent<SaveLoadSystem>().prefab = prefab;
    }

    public void changeButton(TextMeshProUGUI item) {
        GameObject.Find("SaveLoadSystem").GetComponent<SaveLoadSystem>().butt.GetComponentInChildren<TextMeshProUGUI>().text = "Выбрать " + item.text; 
    }

    

}
