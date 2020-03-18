Imports System.Web.Script.Serialization
Imports System.Runtime.InteropServices
'403; 517
'1220; 517

Public Class Form1
    Private ShowTerminal As Boolean
    Public Const MOD_ALT As Integer = &H1 'Alt key
    Public Const WM_HOTKEY As Integer = &H312

    <DllImport("User32.dll")> Public Shared Function RegisterHotKey(ByVal hwnd As IntPtr, ByVal id As Integer, ByVal fsModifiers As Integer, ByVal vk As Integer) As Integer
    End Function

    <DllImport("User32.dll")> Public Shared Function UnregisterHotKey(ByVal hwnd As IntPtr, ByVal id As Integer) As Integer
    End Function
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If m.Msg = WM_HOTKEY Then
            Dim id As IntPtr = m.WParam
            Select Case (id.ToString)
                Case "100"

                    ShowTerminal = Not ShowTerminal
                    If ShowTerminal Then
                        Me.Width = 1220
                        Term.Visible = True
                    Else
                        Term.Visible = False
                        Me.Width = 403
                    End If

            End Select
        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 403
        InitPortlist()
        RegisterHotKey(Me.Handle, 100, MOD_ALT, Keys.T)
    End Sub
    Private Sub InitPortlist()
        Dim ports As New Object
        ports = SerialPort1.GetPortNames()
        ComboSelectPort.Items.AddRange(ports)
        SerialPort1.ReadTimeout = 1


    End Sub
    Private Sub DoConnection()
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
            ComboSelectPort.Enabled = True
            ButtonConnect.Text = "Connect"
        Else
            SerialPort1.BaudRate = 57600
            If ComboSelectPort.Text <> "" Then
                SerialPort1.PortName = ComboSelectPort.Text
                Try
                    SerialPort1.Open()
                Catch
                    msg("Serial port opening error. Try to disconnect another terminal programs")
                    Exit Sub
                End Try
                SerialPort1.DiscardInBuffer()
                ComboSelectPort.Enabled = False
                ButtonConnect.Text = "Disconnect"
            Else
                msg("select com port number")

            End If
        End If
    End Sub
    Private Sub msg(s As String)
        MsgBox(s)
    End Sub
    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        DoConnection()


    End Sub




    '{"command":"close"}
    '{"command":"open"}
    '{"command":"center"}
    '{"command":"uncenter"}
    '{"command":"reset"}
    '{"command":"stop"}
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        SendSerial("{""command"":""close""}")
    End Sub

    Private Sub ButtonOpen_Click(sender As Object, e As EventArgs) Handles ButtonOpen.Click
        SendSerial("{""command"":""open""}")
    End Sub
    Private Sub ButtonCenter_Click(sender As Object, e As EventArgs) Handles ButtonCenter.Click
        SendSerial("{""command"":""center""}")
    End Sub

    Private Sub ButtonUncenter_Click(sender As Object, e As EventArgs) Handles ButtonUncenter.Click
        SendSerial("{""command"":""uncenter""}")
    End Sub
    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        SendSerial("{""command"":""reset""}")
    End Sub
    Private Sub ButtonStop_Click(sender As Object, e As EventArgs) Handles ButtonStop.Click
        SendSerial("{""command"":""stop""}")
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        ParseInput()


        'Static tristate As Integer
        'If tristate = 1 Then
        '    DFO.Image = My.Resources.LedGreen
        '    DFC.Image = My.Resources.LedRedDark
        'ElseIf tristate = 2 Then
        '    DFC.Image = My.Resources.LedRedDark
        '    DFO.Image = My.Resources.LedGreenDark
        'ElseIf tristate = 3 Then
        '    DFC.Image = My.Resources.LedRed
        '    DFO.Image = My.Resources.LedGreenDark
        'Else
        '    DFC.Image = My.Resources.LedRedDark
        '    DFO.Image = My.Resources.LedGreenDark
        'End If


        'tristate = tristate + 1
        'tristate = tristate Mod 4

    End Sub

    Private Sub ParseInput()
        Dim rawresp As String  '= "{""FCO"":1,""first_name"":""Hamed"",""last_name"":""Ap"",""LRBD"":""1"",""type"":""private""}"

        If Not SerialPort1.IsOpen Then
            Exit Sub
        End If

        'If Not SerialPort1.BytesToRead > 2000 Then
        '   SerialPort1.DiscardInBuffer() 'discard old data
        '    Exit Sub
        'End If


        Try
            rawresp = SerialPort1.ReadLine()
        Catch ex As TimeoutException
            Exit Sub
        End Try

        If rawresp = "" Then
            Exit Sub
        End If

        If ShowTerminal Then
            Term.AppendText(rawresp & vbCrLf)
        End If


        Dim jss As New JavaScriptSerializer()
        Dim dict As Dictionary(Of String, String)

        Try
            dict = jss.Deserialize(Of Dictionary(Of String, String))(rawresp)
        Catch
            Exit Sub
        End Try

        'LRFU.LedState = Not LRFU.LedState

        Dim MsgType As String
        dict.TryGetValue("TYPE", MsgType)

        If MsgType = "1" Then

            For Each ctrl In Me.Panel1.Controls
                If TypeOf ctrl Is PictureboxT Then
                    Dim v As String
                    dict.TryGetValue(ctrl.name, v)
                    If v = "0" Then
                        ctrl.LedState = 1 'endstops inverted 
                    ElseIf v = "1" Then
                        ctrl.LedState = 0
                    End If
                    'ctrl.LedState = Not ctrl.LedState
                End If
            Next

            Dim com As String
            dict.TryGetValue("com", com)
            If com <> "" Then
                ShowCmd(com)
            End If

        ElseIf MsgType = 2 Then
            For Each ctrl In Me.Panel1.Controls
                If TypeOf ctrl Is TextBox And ctrl.forecolor = Color.Red Then 'all textboxes for actuators  errors have red text color
                    Dim v As String
                    dict.TryGetValue(ctrl.name, v)
                    If v = "3" Then
                        ctrl.text = "Error"
                    Else
                        ctrl.text = ""
                    End If
                End If
            Next
        ElseIf MsgType = 3 Then
            Dim t As String, h As String
            dict.TryGetValue("TEMP", t)
            dict.TryGetValue("HUM", h)
            Temp.Text = "Temperature: " & t & "C"
            HUM.Text = "Humidity: " & h & "%"


        End If


    End Sub

    Private Sub SendSerial(line As String)
        If Not SerialPort1.IsOpen Then
            msg("Serial port is not connected")
            Exit Sub
        End If
        SerialPort1.WriteLine(line)
        If ShowTerminal Then
            Term.AppendText(">>>" & line & vbCrLf)
        End If
    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        UnregisterHotKey(Me.Handle, 100)
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
        End If

    End Sub

    Private Sub ShowCmd(cmd As String)
        If cmd = "-1" Then
            BaseStateTxt.Text = "BASE status: is idle"
        ElseIf cmd = "0" Then
            BaseStateTxt.Text = "BASE status: is opening"
        ElseIf cmd = "1" Then
            BaseStateTxt.Text = "BASE status: is closing"
        ElseIf cmd = "2" Then
            BaseStateTxt.Text = "BASE status: centering Drone"
        ElseIf cmd = "3" Then
            BaseStateTxt.Text = "BASE status: release claws"
        ElseIf cmd = "4" Then
            BaseStateTxt.Text = "BASE status: reseting actuators"
        ElseIf cmd = "5" Then
            BaseStateTxt.Text = "BASE status: stopping actuators"
        End If
        ' 0; // OPEN
        ' 1; // CLOSE
        ' 2; // CENTER
        ' 3; // UNCENTER
        ' 4 reseting
        ' 5 stopping
    End Sub



End Class
