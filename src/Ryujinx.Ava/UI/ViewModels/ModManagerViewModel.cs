using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Threading;
using DynamicData;
using Ryujinx.Ava.Common.Locale;
using Ryujinx.Ava.UI.Helpers;
using Ryujinx.Ava.UI.Models;
using Ryujinx.Common.Configuration;
using Ryujinx.Common.Logging;
using Ryujinx.Common.Utilities;
using Ryujinx.HLE.HOS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Ryujinx.Ava.UI.ViewModels
{
    public class ModManagerViewModel : BaseModel
    {
        public ModMetadata _modData;
        public readonly string _modJsonPath;

        public AvaloniaList<ModModel> _mods = new();
        public AvaloniaList<ModModel> _views = new();
        public AvaloniaList<ModModel> _selectedMods = new();

        private ulong _titleId { get; }
        private string _titleName { get; }

        private string _search;

        private static readonly ModMetadataJsonSerializerContext SerializerContext = new(JsonHelper.GetDefaultSerializerOptions());

        public AvaloniaList<ModModel> Mods
        {
            get => _mods;
            set
            {
                _mods = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ModCount));
                Sort();
            }
        }

        public AvaloniaList<ModModel> Views
        {
            get => _views;
            set
            {
                _views = value;
                OnPropertyChanged();
            }
        }

        public AvaloniaList<ModModel> SelectedMods
        {
            get => _selectedMods;
            set
            {
                _selectedMods = value;
                OnPropertyChanged();
            }
        }

        public string Search
        {
            get => _search;
            set
            {
                _search = value;
                OnPropertyChanged();
                Sort();
            }
        }

        public string ModCount
        {
            get => string.Format(LocaleManager.Instance[LocaleKeys.ModWindowHeading], Mods.Count);
        }

        public ModManagerViewModel(ulong titleId, string titleName)
        {
            _titleId = titleId;
            _titleName = titleName;

            _modJsonPath = Path.Combine(AppDataManager.GamesDirPath, titleId.ToString("x16"), "mods.json");

            try
            {
                _modData = JsonHelper.DeserializeFromFile(_modJsonPath, SerializerContext.ModMetadata);
            }
            catch
            {
                Logger.Warning?.Print(LogClass.Application, $"Failed to deserialize mod data for {_titleId} at {_modJsonPath}");

                _modData = new ModMetadata
                {
                    Mods = new List<Mod>()
                };

                Save();
            }

            LoadMods(titleId);
        }

        private void LoadMods(ulong titleId)
        {
            string modsBasePath = ModLoader.GetSdModsBasePath();

            var modCache = new ModLoader.ModCache();
            ModLoader.QueryContentsDir(modCache, new DirectoryInfo(Path.Combine(modsBasePath, "contents")), titleId);

            foreach (var mod in modCache.RomfsDirs)
            {
                var enabled = _modData.Mods.Exists(x => x.Path == mod.Path.FullName);
                Mods.Add(new ModModel(mod.Path.FullName, mod.Name, enabled));
            }

            foreach (var mod in modCache.RomfsContainers)
            {
                var enabled = _modData.Mods.Exists(x => x.Path == mod.Path.FullName);
                Mods.Add(new ModModel(mod.Path.FullName, mod.Name, enabled));
            }

            foreach (var mod in modCache.ExefsDirs)
            {
                var enabled = _modData.Mods.Exists(x => x.Path == mod.Path.FullName);
                Mods.Add(new ModModel(mod.Path.FullName, mod.Name, enabled));
            }

            foreach (var mod in modCache.ExefsContainers)
            {
                var enabled = _modData.Mods.Exists(x => x.Path == mod.Path.FullName);
                Mods.Add(new ModModel(mod.Path.FullName, mod.Name, enabled));
            }

            Sort();
        }

        public void Sort()
        {
            Mods.AsObservableChangeSet()
                .Filter(Filter)
                .Bind(out var view).AsObservableList();

            _views.Clear();
            _views.AddRange(view);
            OnPropertyChanged(nameof(ModCount));
        }

        private bool Filter(object arg)
        {
            if (arg is ModModel content)
            {
                return string.IsNullOrWhiteSpace(_search) || content.Name.ToLower().Contains(_search.ToLower());
            }

            return false;
        }

        public void Save()
        {
            _modData.Mods.Clear();

            foreach (ModModel mod in SelectedMods)
            {
                _modData.Mods.Add(new Mod
                {
                    Name = mod.Name,
                    Path = mod.Path,
                });
            }

            JsonHelper.SerializeToFile(_modJsonPath, _modData, SerializerContext.ModMetadata);
        }

        public void Remove(ModModel model)
        {
            Mods.Remove(model);
            OnPropertyChanged(nameof(ModCount));
            Sort();
        }

        private void AddMod(string directory)
        {
            if (Directory.Exists(directory) && Mods.All(x => !x.Path.Contains(directory)))
            {
                using FileStream file = new(directory, FileMode.Open, FileAccess.Read);

                try
                {

                }
                catch (Exception ex)
                {
                    Dispatcher.UIThread.Post(async () =>
                    {
                        await ContentDialogHelper.CreateErrorDialog(LocaleManager.Instance.UpdateAndGetDynamicValue(LocaleKeys.DialogLoadModErrorMessage, ex.Message, directory));
                    });
                }
            }
        }

        public async void Add()
        {
            OpenFolderDialog dialog = new()
            {
                Title = LocaleManager.Instance[LocaleKeys.SelectModDialogTitle]
            };

            if (Avalonia.Application.Current.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                string directory = await dialog.ShowAsync(desktop.MainWindow);

                if (directory != null)
                {
                    AddMod(directory);
                }
            }
        }

        public void RemoveAll()
        {
            Mods.Clear();
            OnPropertyChanged(nameof(ModCount));
            Sort();
        }

        public void EnableAll()
        {
            SelectedMods = new(Mods);
        }

        public void DisableAll()
        {
            SelectedMods.Clear();
        }
    }
}