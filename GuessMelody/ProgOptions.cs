using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace GuessMelody
{
    /// <summary>
    /// Класс хранящий настройки программы
    /// </summary>
    public class ProgOptions
    {

        #region 'Поля и константы'

        private const string SONGS_LIST_FILE_NAME = "songs.xml";
        private const int DEFAULT_GAME_DURATION = 60;
        private const int DEFAULT_SONG_DURATION = 10;
        private const int DEFAULT_VOLUME_LEVEL = 35;

        private static readonly object _locker = new object();
        private static ProgOptions _instanse;
        
        private readonly XmlSerializer _songsListSerializer = new XmlSerializer(typeof(List<(string, bool)>));        
        private List<(string FileName, bool IsChecked)> _songsCollection = new List<(string, bool)>();

        #endregion 'Поля и константы'




        #region 'Свойства'

        public List<(string FileName, bool IsChecked)> SongsCollection
        {
            get => _songsCollection;
        }
        public int GameDuration { get; set; }
        public int SongDuration { get; set; }
        public int VolumeLevel { get; set; }
        public string LastFolder { get; set; }
        /// <summary>
        /// Будет ли использоваться случайная позиция при старте песни (True)
        /// </summary>
        public bool IsRandomStart { get; set; }
        public bool IsSubfolderScan { get; internal set; } = true;
        public bool IsDeleteUnexisting { get; internal set; } = true;

        #endregion 'Свойства'



        private ProgOptions() { }

        /// <summary>
        /// Синглтон настроек
        /// </summary>
        public static ProgOptions Instance
        {
            get
            {
                lock (_locker)
                {
                    if (_instanse == null)
                    {
                        lock (_locker)
                        {
                            _instanse = new ProgOptions()
                            {
                                SongDuration = DEFAULT_SONG_DURATION,
                                GameDuration = DEFAULT_GAME_DURATION
                            };
                        }
                    }
                }
                return _instanse;
            }
        }        

        /// <summary>
        /// Метод асинхронной загрузки настроек из файла
        /// </summary>
        public Task LoadAsync()
        {
            void Load()
            {
                int duration = 0;
                // это скореее всего нужно, если мы хотим перезагружать настройки программы без её перезапуска
                //var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);

                if (Int32.TryParse(ConfigurationManager.AppSettings.Get(nameof(GameDuration)), out duration))
                {
                    GameDuration = duration;
                }
                if (Int32.TryParse(ConfigurationManager.AppSettings.Get(nameof(SongDuration)), out duration))
                {
                    SongDuration = duration;
                }
                bool flag = false;
                if (bool.TryParse(ConfigurationManager.AppSettings.Get(nameof(IsRandomStart)), out flag))
                {
                    IsRandomStart = flag;
                }
                if (bool.TryParse(ConfigurationManager.AppSettings.Get(nameof(IsSubfolderScan)), out flag))
                {
                    IsSubfolderScan = flag;
                }
                if (bool.TryParse(ConfigurationManager.AppSettings.Get(nameof(IsDeleteUnexisting)), out flag))
                {
                    IsDeleteUnexisting = flag;
                }
                if (Int32.TryParse(ConfigurationManager.AppSettings.Get(nameof(VolumeLevel)), out duration))
                {
                    VolumeLevel = duration;
                }
                else
                {
                    VolumeLevel = DEFAULT_VOLUME_LEVEL;
                }

                LastFolder = ConfigurationManager.AppSettings.Get(nameof(LastFolder));
                
                if (String.IsNullOrWhiteSpace(LastFolder) || !Directory.Exists(LastFolder))
                {
                    try
                    {
                        LastFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
                    }
                    catch (Exception ex)
                    {
                        Trace.TraceWarning("Вероятно на ПК пользователя отсутствует каталог \"Моя музыка\" либо к нему нет доступа:{0}{1}",
                            Environment.NewLine, ex.Message);
                    }
                }

                // загружаем список песен - он хранится в отдельном файле
                var songsFileName = Path.Combine(Application.StartupPath, ProgOptions.SONGS_LIST_FILE_NAME);
                if (File.Exists(songsFileName) && ((new FileInfo(songsFileName)).Length > 0))
                {
                    using (var sf = File.OpenRead(songsFileName))
                    {
                        _songsCollection = (_songsListSerializer.Deserialize(sf) as List<(string, bool)>);
                    }
                    // помечаем ненайденные треки как Неиспользуемые
                    if (IsDeleteUnexisting)
                    {
                        for (int i = 0; i < _songsCollection.Count; i++)
                        {
                            var songItem = _songsCollection[i];
                            if (!File.Exists(songItem.FileName))
                            {
                                songItem.IsChecked = false;
                            }
                        }
                    }
                }
            }

            return Task.Run(Load);
        }

        /// <summary>
        /// Метоод асинхронного сохранения настроек программы
        /// </summary>
        /// <returns></returns>
        public Task SaveAsync()
        {            
            void Save()
            {
                ConfigurationManager.AppSettings.Set(nameof(GameDuration), GameDuration.ToString());
                ConfigurationManager.AppSettings.Set(nameof(SongDuration), SongDuration.ToString());
                ConfigurationManager.AppSettings.Set(nameof(IsRandomStart), IsRandomStart.ToString());
                ConfigurationManager.AppSettings.Set(nameof(IsSubfolderScan), IsSubfolderScan.ToString());
                ConfigurationManager.AppSettings.Set(nameof(IsDeleteUnexisting), IsDeleteUnexisting.ToString());
                ConfigurationManager.AppSettings.Set(nameof(LastFolder), LastFolder);
                ConfigurationManager.AppSettings.Set(nameof(VolumeLevel), VolumeLevel.ToString());

                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                foreach (var key in ConfigurationManager.AppSettings.AllKeys)
                {
                    var existedKey = configFile.AppSettings.Settings[key];
                    if (existedKey != null)
                    {
                        existedKey.Value = ConfigurationManager.AppSettings[key];
                    }
                    else
                    {
                        configFile.AppSettings.Settings.Add(key, ConfigurationManager.AppSettings[key]);
                    }
                }
                configFile.Save();

                // сохраяем список песен - он хранится в отдельном файле (в общем-то из-за этого метод и асинхронный)                
                using (var of = File.OpenWrite(Path.Combine(Application.StartupPath, ProgOptions.SONGS_LIST_FILE_NAME)))
                {
                    of.SetLength(0);
                    _songsListSerializer.Serialize(of, _songsCollection);
                }
            }

            return Task.Run(Save);
        }


    }
}
