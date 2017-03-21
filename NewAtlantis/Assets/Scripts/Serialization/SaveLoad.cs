using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveLoad {

    public static List<Game> savedGames = new List<Game>();
    private static string filePath = Application.persistentDataPath + "/SavedGames.na";

    public static void Save()
    {
        savedGames.Add(Game.current);
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        FileMode currentFileMode = (File.Exists(filePath)) ? FileMode.Append : FileMode.Create;
        FileStream file = File.Open(filePath,currentFileMode);
        binaryFormatter.Serialize(file,savedGames);
        file.Close();
    }

    public static void Load()
    {
        if(!File.Exists(filePath))
        {
            return;
        }
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        FileStream file = File.Open(filePath, FileMode.Open);
        SaveLoad.savedGames = (List<Game>)binaryFormatter.Deserialize(file);
        file.Close();
    }
}