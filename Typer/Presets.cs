using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typer
{
    public interface IPreset
    {
        string name { get;  }
        string message { get; }
        int interval { get; }
    }

    public class PokeCord : IPreset
    {
        public string name { get { return "PokeCord"; } }
        public string message { get { return "a{ENTER}"; } }
        public int interval { get { return 1000; } }
    }

    public static class PresetManager
    {
        
        public static List<IPreset> presets = new List<IPreset>();
        public static void loadPreset(IPreset preset)
        {
            presets.Add(preset);
        }
        public static List<string> getPresets()
        {
            List<string> list = new List<string>();
            foreach(IPreset preset in presets)
            {
                list.Add(preset.name);   
            }
            return list;
        }
        public static string getMessage(string presetName)
        {
            foreach (IPreset preset in presets)
            {
                if (preset.name == presetName) return preset.message;
            }
            return null;
        }
        public static int getInterval(string presetName)
        {
            foreach (IPreset preset in presets)
            {
                if (preset.name == presetName) return preset.interval;
            }
            return 1;
        }
    }
}
