using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7DllsToDie
{
    public class SaveManager
    {
        public static string SaveFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/7DaysToDie";

        public static void PlatformUpdate(){
			if (Environment.OSVersion.ToString().Contains("Unix"))
				SaveFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Library/Application Support/7DaysToDie";

		}
        public static List<GameSaveItem> ScanSaves()
        {
            var GameSaves = new List<GameSaveItem>();
            string[] worlds = { "Navezgane", "Random Gen" };
            foreach (string world in worlds)
            {
                var Dirs = Directory.GetDirectories(SaveFolder + "/Saves/" + world);

                foreach (string Dir in Dirs)
                {
                    var paths = Directory.GetFiles(Dir + "/Player/", "*.ttp");
                    var IDs = new List<string>();
                    foreach (string path in paths)
                    {
                        IDs.Add(Path.GetFileNameWithoutExtension(path));
                    }
                    string gamename = new DirectoryInfo(Dir).Name;
                    GameSaves.Add(new GameSaveItem(world, gamename, IDs.ToArray()));

                }
            }
            return GameSaves;
        }

        public static void CopySave(string Source, string Destination)
        {
            if (File.Exists(Destination + ".bak"))
                File.Delete(Destination + ".bak");
            //File.Move(Destination, Destination + ".bak");
            if (File.Exists(Destination))
                File.Delete(Destination);
            File.Copy(Source, Destination);
            File.Copy(Source + ".bak", Destination + ".bak");
        }

        public static void ImportSave(string Source, string Destination)
        {
            if (File.Exists(Destination + ".bak"))
                File.Delete(Destination + ".bak");
            //File.Move(Destination, Destination + ".bak");
            if (File.Exists(Destination))
                File.Delete(Destination);
            File.Copy(Source, Destination);
            File.Copy(Source, Destination + ".bak");
        }

        public static void ExportSave(string Source, string Destination)
        {
            File.Copy(Source, Destination);
        }
    }
    //%APPDATA%/7DaysToDie/Saves/[Random Gen/Navezgane]/[Game Name]/Player/[playerID.[map/ttp/ttp.bak]
    public class GameSaveItem
    {
        private string world;
        private string gameName;
        private string[] playerIDs;
        public GameSaveItem(string World, string GameName, string[] PlayerIDs)
        {
            world = World;
            gameName = GameName;
            playerIDs = PlayerIDs;
        }

        public string World { get { return world; } }
        public string GameName { get { return gameName; } }
        public string[] PlayerIDs { get { return playerIDs; } }
        public string GetPath(int PlayerIndex)
        {
            return SaveManager.SaveFolder + "/Saves/" + world + "/" + gameName + "/Player/" + playerIDs[PlayerIndex] + ".ttp";
        }
    }
}
