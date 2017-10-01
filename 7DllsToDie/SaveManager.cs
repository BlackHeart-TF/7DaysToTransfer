using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7DllsToDie
{
    public static class SaveManager
    {
        
        
		public static string SaveFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/7DaysToDie";

        public static void PlatformUpdate()
        {
            if (Environment.OSVersion.ToString().Contains("Unix"))
                SaveFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/Library/Application Support/7DaysToDie";

        }
        public static List<WorldSaveItem> ScanSaves()
        {
            var GameSaves = new List<WorldSaveItem>();
            string[] worlds = { "Navezgane", "Random Gen" };
            foreach (string world in worlds)
            {
                var Dirs = Directory.GetDirectories(SaveFolder + "/Saves/" + world);

                foreach (string Dir in Dirs)
                {
                    string gamename = new DirectoryInfo(Dir).Name;
                    GameSaves.Add(new WorldSaveItem(world, gamename));

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
    public class WorldSaveItem
    {
        public string World { get; }
        public string GameName { get; }
        public CharacterSave[] Players;
        public WorldSaveItem(string World, string GameName)
        {
            this.World = World;
            this.GameName = GameName;
            Players = GetPlayers();
        }
        private CharacterSave[] GetPlayers()
        {
            var paths = Directory.GetFiles(SaveManager.SaveFolder + "/Saves/" + World + "/" + GameName + "/Player/", "*.ttp");
            var IDs = new List<CharacterSave>();
            foreach (string path in paths)
            {
                IDs.Add(new CharacterSave(path));
            }
            return IDs.ToArray();
        }
		public string[] GetUserNames()
		{
            var Names = new List<string>();
			
			foreach (var player in Players)
			{
				Names.Add(player.UserName);
			}
			return Names.ToArray();
		}
    }

    public class CharacterSave
    {
		private static byte[] NameBase = new byte[] { 0xFF, 0xFF, 0x00 };
		private static int NameOffset = 15;
        private static int CharacterOffset = 6;

		public string ID { get; }
        public string UserName { get; }
        public string CharacterName { get; }
        public string Path { get; }

        public CharacterSave(string path)
        {
            Path = path;
            ID = System.IO.Path.GetFileNameWithoutExtension(Path);
            UserName = GetUserName();
            CharacterName = GetCharacterProfile();
        }

		public string GetUserName()
		{
			var NameBaseAddr = SearchFile(Path, NameBase);
			BinaryReader reader = new BinaryReader(new FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.None));
			reader.BaseStream.Position = NameBaseAddr + NameOffset;     // The offset you are reading the data from
			byte bytes = reader.ReadBytes(0x1)[0]; // Bytes read into an array
			byte[] name = reader.ReadBytes(bytes);
			reader.Close();
			return System.Text.Encoding.Default.GetString(name);
		}

		private string GetCharacterProfile()
		{
			var NameBaseAddr = SearchFile(Path, NameBase);
			BinaryReader reader = new BinaryReader(new FileStream(Path, FileMode.Open, FileAccess.Read, FileShare.None));
			reader.BaseStream.Position = NameBaseAddr + NameOffset;     // name Start
			byte nameBytes = reader.ReadBytes(0x1)[0];
            reader.BaseStream.Position += nameBytes + CharacterOffset;     // Start + name length + offset
			byte charBytes = reader.ReadBytes(0x1)[0];
			byte[] name = reader.ReadBytes(charBytes);
			reader.Close();
			return System.Text.Encoding.Default.GetString(name);
		}

		private static int SearchFile(string path, byte[] search)
		{
			//Find the byte
			BinaryReader br = new BinaryReader(File.OpenRead(path));
			int v = 0;
			int i = 0;
			for (i = 0; i <= br.BaseStream.Length; i++)
			{
				if (br.BaseStream.ReadByte() == NameBase[v])
				{
					Console.WriteLine("Found byte index " + v + " at offset " + i);
					v++;
					if (v == NameBase.Length)
					{
						break;
					}
				}
				else
				{
					v = 0;
				}
			}
			br.Close();
			return i;
		}

        private int GetUserLevel()
        {
            throw new NotImplementedException();
        }



    }
}
