Public Class Form1
    Dim rand As New Random
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources.DoorKNob, AudioPlayMode.Background)
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
        MessageBox.Show("Sound files loaded")
        Timer1.Interval = rand.Next(10000, 15000)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Button2.Enabled = False
        Button3.Enabled = False
        Timer1.Start()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ReactionTimer1.Stop()
        Timer1.Interval = rand.Next(10000, 150000)
        Timer1.Start()
        Button1.Enabled = False
    End Sub

    Private Sub ReactionTimer1_Tick(sender As System.Object, e As System.EventArgs) Handles ReactionTimer1.Tick
        Label2.Visible = True
        Button1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        My.Computer.Audio.Play(My.Resources.DoorKNob, AudioPlayMode.Background)
        ReactionTimer1.Start()
        Button1.Enabled = True
        Timer1.Stop()
    End Sub
End Class
