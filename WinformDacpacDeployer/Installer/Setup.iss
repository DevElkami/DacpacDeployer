#define MyAppName "Dacpac deployer"
#define MyAppVersion "2.0.0.0"
#define MyAppPublisher "DevElkami"
#define MyAppURL "https://github.com/DevElkami/DacpacDeployer"
#define MyAppDescription "Dacpac deployer"
#define MyAppCopyright "(c) 2023, DevElkami. See LICENSE.TXT for details."

[Setup]
AppId={{f488da5a-9588-4672-81fe-9f7232807e4b}}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
DefaultGroupName={#MyAppName}
DisableProgramGroupPage=yes
LicenseFile=..\..\LICENSE
OutputBaseFilename=dacpac-deployer-{#MyAppVersion}
Compression=none
SolidCompression=yes
VersionInfoVersion={#MyAppVersion}
VersionInfoDescription={#MyAppDescription}
VersionInfoTextVersion={#MyAppVersion}
ArchitecturesInstallIn64BitMode=x64
VersionInfoCopyright={#MyAppCopyright}
DisableReadyMemo=yes
AlwaysShowComponentsList=no
DisableReadyPage=yes
CloseApplications=no
OutputDir=Output
MinVersion=6.1sp1
PrivilegesRequiredOverridesAllowed=dialog
WizardStyle=modern

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}";

[Files]
Source: ..\bin\Release\net7.0-windows7.0\publish\WinformDacpacDeployer.exe; DestDir: {app}; Flags: ignoreversion overwritereadonly uninsremovereadonly;
Source: ..\bin\Release\net7.0-windows7.0\publish\*.dll; DestDir: {app}; Flags: ignoreversion overwritereadonly uninsremovereadonly;
Source: ..\..\LICENSE; DestDir: {app}; Flags: overwritereadonly uninsremovereadonly; DestName: LICENSE.TXT

[Icons]
Name: {group}\Dacpac deployer; Filename: {app}\WinformDacpacDeployer.exe; Flags: excludefromshowinnewinstall
Name: "{userdesktop}\{#MyAppName}"; Filename: "{app}\WinformDacpacDeployer.exe"; Tasks: desktopicon