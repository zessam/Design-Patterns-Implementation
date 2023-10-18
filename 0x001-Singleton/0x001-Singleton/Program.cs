using System;
using System.Collections.Generic;


public class ConfigManager {
    // Created for the singleton
    private static ConfigManager instance;    
    // Dictionary to store configuration settings
    private Dictionary<string, string> settings;
    
    
    private ConfigManager() {
        // Private Constructor
        settings = new Dictionary<string, string>();
    }

    public static ConfigManager GetInstance()
    {
        if(instance == null)
        {
            instance = new ConfigManager();
        }
        return instance;
    } 

    // Method to get a specific configuration setting
    public string GetSetting(string key)
    {
        if (settings.ContainsKey(key))
        {
            return settings[key];
        }
        else
        {
            return null; 
        }
    }


    // Method to set or update a configuration setting
    public void SetSetting(string key, string value)
    {
        if (settings.ContainsKey(key))
        {
            settings[key] = value;
        }
        else
        {
            settings.Add(key, value);
        }
    }
}

class Program 
{
    static void Main(){
        // Access the singleton instance
        ConfigManager configManager = ConfigManager.GetInstance();
        
         // Set and get configuration settings
        configManager.SetSetting("FontSize", "14");
        configManager.SetSetting("Theme", "Dark");

        string fontSize = configManager.GetSetting("FontSize");
        string theme = configManager.GetSetting("Theme");

        // Output the retrieved settings
        Console.WriteLine($"FontSize: {fontSize}");
        Console.WriteLine($"Theme: {theme}");
    }
}