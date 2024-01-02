using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Database;
using TMPro;
using System;
using System.Security.Cryptography;

public class DatabaseManager : MonoBehaviour
{
    public GameObject createUsername;
    public GameObject createScore;
    public GameObject loadScore;
    public GameObject loadUsername;

    private string userID;
    private DatabaseReference databaseReference;

    void Start()
    {
        databaseReference = FirebaseDatabase.DefaultInstance.RootReference;
    }


    public void CreateUser(){
        userID = createUsername.GetComponent<TMP_InputField>().text;
        string usernameText = "";
        string scoreText = "";
        usernameText = createUsername.GetComponent<TMP_InputField>().text;
        scoreText = createScore.GetComponent<TMP_InputField>().text;
        User newUser = new User(usernameText, Int32.Parse(scoreText));
        string json = JsonUtility.ToJson(newUser);
        databaseReference.Child("users").Child(userID).SetRawJsonValueAsync(json);
        Debug.Log("Kayıt başarılı");
    }

    public void LoadUser(){
        StartCoroutine(Loader());
    }

    IEnumerator Loader(){
        string username = loadUsername.GetComponent<TMP_InputField>().text;
        var serverdata = databaseReference.Child("users").Child(username).GetValueAsync();
        yield return new WaitUntil(predicate: () => serverdata.IsCompleted);

        DataSnapshot snapshot = serverdata.Result;
        loadScore.GetComponent<TMP_Text>().text = snapshot.Child("score").Value.ToString();
    }

}
