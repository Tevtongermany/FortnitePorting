using FortnitePorting.Application;
using FortnitePorting.Shared.Framework;
using FortnitePorting.ViewModels.Settings;

namespace FortnitePorting.Views.Settings;

public partial class UnrealSettingsView : ViewBase<UnrealSettingsViewModel>
{
    public UnrealSettingsView() : base(AppSettings.Current.ExportSettings.Unreal)
    {
        InitializeComponent();
    }
}