using System;
using System.Collections.ObjectModel;
using System.Text.Json;
using KeyBinderV1.Model;
using System.IO;
using KeyBinderV1.View;
using System.Windows;
using System.Windows.Input;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Windows.Controls;

namespace KeyBinderV1.ViewModel
{
    public class BindManager : ViewModelBase
    {
        #region Prop and constructor
        private ObservableCollection<BindInfo> _binds;

        public ObservableCollection<BindInfo> Binds
        {
            get
            {
                return _binds;
            }
            set
            {
                _binds = value;
                OnPropertyChanged(nameof(Binds));
            }
        }

        public BindManager()
        {
            LoadBinds("save.json");
        }
        #endregion
        #region Work with files
        public ObservableCollection<BindInfo> LoadBinds(string filePath)
        {
            try
            {
                string jsonText = File.ReadAllText(filePath);

                List<BindInfoDto> bindDtoList = JsonSerializer.Deserialize<List<BindInfoDto>>(jsonText);

                ObservableCollection<BindInfo> binds = new ObservableCollection<BindInfo>();

                foreach (var dto in bindDtoList)
                {
                    binds.Add(new BindInfo
                    {
                        Name = dto.Name,
                        Action = dto.Action,
                        Key = ParseKey(dto.Key)
                    });
                }
                Binds = binds;
                return binds;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при загрузке из файла JSON: {ex.Message}");
                return new ObservableCollection<BindInfo>();
            }
        }
        private Key ParseKey(string keyString)
        {
            if (Enum.TryParse<Key>(keyString, out Key result))
            {
                return result;
            }
            else
            {
                return Key.None;
            }
        }

        public void SaveBinds(string filePath)
        {
            try
            {
                string jsonText = JsonSerializer.Serialize(this);

                File.WriteAllText(filePath, jsonText);

                Console.WriteLine($"Данные успешно сохранены в файл: {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при сохранении в файл JSON: {ex.Message}");
            }
        }
        #endregion
        #region Forms
        // bind constructor request
        private RelayCommand openBindContructorWindow;
        public RelayCommand OpenBindContructorWindow
        {
            get
            {
                return openBindContructorWindow ?? new RelayCommand(obj =>
                    {
                        BindConstructorWindow();
                    }
                );
            }
        }


        private void BindConstructorWindow()
        {
            BindConstructor newBindConstructor = new BindConstructor();
            newBindConstructor.Owner = Application.Current.MainWindow;
            newBindConstructor.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            newBindConstructor.ShowDialog();
        }
        #endregion
        #region Work with objects on main form
        private BindInfo _selectedBind;
        public BindInfo SelectedBind
        {
            get { return _selectedBind; }
            set
            {
                _selectedBind = value;
                OnPropertyChanged(nameof(SelectedBind));
            }
        }
        private RelayCommand setKeyForBind;
        public RelayCommand SetKeyForBind
        {
            get
            {
                return openBindContructorWindow ?? new RelayCommand(obj =>
                {
                    KeyForBindSetted(obj as string);
                }
                );
            }
        }
        private void KeyForBindSetted(string buttonText)
        {
            // реализовать изменение бинда
        }
        #endregion

        #region work with objects on Bind constructor form
        private ObservableCollection<string> _textBoxLines;

        public ObservableCollection<string> TextBoxLines
        {
            get 
            {
                if (_textBoxLines == null)
                {
                    _textBoxLines = new ObservableCollection<string>();
                }
                return _textBoxLines; 
            }
            set
            {
                _textBoxLines.Add(Convert.ToString(value));
                OnPropertyChanged(nameof(TextBoxLines));             
            }
        }

        private RelayCommand addDelayCom;
        private RelayCommand keyDownCom;
        private RelayCommand keyUpCom;

        public RelayCommand AddDelayCom
        {
            get
            {
                return addDelayCom ?? new RelayCommand(obj =>
                {
                    DelayButtonExecute();
                }
                );
            }
        }
        private void DelayButtonExecute() => TextBoxLines.Add("delay()");
        public RelayCommand KeyDownCom
        {
            get
            {
                return keyDownCom ?? new RelayCommand(obj =>
                {
                    DownButtonExecute();
                }
                );
            }
        }
        private void DownButtonExecute() => TextBoxLines.Add("down()");
        public RelayCommand KeyUpCom
        {
            get
            {
                return keyUpCom ?? new RelayCommand(obj =>
                {
                    UpButtonExecute();
                }
                );
            }
        }
        private void UpButtonExecute() => TextBoxLines.Add("up()");

        #endregion
    }
}
