using System.IO;
using System.Xml.Serialization;


namespace BasicFacebookFeatures.Backend
{
    public sealed class AppSettings
    {
        private const string k_SettingsFilePath = "AppSettings.xml";
        private static AppSettings s_Instance = null;
        private static readonly object sr_LockObject = new object();

        public string LastAccessToken { get; set; }
        public int HigherLowerHighScore { get; set; }

        public AppSettings()
        {
            
        }

        public void LoadFromFile()
        {
            if (File.Exists(k_SettingsFilePath))
            {
                using (Stream stream = new FileStream(k_SettingsFilePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    s_Instance = serializer.Deserialize(stream) as AppSettings;
                }
            }
            else
            {
                s_Instance = null;
            }
        }

        public void SaveToFile()
        {
            if (File.Exists(k_SettingsFilePath))
            {
                using(Stream stream = new FileStream(k_SettingsFilePath, FileMode.Truncate))
                {
                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(stream, this);
                }
            }
            else
            {
                using(Stream stream = new FileStream(k_SettingsFilePath, FileMode.Create))
                {
                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(stream, this);
                }
            }
        }

        public void UpdateHighScore(int i_Score)
        {
            if (i_Score > HigherLowerHighScore)
            {
                HigherLowerHighScore = i_Score;
                SaveToFile();
            }
        }
    }
}
