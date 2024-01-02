using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Firestore;
using Firebase.Extensions;
using TMPro;
using System;
using System.IO;

public class FirestoreManager : MonoBehaviour
{

    public GameObject createUsername;
    public GameObject createScore;
    public GameObject getUsername;
    public GameObject setScore;

    FirebaseFirestore db;
    // Start is called before the first frame update
    void Start()
    {
        db = FirebaseFirestore.DefaultInstance;
    }

    public void AddUser(){
        string username = createUsername.GetComponent<TMP_InputField>().text;
        string score = createScore.GetComponent<TMP_InputField>().text;
        DocumentReference docRef = db.Collection("users").Document(username);
        Dictionary<string, object> user = new Dictionary<string, object>(){
            { "score", Int32.Parse(score) },
            { "username", username }
        };
        docRef.SetAsync(user).ContinueWithOnMainThread(task => {
            Debug.Log("eklendi");
        });
    }


    public void GetScore(){
        CollectionReference usersRef = db.Collection("users");
        usersRef.GetSnapshotAsync().ContinueWithOnMainThread(task => {
            QuerySnapshot snapshots = task.Result;
            foreach(DocumentSnapshot document in snapshots.Documents){
                Dictionary<string, object> documentDictionary = document.ToDictionary();
                if(documentDictionary["username"].ToString() == getUsername.GetComponent<TMP_InputField>().text){
                    setScore.GetComponent<TMP_Text>().text = documentDictionary["score"].ToString();
                }
            }
        });
    }
}
