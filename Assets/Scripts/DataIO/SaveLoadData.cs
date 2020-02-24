using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SaveLoadData: MonoBehaviour
{

    int currentScore = 0;
    string currentName = "Asd";
    float currentTimePlayed = 5.0f;

    void Start()
    {
        SaveFile();
        LoadFile();

        PlayerPrefs.SetFloat("Current Score", 10);
        PlayerPrefs.GetFloat("Current Score");
    }

    public void SaveFile()
    {
        string destination = Application.persistentDataPath + "/save.dat";
        FileStream file;

        if (File.Exists(destination)){
            file = File.OpenWrite(destination);
        }
        else { 
            file = File.Create(destination);
        }
        GameData data = new GameData(currentScore, currentName, currentTimePlayed);

        //Serialization
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(file, data);
        file.Close();
    }

    public void LoadFile()
    {
        string destination = Application.persistentDataPath + "/save.dat";
        FileStream file;

        if (File.Exists(destination)){
            file = File.OpenRead(destination);
            Debug.Log("Found a file with the name - " + destination );
        }
        else
        {
            Debug.LogError("File not found");
            return;
        }

        BinaryFormatter bf = new BinaryFormatter();
        GameData data = (GameData)bf.Deserialize(file);
        file.Close();

        currentScore = data.score;
        currentName = data.name;
        currentTimePlayed = data.timePlayed;

        Debug.Log(data.name);
        Debug.Log(data.score);
        Debug.Log(data.timePlayed);
    }

}