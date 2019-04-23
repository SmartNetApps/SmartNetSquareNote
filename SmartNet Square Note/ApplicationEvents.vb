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
        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            If My.Settings.AutoUpdates = True Then
                Select Case UpdateAgent.IsUpdateAvailable()
                    Case UpdateAgent.UpdateStatus.OSNotSupported
                        MessageBox.Show("Votre système d'exploitation n'étant plus supporté, plus aucune mise à jour de Square Note ne sera proposée pour cette machine. Visitez le site d'assistance de SmartNet Apps pour en savoir plus.", "SmartNet Apps Updater", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        My.Settings.AutoUpdates = False
                    Case UpdateAgent.UpdateStatus.SupportStatusOff
                        MessageBox.Show("Ce logiciel étant abandonné, plus aucune mise à jour de Square Note ne sera proposée pour cette machine. Visitez le site d'assistance de SmartNet Apps pour en savoir plus.", "SmartNet Apps Updater", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                        My.Settings.AutoUpdates = False
                End Select
            End If
        End Sub

        Private Sub MyApplication_Shutdown(sender As Object, e As EventArgs) Handles Me.Shutdown
            My.Settings.Save()
        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            e.ExitApplication = False
            MessageBox.Show("SmartNet Square Note a planté." + vbCrLf + e.Exception.Message + vbCrLf + e.Exception.StackTrace, "Rapporteur de plantage de SmartNet Square Note", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Environment.Exit(2)
        End Sub
    End Class
End Namespace
