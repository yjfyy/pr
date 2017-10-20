Public Class Form1
    Public cmd_log As String
    Public error651 As Boolean
    Public error691 As Boolean
    Public error692 As Boolean
    Public error_other As Boolean
    Public connect As Boolean
    Public pppoe_user_name As String
    Private Sub Button_run_Click(sender As Object, e As EventArgs) Handles Button_run.Click


        Try

            Dim sr As StreamReader = New StreamReader(TextBox_Dict_File.Text)
            Dim dict_text As String

            Do
                dict_text = sr.ReadLine()
                pppoe_user_name = TextBox_Prefix.Text & dict_text & TextBox_Suffix.Text
                MsgBox("(" & pppoe_user_name & ")")
                cmd_log = ConsoleOutput.ExcuteCmd("rasdial " & Trim(TextBox_PPPOE_Name.Text) & " " & Trim(pppoe_user_name) & " " & Trim(TextBox_PPPOE_Password.Text))
                edit_cmd_log(cmd_log)
                edit_ex_log


            Loop Until dict_text Is Nothing
            sr.Close()
        Catch Ex As Exception
            ' Let the user know what went wrong.
            MsgBox(Ex.Message)
        End Try

    End Sub


    Sub edit_ex_log()

        Try

            Dim file As System.IO.StreamWriter

            file = My.Computer.FileSystem.OpenTextFileWriter("log.txt", True)
            If connect Then
                file.WriteLine(pppoe_user_name & "    成功")
            Else
                file.WriteLine(pppoe_user_name & "    失败")
            End If
            File.Close()

        Catch Ex As Exception
            ' Let the user know what went wrong.
            MsgBox(Ex.Message)
        End Try



    End Sub

    Sub edit_cmd_log(log As String)
        MsgBox(cmd_log)

        If InStr(cmd_log, "错误 651") > 0 Then
            error651 = True
        End If
        If InStr(cmd_log, "错误 691") > 0 Then
            error691 = True
        End If
        If InStr(cmd_log, "错误 692") > 0 Then
            error692 = True
        End If
        If InStr(cmd_log, "已连接") > 0 Then
            connect = True
        End If


        MsgBox("651" & error651)
        MsgBox("691" & error691)
        MsgBox("692" & error692)
        MsgBox("成功" & connect)

    End Sub









    Public Class ConsoleOutput


        Private Shared gWorkingDirectory As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal)

        Public Shared Property WorkingDirectory() As String
            Get
                Return gWorkingDirectory
            End Get
            Set(ByVal Value As String)
                gWorkingDirectory = Value
            End Set
        End Property

        Public Shared Function ExcuteCmd(ByVal command As String) As String
            Dim mResult As String = ""

            Dim tmpProcess As New Process
            With tmpProcess
                With .StartInfo
                    .CreateNoWindow = True
                    .FileName = .EnvironmentVariables.Item("ComSpec")
                    .RedirectStandardOutput = True
                    .UseShellExecute = False
                    .Arguments = String.Format("/C {0}", command)
                    .WorkingDirectory = gWorkingDirectory
                End With
                Try
                    .Start()
                    .WaitForExit(5000)
                    mResult = .StandardOutput.ReadToEnd
                Catch e As System.ComponentModel.Win32Exception
                    mResult = e.ToString
                End Try
            End With

            Return mResult
        End Function

    End Class

End Class
