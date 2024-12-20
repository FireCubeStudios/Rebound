﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebound.Languages;
public class StringTable
{
    // Get the current culture (language) of the system
    private static string currentCulture = CultureInfo.CurrentUICulture.Name.ToLower();

    // Home page
    public static string Title;
    public static string Description;
    public static string IviriusTextEditorDesc;
    public static string IviriusTextEditorPlusDesc;
    public static string ReboundItemDesc;
    public static string CrimsonDesc;
    public static string Docs;
    public static string DocsDesc;
    public static string DiscordServer;
    public static string DiscordServerDesc;
    public static string AppDocs;
    public static string ControlPanel;
    public static string ControlPanelDesc;
    public static string Defrag;
    public static string DefragDesc;
    public static string Cleanup;
    public static string CleanupDesc;
    public static string EventViewer;
    public static string EventViewerDesc;
    public static string FilesDesc;
    public static string Files3rd;
    public static string IviriusTextEditorDocsDesc;
    public static string Keyboard;
    public static string KeyboardDesc;
    public static string Run;
    public static string RunDesc;
    public static string Tasks;
    public static string TasksDesc;
    public static string TPM;
    public static string TPMDesc;
    public static string WinverDesc;

    // Rebound 11 page
    public static string ReboundDesc;
    public static string ReboundGetStarted;
    public static string ReboundGetStartedDesc;
    public static string ReboundWinUI3;
    public static string ReboundWinUI3Desc;
    public static string ReboundWinUpdates;
    public static string ReboundWinUpdatesDesc;
    public static string ReboundUpdates;
    public static string ReboundUpdatesDesc;
    public static string ReboundGithubDesc;
    public static string ReboundNewUpdateAvail;
    public static string ReboundUpdateDownload;
    public static string ReboundInstalled;
    public static string ReboundUninstall;
    public static string ReboundFullUninstall;
    public static string ReboundUninstallTooltip;
    public static string ReboundFullUninstallTooltip;
    public static string ReboundPatchOrUpdate;
    public static string ReboundPatchOrUpdateInfoBar;
    public static string ReboundNotInstalled;
    public static string ReboundInstallHere;
    public static string ReboundInstall;
    public static string ReboundConfigureInst;
    public static string ReboundChooseApps;
    public static string ReboundInstall11;
    public static string ReboundTemplateLight;
    public static string ReboundTemplateRecommended;
    public static string ReboundTemplateFull;
    public static string ReboundFilesCheck;
    public static string ReboundFilesBar;
    public static string ReboundRemoteDesktopCheck;
    public static string ReboundRunCheck;
    public static string ReboundStepsRecorder;
    public static string ReboundKeepOriginalWordPad;
    public static string ReboundTextEditor;
    public static string ReboundTextEditorPlus;
    public static string ReboundTextEditorPlusWarn;
    public static string ReboundCharMap;
    public static string ReboundMobilityCenter;
    public static string ReboundPresentationSettings;
    public static string ReboundStickyKeys;
    public static string ReboundVolMixer;
    public static string ReboundSysTools;
    public static string ReboundAuthManager;
    public static string ReboundCertManager;
    public static string ReboundControlPanel;
    public static string ReboundMSRT;
    public static string ReboundMemoryDebug;
    public static string ReboundPrintManagement;
    public static string ReboundRegistryEditor;
    public static string ReboundServices;
    public static string ReboundSysConf;
    public static string ReboundSysInfo;
    public static string ReboundSysRestore;
    public static string ReboundTPMmanagement;
    public static string ReboundUAC;
    public static string ReboundAccountManager;
    public static string ReboundFirewall;
    public static string ReboundAdditionalSoft;
    public static string ReboundReadDisclaimer;
    public static string ReboundInstallation;
    public static string ReboundDisclaimer;
    public static string ReboundText1;
    public static string ReboundNoGlitches;
    public static string ReboundText2;
    public static string ReboundReplacingOldUiControls;
    public static string ReboundText3;
    public static string ReboundOld;
    public static string ReboundNew;
    public static string ReboundViewMore;
    public static string ReboundTextTitle4;
    public static string ReboundText4;
    public static string ReboundNewALPHA;
    public static string ReboundNewALPHAwarn;
    public static string ReboundNewDEV;
    public static string ReboundNewDEVwarn;
    public static string ReboundNewBETA;
    public static string ReboundNewBETAwarn;
    public static string ReboundNewUpdate;
    public static string ReboundError;

