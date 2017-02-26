using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveLoad {

    public static List<Game> savedGames = new List<Game>();

    public void Save()
    {
        savedGames.Add(Game.current);
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/SavedGames.na");
        binaryFormatter.Serialize(file,SaveLoad.savedGames);
        file.Close();
    }

    public void Load()
    {
        if(File.Exists(Application.persistentDataPath + "/SavedGames.na"))
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/SavedGames.na", FileMode.Open);
            SaveLoad.savedGames = (List<Game>)binaryFormatter.Deserialize(file);
            file.Close();
        }
    }
}
