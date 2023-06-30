using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace classes_1
{
    internal class ConsoleMonFactory
    {
        internal void Load(string datafile) 
        {
            string[] lines = File.ReadAllLines(datafile);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            for (int i = 0; i < lines.Length; i++)
            {
                string[] typeslpit = lines[i].Split('|');
                string[] consoleMonData = typeslpit[0].Split(',');
                ConsoleMon dataMon = new ConsoleMon();
                dataMon.name = consoleMonData[0];
                dataMon.health = int.Parse(consoleMonData[2]);
                dataMon.energy = int.Parse(consoleMonData[2]);
                
                Console.WriteLine(dataMon.name);
                Console.WriteLine(dataMon.health);
                Console.WriteLine(dataMon.energy);


            }
        }

        internal void LoadJson(string datafile)
        {
            string json = File.ReadAllText(datafile);
            List<ConsoleMon> templates = JsonSerializer.Deserialize<List<ConsoleMon>>(json);
            Console.WriteLine(templates[0].name);
        }
        internal ConsoleMon CopyConsoleMon(ConsoleMon copyFrom)
        {
            ConsoleMon copyResult = new ConsoleMon(copyFrom.health, copyFrom.energy, copyFrom.name, copyFrom.weakness);
            copyResult.skills = new List<Skill>();
            for (int i = 0; i < copyFrom.skills.Count; i++)
            {
                copyResult.skills.Add(CopySkill(copyFrom.skills[i]));
            }
            return copyResult;
        }
    }
}
