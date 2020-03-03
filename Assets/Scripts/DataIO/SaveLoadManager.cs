using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SaveLoadManager: MonoBehaviour
{

    void Start()
    {

    }

    public static void SaveFile(GameData data)
    {
        string destination = Application.persistentDataPath + "/save.dat";
        FileStream file;

        if (File.Exists(destination)){
            file = File.OpenWrite(destination);
        }
        else { 
            file = File.Create(destination);
        }

        //Serialization
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(file, data);
        file.Close();

        Debug.Log("Successfully saved the file");
    }

    public static GameData LoadFile()
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
            return null;
        }

        BinaryFormatter bf = new BinaryFormatter();
        GameData data = (GameData)bf.Deserialize(file);
        file.Close();

        return data;
    }

}