    public static string ShellPageHome;
    public static string ShellPageControl;
    public static string ShellPageLegalTerms;

    public static void LoadStrings()
    {
        switch (currentCulture)
        {
            case "en-us":
                Title = "This is Ivirius";
                Description = "We made apps and tools for you to have the best experience with Windows 11.";
                IviriusTextEditorDesc = "Fluent WordPad app for Windows 10 and 11.";
                IviriusTextEditorPlusDesc = "Fluent WordPad app with advanced features and beautiful UI.";
                ReboundItemDesc = "The first WinUI 3 Windows mod that aims to bring consistency to the OS.";
                CrimsonDesc = "Add a little bit of light to your Windows build using CrimsonUI.";
                Docs = "Docs";
                DocsDesc = "Learn more about how to use Ivirius apps and contribute to projects.";
                DiscordServer = "Discord server";
                DiscordServerDesc = "Invite link to our Discord server.";
                AppDocs = "Rebound 11 apps docs";
                ControlPanel = "Control Panel";
                ControlPanelDesc = "Manage system settings and configurations";
                Defrag = "Defragment and Optimize Drives";
                DefragDesc = "Optimize and defragment your drives";
                Cleanup = "Disk Cleanup";
                CleanupDesc = "Free up space by removing unnecessary files";
                EventViewer = "Event Viewer";
                EventViewerDesc = "View detailed logs of system events";
                FilesDesc = "Modern file explorer for Windows 11";
                Files3rd = "3rd Party";
                IviriusTextEditorDocsDesc = "Modern WordPad app for Windows 11";
                Keyboard = "On-Screen Keyboard";
                KeyboardDesc = "Access a virtual keyboard on screen";
                Run = "Run";
                RunDesc = "Quickly launch programs or commands";
                Tasks = "Task Scheduler";
                TasksDesc = "Automate tasks on your PC";
                TPM = "TPM";
                TPMDesc = "Manage the Trusted Platform Module";
                WinverDesc = "View details about your Windows version";

                ReboundDesc = "Windows 11 made consistent. Featuring WinUI 3 apps for your everyday tasks.";
                ReboundGetStarted = "Get Started";
                ReboundGetStartedDesc = "See a short guide on how to install and use Rebound 11.";
                ReboundWinUI3 = "WinUI 3 apps";
                ReboundWinUI3Desc = "Rebound 11 uses WinUI 3 apps instead of .msstyles files to make Windows 11 truly consistent.";
                ReboundWinUpdates = "Windows updates";
                ReboundWinUpdatesDesc = "Rebound 11 does not block Windows updates.";
                ReboundUpdates = "Rebound 11 updates";
                ReboundUpdatesDesc = "All Rebound 11 updates are done through the Rebound Hub.";
                ReboundGithubDesc = "See the project details on GitHub.";
                ReboundNewUpdateAvail = "A new update for Rebound 11 is available!";
                ReboundUpdateDownload = "Download";
                ReboundInstalled = "Rebound 11 is installed.";
                ReboundUninstall = "Uninstall";
                ReboundFullUninstall = "Full Uninstall";
                ReboundUninstallTooltip = "Uninstall Rebound 11 apps and files.";
                ReboundFullUninstallTooltip = "Uninstall Rebound 11 apps, files, and associated apps (for example: Files App).";
                ReboundPatchOrUpdate = "Patch or Update";
                ReboundPatchOrUpdateInfoBar = "If you just downloaded a new version of Rebound Hub, please update Rebound 11 as well.";
                ReboundNotInstalled = "Rebound 11 is not installed.";
                ReboundInstallHere = "You can install Rebound 11 here.";
                ReboundInstall = "Install";
                ReboundConfigureInst = "Configure Rebound 11 Installation";
                ReboundChooseApps = "Choose the apps you would like to install.";
                ReboundInstall11 = "Install Rebound 11";
                ReboundTemplateLight = "☁️ Lightweight";
                ReboundTemplateRecommended = "✨ Recommended";
                ReboundTemplateFull = "⚙️ Full";
                ReboundFilesCheck = "File Explorer (Files - 3rd party)";
                ReboundFilesBar = "Files will not be uninstalled by Rebound Hub and you will have to uninstall it manually.";
                ReboundRemoteDesktopCheck = "Remote Desktop";
                ReboundRunCheck = "Run";
                ReboundStepsRecorder = "Steps Recorder";
                ReboundKeepOriginalWordPad = "Keep original";
                ReboundTextEditor = "Ivirius Text Editor (partial launch support)";
                ReboundTextEditorPlus = "Ivirius Text Editor Plus (recommended)";
                ReboundTextEditorPlusWarn = "You must have a valid copy of Ivirius Text Editor installed on your PC to set it as the default Rebound 11 WordPad replacement. Consider purchasing Ivirius Text Editor Plus and installing this option later if you haven't already.";
                ReboundCharMap = "Character Map";
                ReboundMobilityCenter = "Mobility Center (All devices)";
                ReboundPresentationSettings = "Presentation Settings (All devices)";
                ReboundStickyKeys = "Sticky Keys and Filter keys";
                ReboundVolMixer = "Volume Mixer (sndvol.exe)";
                ReboundSysTools = "System Tools";
                ReboundAuthManager = "Authorization Manager";
                ReboundCertManager = "Certificate Manager";
                ReboundControlPanel = "Control Panel - You cannot disable this option.";
                ReboundMSRT = "Malicious Software Removal Tool";
                ReboundMemoryDebug = "Memory Diagnostic";
                ReboundPrintManagement = "Print Management";
                ReboundRegistryEditor = "Registry Editor (Registry Editor Valley - 3rd party)";
                ReboundServices = "Services";
                ReboundSysConf = "System Configuration";
                ReboundSysInfo = "System Information";
                ReboundSysRestore = "System Restore";
                ReboundTPMmanagement = "TPM Management";
                ReboundUAC = "User Account Control settings";
                ReboundAccountManager = "User Account Manager";
                ReboundFirewall = "Windows Defender Firewall";
                ReboundAdditionalSoft = "Additional software";
                ReboundInstallation = "Installation";
                ReboundReadDisclaimer = "Before you proceed, please read the following disclaimer:";
                ReboundDisclaimer = "Rebound 11 is not a Windows mod. By clicking Install, Rebound 11 will replace shortcuts to system apps and install the required packages and certificates. All changes can be reverted after the installation is finished. Do not shut down your computer or close the installer to prevent damaging your PC. Rebound 11 does not modify Windows and will install standalone WinUI 3 apps to modernize your system instead of replacing system files. Ivirius is not responsible for any damages caused to your computer. The risk of damaging your PC is very low, but as with any software, still existent. Every Win32 app will still be available to use if Rebound 11 does not work properly. No system restore points are required to revert the changes. Rebound Hub will stop explorer.exe and restart it after the installation process is finished. Please save your work before proceeding.";
                ReboundText1 = "Rebound 11 replaces the start menu shortcuts of legacy Win32 apps with modern WinUI 3 tools. We made sure to fix as many bugs as we could to make your experience with Rebound 11 the best.";
                ReboundNoGlitches = "No visual glitches.";
                ReboundText2 = "Rebound 11 fixes the well-known maximize button hover alignment issue on all modernized apps.";
                ReboundReplacingOldUiControls = "Replacing old UI controls.";
                ReboundText3 = "Rebound 11 replaces old UI controls in the new apps and uses WinUI 3 standard controls.";
                ReboundOld = "Old";
                ReboundNew = "New";
                ReboundViewMore = "View more";
                ReboundTextTitle4 = "Make Windows 11 consistent without risks.";
                ReboundText4 = "Modernize Windows 11 with actual WinUI 3 apps, as intended by Microsoft. Rebound 11 keeps Windows updates enabled, does not modify the system, and aims to be as consistent as possible without changing system files.";
                ReboundNewALPHA = "A new ALPHA release is available for Rebound Hub and Rebound 11! (New version: ";
                ReboundNewALPHAwarn = "Note: ALPHA versions can be unstable.";
                ReboundNewDEV = "A new DEV release is available for Rebound Hub and Rebound 11! (New version: ";
                ReboundNewDEVwarn = "Note: DEV versions can be unstable.";
                ReboundNewBETA = "A new BETA release is available for Rebound Hub and Rebound 11! (New version: ";
                ReboundNewBETAwarn = "Note: BETA versions can be unstable.";
                ReboundNewUpdate = "A new update is available for Rebound Hub and Rebound 11! (New version: ";
                ReboundError = "Something went wrong.";

                ShellPageHome = "Home";
                ShellPageControl = "Control Panel";
                ShellPageLegalTerms = "Legal Terms";
                break;
            case "ru-ru":
                Title = "Это Ivirius";
                Description = "Мы создали приложения и инструменты, которые обеспечат вам наилучшие впечатления от работы с Windows 11.";
                IviriusTextEditorDesc = "Обновлённый WordPad для Windows 10 и 11.";
                IviriusTextEditorPlusDesc = "Обновлённый WordPad с дополнительными функциями и красивым UI.";
                ReboundItemDesc = "Первый WinUI 3 Windows мод, направленный на обеспечение единого UI.";
                CrimsonDesc = "Добавьте немного света в свою сборку Windows с помощью CrimsonUI.";
                Docs = "Документация";
                DocsDesc = "Узнайте больше о том, как использовать приложения Ivirius и вносить свой вклад в проекты.";
                DiscordServer = "Discord сервер";
                DiscordServerDesc = "Ссылка на наш Discord сервер.";
                AppDocs = "Документация приложений Rebound 11";
                ControlPanel = "Панель управления";
                ControlPanelDesc = "Управление системными настройками и конфигурациями";
                Defrag = "Оптимизация дисков";
                DefragDesc = "Дефрагментируйте и оптимизируйте ваши диски";
                Cleanup = "Очистка дисков";
                CleanupDesc = "Освободите место, удалив ненужные файлы";
                EventViewer = "Просмотр событий";
                EventViewerDesc = "Просматривайте детальные записи системных событий";
                FilesDesc = "Современный проводник для Windows 11";
                Files3rd = "Стороннее";
                IviriusTextEditorDocsDesc = "Современный WordPad для Windows 11";
                Keyboard = "Экранная клавиатура";
                KeyboardDesc = "Доступ к виртуальной клавиатуре на экране";
                Run = "Выполнить";
                RunDesc = "Быстро запускает программы или команды";
                Tasks = "Планировщик задач";
                TasksDesc = "Автоматизируйте задачи на вашем ПК";
                TPM = "TPM";
                TPMDesc = "Управляйте Доверенным Платформенным Модулем";
                WinverDesc = "Просмотр подробной информации о Windows";

                ReboundDesc = "UI Windows 11 стал единым. С приложениями WinUI 3 для повседневных задач.";
                ReboundGetStarted = "Начать работу";
                ReboundGetStartedDesc = "Ознакомьтесь с кратким руководством по установке и использованию Rebound 11.";
                ReboundWinUI3 = "WinUI 3 приложения";
                ReboundWinUI3Desc = "Rebound 11 использует приложения WinUI 3 вместо файлов .msstyles, чтобы сделать UI Windows 11 по-настоящему единым.";
                ReboundWinUpdates = "Обновления Windows";
                ReboundWinUpdatesDesc = "Rebound 11 не блокирует обновления Windows.";
                ReboundUpdates = "Обновления Rebound 11";
                ReboundUpdatesDesc = "Все обновления Rebound 11 осуществляются через Rebound Hub.";
                ReboundGithubDesc = "Смотрите подробную информацию о проекте на GitHub.";
                ReboundNewUpdateAvail = "Доступно новое обновление для Rebound 11!";
                ReboundUpdateDownload = "Скачать";
                ReboundInstalled = "Rebound 11 установлен.";
                ReboundUninstall = "Удалить";
                ReboundFullUninstall = "Удалить полностью";
                ReboundUninstallTooltip = "Удалить приложения и файлы Rebound 11.";
                ReboundFullUninstallTooltip = "Удалить приложения, файлы и ассоциированные (пример: Files) приложения Rebound 11.";
                ReboundPatchOrUpdate = "Пропатчить или обновить";
                ReboundPatchOrUpdateInfoBar = "Если вы только что скачали новую версию Rebound Hub, пожалуйста, обновите также Rebound 11.";
                ReboundNotInstalled = "Rebound 11 не установлен.";
                ReboundInstallHere = "Вы можете установить Rebound 11 здесь.";
                ReboundInstall = "Установить";
                ReboundConfigureInst = "Изменить конфигурацию Rebound 11";
                ReboundChooseApps = "Выберите приложения которые хотите установить.";
                ReboundInstall11 = "Установить Rebound 11";
                ReboundTemplateLight = "☁️ Легкая";
                ReboundTemplateRecommended = "✨ Рекомендуемая";
                ReboundTemplateFull = "⚙️ Полная";
                ReboundFilesCheck = "Проводник (Files - сторонний)";
                ReboundFilesBar = "Rebound Hub не удалит Files, и вам придется удалить его вручную.";
                ReboundRemoteDesktopCheck = "Удалённый рабочий стол";
                ReboundRunCheck = "Выполнить";
                ReboundStepsRecorder = "Счётчик шагов";
                ReboundKeepOriginalWordPad = "Оставить оригинальный";
                ReboundTextEditor = "Ivirius Text Editor (частичная поддержка запуска)";
                ReboundTextEditorPlus = "Ivirius Text Editor Plus (рекомендуется)";
                ReboundTextEditorPlusWarn = "На вашем компьютере должна быть установлена действующая копия Ivirius Text Editor, чтобы использовать ее в качестве замены WordPad для Rebound 11 по умолчанию. Подумайте о приобретении Ivirius Text Editor Plus и последующей установке этой опции, если вы еще этого не сделали.";
                ReboundCharMap = "Таблица символов";
                ReboundMobilityCenter = "Центр мобильности (все устройства)";
                ReboundPresentationSettings = "Настройка параметров презентации (все устройства)";
                ReboundStickyKeys = "Залипание клавиш и фильтрация клавиш";
                ReboundVolMixer = "Микшер громкости (sndvol.exe)";
                ReboundSysTools = "Системные утилиты";
                ReboundAuthManager = "Менеджер авторизации";
                ReboundCertManager = "Менеджер сертификатов";
                ReboundControlPanel = "Панель управления - Вы не можете выключить эту опцию.";
                ReboundMSRT = "Средство удаления вредоносных программ";
                ReboundMemoryDebug = "Диагностика памяти";
                ReboundPrintManagement = "Управление печатью";
                ReboundRegistryEditor = "Редактор реестра (Registry Editor Valley - стороннее)";
                ReboundServices = "Сервисы";
                ReboundSysConf = "Системная конфигурация";
                ReboundSysInfo = "Системная информация";
                ReboundSysRestore = "Восстановление системы";
                ReboundTPMmanagement = "Управление TPM";
                ReboundUAC = "Параметаы управления учётными записями пользователей";
                ReboundAccountManager = "Менеджер учётных записей";
                ReboundFirewall = "Windows Defender Firewall";
                ReboundAdditionalSoft = "Дополнительное ПО";
                ReboundInstallation = "Установка";
                ReboundReadDisclaimer = "Прежде чем вы продолжите, пожалуйста, прочтите следующий отказ от ответственности:";
                ReboundDisclaimer = "Rebound 11 не является модом для Windows. Нажав кнопку Установить, Rebound 11 заменит ярлыки системных приложений и установит необходимые пакеты и сертификаты. Все изменения можно отменить после завершения установки. Не выключайте компьютер и не закрывайте программу установки, чтобы предотвратить повреждение компьютера. Rebound 11 не изменяет Windows и устанавливает автономные приложения WinUI 3 для модернизации вашей системы вместо замены системных файлов. Ivirius не несет ответственности за любой ущерб, причиненный вашему компьютеру. Риск повреждения вашего ПК очень низок, но, как и в случае с любым программным обеспечением, все еще существует. Каждое приложение для Win32 по-прежнему будет доступно для использования, если Rebound 11 не будет работать должным образом. Для отмены изменений не требуются точки восстановления системы. Rebound Hub остановит explorer.exe и перезапустит его после завершения процесса установки. Пожалуйста, сохраните свою работу, прежде чем продолжить.";
                ReboundText1 = "Rebound 11 заменяет ярлыки меню \"Пуск\" устаревших приложений Win32 заменены современными инструментами WinUI 3. Мы постарались исправить как можно больше ошибок, чтобы сделать работу с Rebound 11 максимально комфортной.";
                ReboundNoGlitches = "Без визуальных глитчей";
                ReboundText2 = "Rebound 11 устраняет хорошо известную проблему с выравниванием при наведении курсора на кнопку разворачивания во всех обновленных приложениях.";
                ReboundReplacingOldUiControls = "Замена старого UI.";
                ReboundText3 = "Rebound 11 заменяет старый UI в новых приложениях и использует стандартные элементы управления WinUI 3.";
                ReboundOld = "Старый";
                ReboundNew = "Новый";
                ReboundViewMore = "Просмотреть больше";
                ReboundTextTitle4 = "Сделайте UI Windows 11 единым без каких-либо рисков.";
                ReboundText4 = "Обновите Windows 11 с помощью актуальных приложений WinUI 3, как это было задумано Microsoft. В Rebound 11 обновления Windows включены, система не модифицируется и UI должен быть максимально единым без изменения системных файлов.";
                ReboundNewALPHA = "Новый ALPHA релиз доступен для Rebound Hub и Rebound 11! (Версия: ";
                ReboundNewALPHAwarn = "Внимание: ALPHA версии могут быть нестабильными.";
                ReboundNewDEV = "Новый DEV релиз доступен для Rebound Hub и Rebound 11! (Версия: ";
                ReboundNewDEVwarn = "Внимание: DEV версии могут быть нестабильными.";
                ReboundNewBETA = "Новый BETA релиз доступен для Rebound Hub и Rebound 11! (Версия: ";
                ReboundNewBETAwarn = "Внимание: BETA версии могут быть нестабильными.";
                ReboundNewUpdate = "Новое обновление доступно для Rebound Hub и Rebound 11! (Версия: ";
                ReboundError = "Что-то пошло не так.";

                ShellPageHome = "Дом";
                ShellPageControl = "Панель управления";
                ShellPageLegalTerms = "Юридические термины";
                break;
            default:
                currentCulture = "en-us";
                LoadStrings();
                break;
        }
    }
}
