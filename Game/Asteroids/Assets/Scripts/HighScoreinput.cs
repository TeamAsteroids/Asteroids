using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class HighScoreinput : MonoBehaviour {
    internal SqlConnection conn = new SqlConnection();
    internal Button btn;
    public InputField nameInputField;
    public Button btnHScore;
    public ulong HighScore;


    // Use this for initialization
    void Start () {
        nameInputField = nameInputField.GetComponent<InputField>();
        btn = btnHScore.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        HighScore = 0;
        conn.ConnectionString =
        "Data Source= 127.0.0.1;" +
        "Initial Catalog= Astroids;" +
        "User id= Root;" +
        "Password=;";
        
    }
	
	// Update is called once per frame
	void Update () {
        btn.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
         string name = nameInputField.text;
         ulong score = HighScore;
        conn.Open();
        conn.Close();
    }


}
