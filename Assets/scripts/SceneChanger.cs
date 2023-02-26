using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Globalization;
using TMPro;

public class SceneChanger : MonoBehaviour
{
    public ErrorScript erc;
    public InputField inf;
    public string password = "";
    public void changeScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }
    public void changePassword() {
        password = inf.text;
    }
    public void changetoProtectedScene()
    {
        if (password == "12345") {
            SceneManager.LoadScene("CreationScene");
        }
        else if (password.Length>32){
            erc.Error(6);
        }
        else if (password.Length<7){
            erc.Error(7);
        }
        else{
            erc.Error(8);
        }
        
    }
    public void NonDetermGo() {
        if (GameObject.Find("NonDetermSettings").GetComponentsInChildren<Toggle>()[0].isOn==true){
            int left_bord = 0;
            int right_bord = 0;
            var y1 = false;
            var y2 = false;
            y1 = int.TryParse(GameObject.Find("LeftBorder").GetComponent<TMP_InputField>().text,out left_bord);
            y2 = int.TryParse(GameObject.Find("RightBorder").GetComponent<TMP_InputField>().text,out right_bord);
            if (y1&&y2){
                if(left_bord>0&&right_bord>0){
                    if (left_bord<right_bord){
                        if ((left_bord<=10)&&(right_bord<=10)){
                            //Запись параметров
                        }
                        else{
                            erc.Error(11);
                        }
                    }
                    else{
                        erc.Error(9);
                    }
                }
                else{
                    erc.Error(10);
                }
            }
            else{
                erc.Error(4);
            }
        }
        else if (GameObject.Find("NonDetermSettings").GetComponentsInChildren<Toggle>()[1].isOn==true){
            int disp = 0;
            int expect = 0;
            var y1 = false;
            var y2 = false;
            y1 = int.TryParse(GameObject.Find("Dispersion").GetComponent<TMP_InputField>().text,out disp);
            y2 = int.TryParse(GameObject.Find("Expectation").GetComponent<TMP_InputField>().text,out expect);
            if (y1&&y2){
                if(disp>0&&expect>0){
                    if ((disp<=2)&&(expect<=5)){
                        //Запись параметров
                    }
                    else{
                        erc.Error(12);
                    }
                }
                else{
                    erc.Error(10);
                }
            }
            else{
                erc.Error(4);
            }
        }
        else if(GameObject.Find("NonDetermSettings").GetComponentsInChildren<Toggle>()[2].isOn==true) {
            double intens = 0;
            var y1 = false;
            y1 = double.TryParse(GameObject.Find("Intensity").GetComponent<TMP_InputField>().text,out intens);
            if (y1){
                if(intens>0){
                    if ((intens>=1)&&(intens<=5)){
                        //Запись параметров
                    }
                    else{
                        erc.Error(13);
                    }
                }
                else{
                    erc.Error(10);
                }
            }
            else{
                erc.Error(4);
            }
        }
        double inChance = 0;
        var y3 = false;
        y3 = double.TryParse(GameObject.Find("ChanceField").GetComponent<TMP_InputField>().text,out inChance);
        if (y3){
            if (inChance>0){
                if(inChance<=1){
                    //Запись параметров
                }
                else{
                    erc.Error(14);
                }
            }
            else{
                erc.Error(3);
            }
        }
        else{
            erc.Error(4);
        }
        CultureInfo enUS = new CultureInfo("ru-RU");
        DateTime time = DateTime.Now;
        var y4 = false;
        y4 = DateTime.TryParse(GameObject.Find("StartingTime").GetComponent<TMP_InputField>().text,out time);
        if (y4){
            //Запись параметров
        }
        else{
            erc.Error(4);
        }
    }


    public void exit()
    {
        Application.Quit();
    }
}
