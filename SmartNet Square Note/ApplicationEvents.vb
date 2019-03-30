Imports System.Net
Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' Les événements suivants sont disponibles pour MyApplication :
    ' Startup : déclenché au démarrage de l'application avant la création du formulaire de démarrage.
    ' Shutdown : déclenché après la fermeture de tous les formulaires de l'application. Cet événement n'est pas déclenché si l'application se termine de façon anormale.
    ' UnhandledException : déclenché si l'application rencontre une exception non gérée.
    ' StartupNextInstance : déclenché lors du lancement d'une application à instance unique et si cette application est déjà active. 
    ' NetworkAvailabilityChanged : déclenché lorsque la connexion réseau est connectée ou déconnectée.
    Partial Friend Class MyApplication
        Dim ApplicationNotifyIcon As New NotifyIcon
        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            ApplicationNotifyIcon.Icon = NoteForm.NotifyIcon.Icon
            ApplicationNotifyIcon.Text = "SmartNet Square Note"
            'ApplicationNotifyIcon.ContextMenuStrip = NoteForm.ContextMenuStrip1
            ApplicationNotifyIcon.Visible = True

            If My.Settings.AutoUpdates = True Then
                Select Case UpdateAgent.IsUpdateAvailable()
                    Case UpdateAgent.UpdateStatus.OSNotSupported
                        MessageBox.Show("Votre système d'exploitation n'étant plus supporté, plus aucune mise à jour de Square Note ne sera proposée pour cette machine. Visitez le site d'assistance de SmartNet Apps pour en savoir plus.", "SmartNet Apps Updater", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        My.Settings.AutoUpdates = False
                    Case UpdateAgent.UpdateStatus.SupportStatusOff
                        MessageBox.Show("Ce logiciel étant abandonné, plus aucune mise à jour de Square Note ne sera proposée pour cette machine. Visitez le site d'assistance de SmartNet Apps pour en savoir plus.", "SmartNet Apps Updater", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        My.Settings.AutoUpdates = False
                    Case UpdateAgent.UpdateStatus.UpdateAvailable
                        Dim UpdateNotifyIcon As New NotifyIcon With {
                            .Icon = My.Resources._2019_SmartNetAppsUpdater_NotificationIcon,
                            .Text = "Mise à jour pour SmartNet Square Note",
                            .BalloonTipTitle = "SmartNet Apps Updater",
                            .BalloonTipText = "Une mise à jour est disponible pour SmartNet Square Note.",
                            .BalloonTipIcon = ToolTipIcon.Info,
                            .Visible = True
                        }
                        UpdateNotifyIcon.ShowBalloonTip(10000)
                End Select
            End If
        End Sub

        Private Sub MyApplication_Shutdown(sender As Object, e As EventArgs) Handles Me.Shutdown
            ApplicationNotifyIcon.Visible = False
        End Sub
    End Class
End Namespace
