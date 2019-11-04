Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Net
Public Class Form1
    Public Tableau_pictures(200000) As clsPicture
    Dim LstFiles As New List(Of String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub loadFromSerial()
        If File.Exists("enregistre.bin") = True Then
            Dim f As FileStream = File.Open("enregistre.bin", FileMode.Open)
            Dim s As New BinaryFormatter
            Tableau_pictures = s.Deserialize(f)
            f.Close()
            Dim cpt As Long
            cpt = 0
            For Each elt In Tableau_pictures
                If Not (elt Is Nothing) Then
                    LstFile.Rows.Add(elt.NameOffile, elt.PathOfFile, elt.SizeOfFile.ToString, elt.crc)
                    cpt = cpt + 1
                End If

            Next
            MsgBox(cpt.ToString)

        End If
    End Sub
    Public Sub saveFromSerial()
        Dim f As FileStream = File.Create("enregistre.bin")
        Dim s As New BinaryFormatter
        s.Serialize(f, Tableau_pictures)
        f.Close()
    End Sub

    Private Sub LoadInfo_Click(sender As Object, e As EventArgs) Handles LoadInfo.Click
        loadFromSerial()
    End Sub

    Private Sub SaveInfo_Click(sender As Object, e As EventArgs) Handles SaveInfo.Click
        saveFromSerial()

    End Sub

    Private Sub GetInfo_Click(sender As Object, e As EventArgs) Handles GetInfo.Click
        Dim val1 As List(Of String)
        Dim cpt As Long
        Dim c As New CRC32()
        Dim crc As Integer = 0
        cpt = 1
        Dim FILE_NAME As String = "config.txt"
        Dim TextLine As String
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objReader As New System.IO.StreamReader(FILE_NAME)
            Do While objReader.Peek() <> -1
                TextLine = objReader.ReadLine()
                LstFiles.Add(TextLine)
            Loop
        End If
        Dim CRCID As Integer = 0
        If Tableau_pictures Is Nothing Then
            ReDim Tableau_pictures(1)
        Else

            ReDim Preserve Tableau_pictures(Tableau_pictures.Count)
        End If

        For Each instanceF In LstFiles
            val1 = Class1.dirRecursively(instanceF, "*.jpg", 0, 0)
            For Each str1 In val1
                Tableau_pictures(cpt) = New clsPicture


                Dim info2 As New FileInfo(str1)
                Dim length2 As Long = info2.Length

                Dim f As FileStream = New FileStream(str1, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
                crc = c.GetCrc32(f)

                f.Close()
                Tableau_pictures(cpt).crc = String.Format("{0:X8}", crc)
                Dim f2 As FileStream = New FileStream(str1, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)

                CRCID = c.GetCrc32ID(f2)
                f2.Close()
                Tableau_pictures(cpt).CRCLimited = String.Format("{0:X8}", CRCID)


                Tableau_pictures(cpt).NameOffile = System.IO.Path.GetFileName(str1)
                Tableau_pictures(cpt).SizeOfFile = length2
                Tableau_pictures(cpt).PathOfFile = System.IO.Path.GetDirectoryName(str1)

                LstFile.Rows.Add(Tableau_pictures(cpt).NameOffile, Tableau_pictures(cpt).PathOfFile, Tableau_pictures(cpt).SizeOfFile.ToString, Tableau_pictures(cpt).crc.ToString, Tableau_pictures(cpt).CRCLimited.ToString)
                cpt = cpt + 1
            Next str1
        Next instanceF

    End Sub
End Class
