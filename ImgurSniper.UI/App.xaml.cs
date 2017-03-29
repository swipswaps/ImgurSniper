﻿using ImgurSniper.UI.Properties;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows;
using System.Windows.Markup;

namespace ImgurSniper.UI {
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App {
        public App() {
            DispatcherUnhandledException += UnhandledException;

            IsInstaller();

            string language = FileIO.Language;

            //If language is not yet set manually, select system default
            if(language != null) {
                Thread.CurrentThread.CurrentCulture = new CultureInfo(language);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
                FrameworkElement.LanguageProperty.OverrideMetadata(typeof(FrameworkElement), new FrameworkPropertyMetadata(
                    XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.IetfLanguageTag)));
            } else {
                FileIO.Language = Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;
            }
        }


        private void IsInstaller() {
            //Restard if Argument "Installer" is passed (From CustomActions)
            //(Because Installer will wait for Process Exit)
            string[] args = Environment.GetCommandLineArgs();
            if(args.Length > 0 && args.Contains("Installer")) {
                string fileName = Assembly.GetEntryAssembly().Location;
                if(fileName != null) {
                    Process.Start(fileName);
                }

                Current.Shutdown(0);
            }
        }



        //Unhandled Exception User Message Boxes
        private void UnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e) {
            if(MessageBox.Show(strings.unhandledError,
                    "Help fixing an ImgurSniper Bug?",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question) == MessageBoxResult.Yes) {
                Process.Start("https://github.com/mrousavy/ImgurSniper/issues/new");
            }


            if(MessageBox.Show(String.Format(strings.unhandledErrorDescription, e.Exception.Message),
                "ImgurSniper Error",
                MessageBoxButton.YesNo,
                MessageBoxImage.Error) == MessageBoxResult.Yes) {

                MessageBox.Show(
                    "||| Base Message: " + e.Exception.GetBaseException().Message + "\n\r\n\r" +
                    "||| Message: " + e.Exception.Message + "\n\r\n\r" +
                    "||| Source: " + e.Exception.Source + "\n\r\n\r" +
                    "||| Stacktrace: " + e.Exception.StackTrace,
                    "ImgurSniper Exception - More Details",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }

            try {
                string[] argumentsArray = Environment.GetCommandLineArgs();
                string arguments = argumentsArray.Aggregate("", (current, arg) => current + (arg + " "));

                Process.Start(Assembly.GetCallingAssembly().Location, arguments);
            } catch { }
        }
    }
}