using System;
using System.IO;
using Newtonsoft.Json;


namespace Sports_equipment
{
    public class Serialize
    {
        // Feed the global settings in the Serializer Method
        static JsonSerializerSettings settings = new JsonSerializerSettings() { Formatting = Formatting.Indented, TypeNameHandling = TypeNameHandling.Auto };

        /// <summary>
        /// Serializes to disk.
        /// </summary>
        /// <returns>The to disk.</returns>
        /// <param name="articleCollection">Article collection.</param>
        /// <param name="filename">Filename.</param>
        static public string serializeToDisk(IPrint[] articleCollection, string filename)
        {

            string json = JsonConvert.SerializeObject(articleCollection, settings);

            var filepath = Serialize.filePathToDesktopFromName(filename);
            File.WriteAllText(filepath, json);


            return json;
        }
        /// <summary>
        /// Deserializes from json.
        /// </summary>
        /// <returns>The from json.</returns>
        /// <param name="filename">Filename.</param>
        static public IPrint[] deserializeFromFilename (string filename)
        {
            var filepath = Serialize.filePathToDesktopFromName(filename);

            var fileFromText = File.ReadAllText(filepath);
            IPrint[] objects = JsonConvert.DeserializeObject<IPrint[]>(filepath, settings);

            return objects;
        }

        static public SportsItem[] deserializeSportsItemFromFilename(string filename)
        {
            var filepath = Serialize.filePathToDesktopFromName(filename);

            var fileFromText = File.ReadAllText(filename);
            SportsItem[] objects = JsonConvert.DeserializeObject<SportsItem[]>(filepath, settings);

            return objects;
        }

        /// <summary>
        /// Deletes the file.
        /// </summary>
        /// <param name="filename">Filename.</param>
        static public void deleteFile (string filename)
        {
            File.Delete(Serialize.filePathToDesktopFromName(filename));
        }

        /// <summary>
        /// Files the name of the path to desktop from.
        /// </summary>
        /// <returns>The path to desktop from name.</returns>
        /// <param name="filename">Filename.</param>
        static private string filePathToDesktopFromName(string filename)
        {
            // construct path to current desktop
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var filepath = Path.Combine(desktop, filename);

            return filepath;
        }
    }
}
