using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Management.Automation.Runspaces;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Diagnostics;
using System.Security.Policy;
using Markdig.Extensions.Tables;
using Microsoft.ApplicationInsights.Extensibility.Implementation;

namespace Win_Tweaker
{
    public partial class Privacy : UserControl
    {
        public Privacy()
        {
            InitializeComponent();
        }

        private void Apply_BTN_Click(object sender, EventArgs e)
        {
            Runspace runspace = RunspaceFactory.CreateRunspace();
            runspace.Open();
            Pipeline pipeline = runspace.CreatePipeline();

            #region ScheduledTelemetry
            if (ScheduledTelemetry_CB.Checked == true)
            {
                ChangeScheduledTask("\\Microsoft\\Windows\\Application Experience", "StartupAppTask", "enable");
                ChangeScheduledTask("\\Microsoft\\Windows\\Application Experience", "PcaPatchDbTask", "enable");
                ChangeScheduledTask("\\Microsoft\\Windows\\Application Experience", "MareBackup", "enable");
                ChangeScheduledTask("\\Microsoft\\Windows\\Application Experience", "Microsoft Compatibility Appraiser", "enable");

                ChangeScheduledTask("\\Microsoft\\Windows\\Customer Experience Improvement Program", "Consolidator", "enable");
                ChangeScheduledTask("\\Microsoft\\Windows\\Customer Experience Improvement Program", "UsbCeip", "enable");

                ChangeScheduledTask("\\Microsoft\\Windows\\DiskDiagnostic", "Microsoft-Windows-DiskDiagnosticDataCollector", "enable");

                ChangeScheduledTask("\\Microsoft\\Windows\\Feedback\\Siuf", "DmClient", "enable");
                ChangeScheduledTask("\\Microsoft\\Windows\\Feedback\\Siuf", "DmClientOnScenarioDownload", "enable");

                ChangeScheduledTask("\\Microsoft\\Windows\\Maps", "MapsUpdateTask", "enable");
            }
            else if (ScheduledTelemetry_CB.Checked == false)
            {
                ChangeScheduledTask("\\Microsoft\\Windows\\Application Experience", "StartupAppTask", "disable");
                ChangeScheduledTask("\\Microsoft\\Windows\\Application Experience", "PcaPatchDbTask", "disable");
                ChangeScheduledTask("\\Microsoft\\Windows\\Application Experience", "MareBackup", "disable");
                ChangeScheduledTask("\\Microsoft\\Windows\\Application Experience", "Microsoft Compatibility Appraiser", "disable");

                ChangeScheduledTask("\\Microsoft\\Windows\\Customer Experience Improvement Program", "Consolidator", "disable");
                ChangeScheduledTask("\\Microsoft\\Windows\\Customer Experience Improvement Program", "UsbCeip", "disable");

                ChangeScheduledTask("\\Microsoft\\Windows\\DiskDiagnostic", "Microsoft-Windows-DiskDiagnosticDataCollector", "disable");

                ChangeScheduledTask("\\Microsoft\\Windows\\Feedback\\Siuf", "DmClient", "disable");
                ChangeScheduledTask("\\Microsoft\\Windows\\Feedback\\Siuf", "DmClientOnScenarioDownload", "disable");

                ChangeScheduledTask("\\Microsoft\\Windows\\Maps", "MapsUpdateTask", "disable");
            }
            #endregion

            #region DiagnosticData
            if (DiagnosticData_CB.Checked == true)
            {
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection", "AllowTelemetry", true, pipeline, "DWord", "1");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection", "DoNotShowFeedbackNotifications", false, pipeline, "DWord", "0");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection", "DisableOneSettingsDownloads", false, pipeline, "DWord", "0");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection", "AllowDesktopAnalyticsProcessing", false, pipeline, "DWord", "1");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection", "LimitEnhancedDiagnosticDataWindowsAnalytics", false, pipeline, "DWord", "0");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection", "AllowDeviceNameInTelemetry", false, pipeline, "DWord", "1");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection", "DisableTelemetryOptInChangeNotification", false, pipeline, "DWord", "0");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection", "DisableTelemetryOptInSettingsUx", false, pipeline, "DWord", "0");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection", "AllowWUfBCloudProcessing", false, pipeline, "DWord", "1");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection", "AllowUpdateComplianceProcessing", false, pipeline, "DWord", "1");

                ChangeRegKey("HKLM:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\DataCollection", "AllowTelemetry", true, pipeline, "DWord", "1");

                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\appDiagnostics", "Value", true, pipeline, "string", "Allow");

                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\System", "EnableActivityFeed", true, pipeline, "DWord", "1");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\System", "PublishUserActivities", false, pipeline, "DWord", "1");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\System", "UploadUserActivities", false, pipeline, "DWord", "1");
            }
            else if (DiagnosticData_CB.Checked == false)
            {
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection", "AllowTelemetry", true, pipeline, "DWord", "0");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection", "DoNotShowFeedbackNotifications", false, pipeline, "DWord", "1");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection", "DisableOneSettingsDownloads", false, pipeline, "DWord", "1");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection", "AllowDesktopAnalyticsProcessing", false, pipeline, "DWord", "0");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection", "LimitEnhancedDiagnosticDataWindowsAnalytics", false, pipeline, "DWord", "1");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection", "AllowDeviceNameInTelemetry", false, pipeline, "DWord", "0");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection", "DisableTelemetryOptInChangeNotification", false, pipeline, "DWord", "1");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection", "DisableTelemetryOptInSettingsUx", false, pipeline, "DWord", "1");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection", "AllowWUfBCloudProcessing", false, pipeline, "DWord", "0");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection", "AllowUpdateComplianceProcessing", false, pipeline, "DWord", "0");

                ChangeRegKey("HKLM:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\DataCollection", "AllowTelemetry", true, pipeline, "DWord", "0");

                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\appDiagnostics", "Value", true, pipeline, "string", "Deny");

                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\System", "EnableActivityFeed", true, pipeline, "DWord", "0");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\System", "PublishUserActivities", false, pipeline, "DWord", "0");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\System", "UploadUserActivities", false, pipeline, "DWord", "0");
            }
            #endregion

            #region ServicesTelemetry
            if (ServicesTel_CB.Checked == true)
            {
                try
                {
                    ChangeService("dmwappushservice", "Automatic", pipeline);
                    ChangeService("DiagTrack", "Automatic", pipeline);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error at applying Services telemetry: " + ex.Message);
                }
            }
            else if (ServicesTel_CB.Checked == false)
            {
                try
                {
                    ChangeService("dmwappushservice", "Disable", pipeline);
                    ChangeService("DiagTrack", "Disable", pipeline);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error at applying Services telemetry: " + ex.Message);
                }
            }
            #endregion

            #region TailoredExperiences&InkTypePersonalization
            if (TailoredExp_CB.Checked == true)
            {
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\Privacy", "TailoredExperiencesWithDiagnosticDataEnabled", true, pipeline, "DWord", "1");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\AdvertisingInfo", "Enabled", true, pipeline, "DWord", "1");

                ChangeRegKey("HKCU:\\Software\\Microsoft\\InputPersonalization", "RestrictImplicitInkCollection", true, pipeline, "DWord", "0");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\InputPersonalization", "RestrictImplicitTextCollection", false, pipeline, "DWord", "0");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\InputPersonalization\\TrainedDataStore", "HarvestContacts", true, pipeline, "DWord", "1");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Personalization\\Settings", "AcceptedPrivacyPolicy", true, pipeline, "DWord", "1");
            }
            else if (TailoredExp_CB.Checked == false)
            {
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\Privacy", "TailoredExperiencesWithDiagnosticDataEnabled", true, pipeline, "DWord", "0");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\AdvertisingInfo", "Enabled", true, pipeline, "DWord", "0");

                ChangeRegKey("HKCU:\\Software\\Microsoft\\InputPersonalization", "RestrictImplicitInkCollection", true, pipeline, "DWord", "1");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\InputPersonalization", "RestrictImplicitTextCollection", false, pipeline, "DWord", "1");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\InputPersonalization\\TrainedDataStore", "HarvestContacts", true, pipeline, "DWord", "0");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Personalization\\Settings", "AcceptedPrivacyPolicy", true, pipeline, "DWord", "0");
            }
            #endregion

            #region StartMenuTelemetry
            if (SMSuggestions_CB.Checked == true)
            {
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\CloudContent", "DisableCloudOptimizedContent", true, pipeline, "DWord", "0");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\CloudContent", "DisableConsumerAccountStateContent", false, pipeline, "DWord", "0");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\CloudContent", "DisableWindowsConsumerFeatures", false, pipeline, "DWord", "0");

                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "SystemPaneSuggestionsEnabled", true, pipeline, "DWord", "1");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "ContentDeliveryAllowed", true, pipeline, "DWord", "1");
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "SubscribedContent-338387Enabled", false, pipeline, "DWord", "1");
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "SubscribedContent-338388Enabled", false, pipeline, "DWord", "1");
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "SubscribedContent-338389Enabled", false, pipeline, "DWord", "1");
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "SubscribedContent-353698Enabled", false, pipeline, "DWord", "1");

                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Start_TrackDocs", true, pipeline, "DWord", "1");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Start_TrackProgs", false, pipeline, "DWord", "1");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Start_IrisRecommendations", false, pipeline, "DWord", "1");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Start_AccountNotifications", false, pipeline, "DWord", "1");

                ChangeRegKey("HKLM:\\Software\\Policies\\Microsoft\\Windows\\Explorer", "HideRecentlyAddedApps", false, pipeline, "DWord", "0");
                ChangeRegKey("HKLM:\\Software\\Policies\\Microsoft\\Windows\\Explorer", "ShowOrHideMostUsedApps", false, pipeline, "DWord", "0");
            }
            else if (SMSuggestions_CB.Checked == false)
            {
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\CloudContent", "DisableCloudOptimizedContent", true, pipeline, "DWord", "1");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\CloudContent", "DisableConsumerAccountStateContent", false, pipeline, "DWord", "1");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\CloudContent", "DisableWindowsConsumerFeatures", false, pipeline, "DWord", "1");

                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "SystemPaneSuggestionsEnabled", true, pipeline, "DWord", "0");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "ContentDeliveryAllowed", true, pipeline, "DWord", "0");
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "SubscribedContent-338387Enabled", false, pipeline, "DWord", "0");
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "SubscribedContent-338388Enabled", false, pipeline, "DWord", "0");
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "SubscribedContent-338389Enabled", false, pipeline, "DWord", "0");
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "SubscribedContent-353698Enabled", false, pipeline, "DWord", "0");

                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Start_TrackDocs", true, pipeline, "DWord", "0");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Start_TrackProgs", false, pipeline, "DWord", "0");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Start_IrisRecommendations", false, pipeline, "DWord", "0");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Start_AccountNotifications", false, pipeline, "DWord", "0");

                ChangeRegKey("HKLM:\\Software\\Policies\\Microsoft\\Windows\\Explorer", "HideRecentlyAddedApps", false, pipeline, "DWord", "1");
                ChangeRegKey("HKLM:\\Software\\Policies\\Microsoft\\Windows\\Explorer", "ShowOrHideMostUsedApps", false, pipeline, "DWord", "2");
            }
            #endregion

            #region Cortana&Search
            if (Cortana_CB.Checked == false)
            {
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "AllowCloudSearch", true, pipeline, "DWord", "0");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "AllowCortana", false, pipeline, "DWord", "0");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "AllowSearchToUseLocation", false, pipeline, "DWord", "0");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "AllowCortanaAboveLock", false, pipeline, "DWord", "0");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "ConnectedSearchUseWeb", false, pipeline, "DWord", "0");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "DisableWebSearch", false, pipeline, "DWord", "1");

                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Cortana", "IsAvailable", true, pipeline, "DWord", "0");

                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Windows Search", "CortanaConsent", true, pipeline, "DWord", "0");
            }
            else if (Cortana_CB.Checked == true)
            {
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "AllowCloudSearch", true, pipeline, "DWord", "1");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "AllowCortana", false, pipeline, "DWord", "1");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "AllowSearchToUseLocation", false, pipeline, "DWord", "1");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "AllowCortanaAboveLock", false, pipeline, "DWord", "1");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "ConnectedSearchUseWeb", false, pipeline, "DWord", "1");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "DisableWebSearch", false, pipeline, "DWord", "0");

                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Cortana", "IsAvailable", true, pipeline, "DWord", "1");

                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Windows Search", "CortanaConsent", true, pipeline, "DWord", "1");
            }
            #endregion

            #region ExtraTelemetry
            if (ExtraTel_CB.Checked == true)
            {
                ChangeRegKey("HKLM:\\SOFTWARE\\Microsoft\\Windows\\Windows Error Reporting", "Disabled", true, pipeline, "DWord", "0");
                ChangeRegKey("HKLM:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\DeliveryOptimization\\Config", "DODownloadMode", true, pipeline, "DWord", "0");
                ChangeRegKey("HKLM:\\SYSTEM\\CurrentControlSet\\Control\\Remote Assistance", "fAllowToGetHelp", true, pipeline, "DWord", "1");
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\OperationStatusManager", "EnthusiastMode", true, pipeline, "DWord", "0");
                ChangeRegKey("HKLM:\\SYSTEM\\CurrentControlSet\\Control\\FileSystem", "LongPathsEnabled", true, pipeline, "DWord", "0");
                ChangeRegKey("HKLM:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\DriverSearching", "SearchOrderConfig", true, pipeline, "DWord", "0");
                ChangeRegKey("HKCU:\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Feeds", "EnableFeeds", true, pipeline, "DWord", "1");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\Feeds", "ShellFeedsTaskbarViewMode", true, pipeline, "DWord", "0");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "HideSCAMeetNow", true, pipeline, "DWord", "0");

                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "SubscribedContent-338393Enabled", true, pipeline, "DWord", "1");
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", " SubscribedContent-353694Enabled", false, pipeline, "DWord", "1");
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", " SubscribedContent-353696Enabled", false, pipeline, "DWord", "1");

                ChangeRegKey("HKCU:\\Control Panel\\International\\User Profile", "HttpAcceptLanguageOptOut", true, pipeline, "DWord", "0");

                ChangeRegKey("HKCU:\\Software\\Policies\\Microsoft\\Windows\\EdgeUI", "DisableMFUTracking", true, pipeline, "DWord", "0");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\EdgeUI", "DisableMFUTracking", true, pipeline, "DWord", "0");
            }
            else if (ExtraTel_CB.Checked == false)
            {
                ChangeRegKey("HKLM:\\SOFTWARE\\Microsoft\\Windows\\Windows Error Reporting", "Disabled", true, pipeline, "DWord", "1");
                ChangeRegKey("HKLM:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\DeliveryOptimization\\Config", "DODownloadMode", true, pipeline, "DWord", "1");
                ChangeRegKey("HKLM:\\SYSTEM\\CurrentControlSet\\Control\\Remote Assistance", "fAllowToGetHelp", true, pipeline, "DWord", "0");
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\OperationStatusManager", "EnthusiastMode", true, pipeline, "DWord", "1");
                ChangeRegKey("HKLM:\\SYSTEM\\CurrentControlSet\\Control\\FileSystem", "LongPathsEnabled", true, pipeline, "DWord", "1");
                ChangeRegKey("HKLM:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\DriverSearching", "SearchOrderConfig", true, pipeline, "DWord", "1");
                ChangeRegKey("HKLM:\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "ClearPageFileAtShutdown", true, pipeline, "DWord", "0");
                ChangeRegKey("HKCU:\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Feeds", "EnableFeeds", true, pipeline, "DWord", "0");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\Feeds", "ShellFeedsTaskbarViewMode", true, pipeline, "DWord", "2");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "HideSCAMeetNow", true, pipeline, "DWord", "1");
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Siuf\\Rules", "NumberOfSIUFInPeriod", true, pipeline, "DWord", "0");
                ChangeRegKey("HKLM:\\SYSTEM\\CurrentControlSet\\Services\\LanmanServer\\Parameters", "IRPStackSize", true, pipeline, "DWord", "1e");

                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "SubscribedContent-338393Enabled", true, pipeline, "DWord", "0");
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "SubscribedContent-353694Enabled", false, pipeline, "DWord", "0");
                ChangeRegKey("HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ContentDeliveryManager", "SubscribedContent-353696Enabled", false, pipeline, "DWord", "0");

                ChangeRegKey("HKCU:\\Control Panel\\International\\User Profile", "HttpAcceptLanguageOptOut", true, pipeline, "DWord", "1");

                ChangeRegKey("HKCU:\\Software\\Policies\\Microsoft\\Windows\\EdgeUI", "DisableMFUTracking", true, pipeline, "DWord", "1");
                ChangeRegKey("HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\EdgeUI", "DisableMFUTracking", true, pipeline, "DWord", "1");
            }
            #endregion

            #region LocationCameraMicrophone
            if (AccessToPhoneMic_DD.SelectedItem == "Microphone and Camera (Recommended)")
            {
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\activity", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\location", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\appDiagnostics", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\webcam", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\microphone", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\userNotificationListener", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\userAccountInformation", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\contacts", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\appointments", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\phoneCallHistory", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\email", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\userDataTasks", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\chat", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\radios", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\bluetoothSync", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\documentsLibrary", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\picturesLibrary", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\videosLibrary", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\broadFileSystemAccess", "Value", true, pipeline, "string", "Deny");

                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\bluetooth", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\cellularData", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\gazeInput", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\graphicsCaptureWithoutBorder", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\humanInterfaceDevice", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\musicLibrary", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\phoneCall", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\sensors.custom", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\serialCommunication", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\usb", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\wifiData", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\wiFiDirect", "Value", true, pipeline, "string", "Deny");
            }
            else if (AccessToPhoneMic_DD.SelectedItem == "All (default)")
            {
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\activity", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\location", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\appDiagnostics", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\webcam", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\microphone", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\userNotificationListener", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\userAccountInformation", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\contacts", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\appointments", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\phoneCallHistory", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\email", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\userDataTasks", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\chat", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\radios", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\bluetoothSync", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\documentsLibrary", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\picturesLibrary", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\videosLibrary", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\broadFileSystemAccess", "Value", true, pipeline, "string", "Allow");

                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\bluetooth", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\cellularData", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\gazeInput", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\graphicsCaptureWithoutBorder", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\humanInterfaceDevice", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\musicLibrary", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\phoneCall", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\sensors.custom", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\serialCommunication", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\usb", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\wifiData", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\wiFiDirect", "Value", true, pipeline, "string", "Allow");
            }
            else if (AccessToPhoneMic_DD.SelectedItem == "Microphone, Camera, Location, Calendar and Email")
            {
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\activity", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\location", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\appDiagnostics", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\webcam", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\microphone", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\userNotificationListener", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\userAccountInformation", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\contacts", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\appointments", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\phoneCallHistory", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\email", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\userDataTasks", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\chat", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\radios", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\bluetoothSync", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\documentsLibrary", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\picturesLibrary", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\videosLibrary", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\broadFileSystemAccess", "Value", true, pipeline, "string", "Deny");

                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\bluetooth", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\cellularData", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\gazeInput", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\graphicsCaptureWithoutBorder", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\humanInterfaceDevice", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\musicLibrary", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\phoneCall", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\sensors.custom", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\serialCommunication", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\usb", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\wifiData", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\wiFiDirect", "Value", true, pipeline, "string", "Deny");
            }
            else if (AccessToPhoneMic_DD.SelectedItem == "Microphone, Camera, Location, Calendar, Email, Bluetooth, Cellular Data and Phone")
            {
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\activity", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\location", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\appDiagnostics", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\webcam", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\microphone", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\userNotificationListener", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\userAccountInformation", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\contacts", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\appointments", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\phoneCallHistory", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\email", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\userDataTasks", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\chat", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\radios", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\bluetoothSync", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\documentsLibrary", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\picturesLibrary", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\videosLibrary", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\broadFileSystemAccess", "Value", true, pipeline, "string", "Deny");

                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\bluetooth", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\cellularData", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\gazeInput", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\graphicsCaptureWithoutBorder", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\humanInterfaceDevice", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\musicLibrary", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\phoneCall", "Value", true, pipeline, "string", "Allow");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\sensors.custom", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\serialCommunication", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\usb", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\wifiData", "Value", true, pipeline, "string", "Deny");
                ChangeRegKey("HKCU:\\Software\\Microsoft\\Windows\\CurrentVersion\\CapabilityAccessManager\\ConsentStore\\wiFiDirect", "Value", true, pipeline, "string", "Deny");
            }
            #endregion

            pipeline.Invoke();
            runspace.Close();

            MessageBox.Show("PRIVACY tweaks successfuly applied");
        }

        private static void ChangeRegKey(string path, string valueName, bool forcePath, Pipeline pipeline, string valueType, string value)
        {
            if (forcePath)
            {
                pipeline.Commands.AddScript($@"if (-not (Test-Path '{path}')) {{New-Item -Path '{path}' -Force}}");
            }

            if (valueType.ToLower() == "string")
            {
                pipeline.Commands.AddScript($"Set-ItemProperty -Path '{path}' -Name '{valueName}' -Value '{value}'");
            }
            else
            {
                pipeline.Commands.AddScript($"Set-ItemProperty -Path '{path}' -Name '{valueName}' -Value '{value}' -Type {valueType}");
            }
        }
        private static void ChangeScheduledTask(string path, string name, string value)
        {
            Process.Start("schtasks.exe", $"/Change /TN \"{path}\\{name}\" /{value}");
        }
        private static void ChangeService(string name, string statusType, Pipeline pipeline)
        {
            pipeline.Commands.AddScript($@"Set-Service -name '{name}' -startupType '{statusType}'");
        }


        private void ResetToDefault(object sender, EventArgs e)
        {
            DiagnosticData_CB.Checked = true;
            ScheduledTelemetry_CB.Checked = true;
            TailoredExp_CB.Checked = true;
            SMSuggestions_CB.Checked = true;
            Cortana_CB.Checked = true;
            ServicesTel_CB.Checked = true;
            ExtraTel_CB.Checked = true;
            AccessToPhoneMic_DD.SelectedItem = "All (default)";
        }
    }
}