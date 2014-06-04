// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoMac.Foundation;
using System.CodeDom.Compiler;

namespace AirVPN.UI.Osx
{
	[Register ("WindowPreferencesController")]
	partial class WindowPreferencesController
	{
		[Outlet]
		MonoMac.AppKit.NSPopUpButton CboAdvancedDnsSwitchMode { get; set; }

		[Outlet]
		MonoMac.AppKit.NSPopUpButton CboProxyAuthentication { get; set; }

		[Outlet]
		MonoMac.AppKit.NSPopUpButton CboProxyType { get; set; }

		[Outlet]
		MonoMac.AppKit.NSPopUpButton CboRoutesOtherwise { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkAdvancedCheckDns { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkAdvancedCheckRoute { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkAdvancedExpertMode { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkAdvancedOpenVpnDirectivesDefaultSkip { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkAdvancedPingerAlways { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkAdvancedPingerEnabled { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkAutoStart { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkGeneralOsxNotifications { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkGeneralStartLast { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeSsh22 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeSsh22Alt { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeSsh53 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeSsh80 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeSsl443 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeTcp2018 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeTcp2018Alt { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeTcp443 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeTcp53 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeTcp80 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeUdp2018 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeUdp2018Alt { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeUdp443 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeUdp443Alt { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeUdp53 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeUdp53Alt { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeUdp80 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton ChkModeUdp80Alt { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton CmdAdvancedHelp { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton CmdAdvancedOpenVpnPath { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton CmdCancel { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton CmdGeneralTos { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton CmdModeHelp { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton CmdSave { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField TxtAdvancedOpenVpnDirectivesCustom { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField TxtAdvancedOpenVpnDirectivesDefault { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField TxtAdvancedOpenVpnPath { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField TxtProxyHost { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField TxtProxyLogin { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField TxtProxyPassword { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField TxtProxyPort { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (CboAdvancedDnsSwitchMode != null) {
				CboAdvancedDnsSwitchMode.Dispose ();
				CboAdvancedDnsSwitchMode = null;
			}

			if (CboProxyAuthentication != null) {
				CboProxyAuthentication.Dispose ();
				CboProxyAuthentication = null;
			}

			if (CboProxyType != null) {
				CboProxyType.Dispose ();
				CboProxyType = null;
			}

			if (ChkAdvancedCheckDns != null) {
				ChkAdvancedCheckDns.Dispose ();
				ChkAdvancedCheckDns = null;
			}

			if (ChkAdvancedCheckRoute != null) {
				ChkAdvancedCheckRoute.Dispose ();
				ChkAdvancedCheckRoute = null;
			}

			if (ChkAdvancedExpertMode != null) {
				ChkAdvancedExpertMode.Dispose ();
				ChkAdvancedExpertMode = null;
			}

			if (ChkAdvancedOpenVpnDirectivesDefaultSkip != null) {
				ChkAdvancedOpenVpnDirectivesDefaultSkip.Dispose ();
				ChkAdvancedOpenVpnDirectivesDefaultSkip = null;
			}

			if (ChkAdvancedPingerAlways != null) {
				ChkAdvancedPingerAlways.Dispose ();
				ChkAdvancedPingerAlways = null;
			}

			if (ChkAdvancedPingerEnabled != null) {
				ChkAdvancedPingerEnabled.Dispose ();
				ChkAdvancedPingerEnabled = null;
			}

			if (ChkAutoStart != null) {
				ChkAutoStart.Dispose ();
				ChkAutoStart = null;
			}

			if (ChkGeneralOsxNotifications != null) {
				ChkGeneralOsxNotifications.Dispose ();
				ChkGeneralOsxNotifications = null;
			}

			if (ChkGeneralStartLast != null) {
				ChkGeneralStartLast.Dispose ();
				ChkGeneralStartLast = null;
			}

			if (ChkModeSsh22 != null) {
				ChkModeSsh22.Dispose ();
				ChkModeSsh22 = null;
			}

			if (ChkModeSsh22Alt != null) {
				ChkModeSsh22Alt.Dispose ();
				ChkModeSsh22Alt = null;
			}

			if (ChkModeSsh53 != null) {
				ChkModeSsh53.Dispose ();
				ChkModeSsh53 = null;
			}

			if (ChkModeSsh80 != null) {
				ChkModeSsh80.Dispose ();
				ChkModeSsh80 = null;
			}

			if (ChkModeSsl443 != null) {
				ChkModeSsl443.Dispose ();
				ChkModeSsl443 = null;
			}

			if (ChkModeTcp2018 != null) {
				ChkModeTcp2018.Dispose ();
				ChkModeTcp2018 = null;
			}

			if (ChkModeTcp2018Alt != null) {
				ChkModeTcp2018Alt.Dispose ();
				ChkModeTcp2018Alt = null;
			}

			if (ChkModeTcp443 != null) {
				ChkModeTcp443.Dispose ();
				ChkModeTcp443 = null;
			}

			if (ChkModeTcp53 != null) {
				ChkModeTcp53.Dispose ();
				ChkModeTcp53 = null;
			}

			if (ChkModeTcp80 != null) {
				ChkModeTcp80.Dispose ();
				ChkModeTcp80 = null;
			}

			if (ChkModeUdp2018 != null) {
				ChkModeUdp2018.Dispose ();
				ChkModeUdp2018 = null;
			}

			if (ChkModeUdp2018Alt != null) {
				ChkModeUdp2018Alt.Dispose ();
				ChkModeUdp2018Alt = null;
			}

			if (ChkModeUdp443 != null) {
				ChkModeUdp443.Dispose ();
				ChkModeUdp443 = null;
			}

			if (ChkModeUdp443Alt != null) {
				ChkModeUdp443Alt.Dispose ();
				ChkModeUdp443Alt = null;
			}

			if (ChkModeUdp53 != null) {
				ChkModeUdp53.Dispose ();
				ChkModeUdp53 = null;
			}

			if (ChkModeUdp53Alt != null) {
				ChkModeUdp53Alt.Dispose ();
				ChkModeUdp53Alt = null;
			}

			if (ChkModeUdp80 != null) {
				ChkModeUdp80.Dispose ();
				ChkModeUdp80 = null;
			}

			if (ChkModeUdp80Alt != null) {
				ChkModeUdp80Alt.Dispose ();
				ChkModeUdp80Alt = null;
			}

			if (CboRoutesOtherwise != null) {
				CboRoutesOtherwise.Dispose ();
				CboRoutesOtherwise = null;
			}

			if (CmdAdvancedHelp != null) {
				CmdAdvancedHelp.Dispose ();
				CmdAdvancedHelp = null;
			}

			if (CmdAdvancedOpenVpnPath != null) {
				CmdAdvancedOpenVpnPath.Dispose ();
				CmdAdvancedOpenVpnPath = null;
			}

			if (CmdCancel != null) {
				CmdCancel.Dispose ();
				CmdCancel = null;
			}

			if (CmdGeneralTos != null) {
				CmdGeneralTos.Dispose ();
				CmdGeneralTos = null;
			}

			if (CmdModeHelp != null) {
				CmdModeHelp.Dispose ();
				CmdModeHelp = null;
			}

			if (CmdSave != null) {
				CmdSave.Dispose ();
				CmdSave = null;
			}

			if (TxtAdvancedOpenVpnDirectivesCustom != null) {
				TxtAdvancedOpenVpnDirectivesCustom.Dispose ();
				TxtAdvancedOpenVpnDirectivesCustom = null;
			}

			if (TxtAdvancedOpenVpnDirectivesDefault != null) {
				TxtAdvancedOpenVpnDirectivesDefault.Dispose ();
				TxtAdvancedOpenVpnDirectivesDefault = null;
			}

			if (TxtAdvancedOpenVpnPath != null) {
				TxtAdvancedOpenVpnPath.Dispose ();
				TxtAdvancedOpenVpnPath = null;
			}

			if (TxtProxyHost != null) {
				TxtProxyHost.Dispose ();
				TxtProxyHost = null;
			}

			if (TxtProxyLogin != null) {
				TxtProxyLogin.Dispose ();
				TxtProxyLogin = null;
			}

			if (TxtProxyPassword != null) {
				TxtProxyPassword.Dispose ();
				TxtProxyPassword = null;
			}

			if (TxtProxyPort != null) {
				TxtProxyPort.Dispose ();
				TxtProxyPort = null;
			}
		}
	}

	[Register ("WindowPreferences")]
	partial class WindowPreferences
	{
		
		void ReleaseDesignerOutlets ()
		{
		}
	}
}
