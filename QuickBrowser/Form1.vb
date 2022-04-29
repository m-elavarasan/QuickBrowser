Imports System.Data.OleDb

Public Class Form1
    Dim int As Integer = 0
    Dim inc As Integer = -1
    Dim conn As New OleDbConnection
    Dim cmd As New OleDbCommand
    Dim da As New OleDbDataAdapter

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        ch1.Visible = False
        ch2.Visible = False
        ch3.Visible = False
        ch4.Visible = False
       
        TabControl1.TabPages.Clear()
        conn.ConnectionString = "Provider = Microsoft.jet.OleDB.4.0;Data Source =  " & Application.StartupPath & "\MAINDB.mdb;"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'txttime.Text = TimeOfDay.ToString("h:mm:ss tt")
        Dim format As String = "dd/MM/yy HH:mm:ss tt"
        Dim time As DateTime = DateTime.Now
        txttime.Text = (time.ToString(format))
    End Sub


    Private Sub btnchacksite_Click(sender As Object, e As EventArgs) Handles btnchacksite.Click
        Dim a As String
        a = urltxt.Text
        If a = "" Then
            MessageBox.Show("Search keyword is Empty !")
        Else
            If rb1.Checked = True Then
                chtrue()
                ch1.Text = "Google"
                ch2.Text = "Bing"
                ch3.Text = "Yahoo"
                ch4.Text = "DuckDuck GO"

            ElseIf rb2.Checked = True Then
                chtrue()
                ch1.Text = "Google News"
                ch2.Text = "NDTV"
                ch3.Text = "CNN News"
                ch4.Text = "BBC News"
            ElseIf rb3.Checked = True Then
                chtrue()
                ch1.Text = "Youtube"
                ch2.Text = "Vimeo"
                ch3.Text = "Daily Motion"
                ch4.Text = "Bing Video"
            ElseIf rb4.Checked = True Then
                chtrue()
                ch1.Text = "Google Play Music"
                ch2.Text = "Youtube Music"
                ch3.Text = "Jio Music"
                ch4.Text = "Ganna"
            ElseIf rb5.Checked = True Then
                chtrue()
                ch1.Text = "Amazon"
                ch2.Text = "Flipkart"
                ch3.Text = "SnapDeal"
                ch4.Text = "Myntra"
            End If
        End If
    End Sub

    Private Sub chtrue()
        ch1.Visible = True
        ch2.Visible = True
        ch3.Visible = True
        ch4.Visible = True
        ch1.Checked = False
        ch2.Checked = False
        ch3.Checked = False
        ch4.Checked = False

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btncloseall.Click
        If TabControl1.TabPages.Count = 0 Then
            MessageBox.Show("No Tab is Opened")
        Else
            TabControl1.TabPages.Clear()
            int = 0
        End If
    End Sub

    Private Sub close_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        If TabControl1.TabPages.Count = 0 Then
            MessageBox.Show("No Tab is Opened")
        Else
            TabControl1.TabPages.RemoveAt(TabControl1.SelectedIndex)
            't.SelectedTab(t.TabPages.Count - 1)
            int = int - 1

        End If
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Application.Exit()

    End Sub
    Private Sub claerbox()
       
        rb1.Checked = False
        rb2.Checked = False
        rb3.Checked = False
        rb4.Checked = False
        rb5.Checked = False
        ch1.Visible = False
        ch2.Visible = False
        ch3.Visible = False
        ch4.Visible = False
        urltxt.Clear()

    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click

        Dim id As Integer
        id = 1
        Dim txt As String
        txt = urltxt.Text
        Dim b As New WebBrowser
        Dim b1 As New WebBrowser
        Dim b2 As New WebBrowser
        Dim b3 As New WebBrowser
        Dim b4 As New WebBrowser
        Dim b5 As New WebBrowser
        Dim b6 As New WebBrowser
        Dim b7 As New WebBrowser
        Dim b8 As New WebBrowser
        Dim b9 As New WebBrowser
        Dim b10 As New WebBrowser
        Dim b11 As New WebBrowser
        Dim b12 As New WebBrowser
        Dim b13 As New WebBrowser
        Dim b14 As New WebBrowser
        Dim b15 As New WebBrowser
        Dim b16 As New WebBrowser
        Dim b17 As New WebBrowser
        Dim b18 As New WebBrowser
        Dim b19 As New WebBrowser
        If urltxt.Text = "" Then
            MessageBox.Show("Search Box is Empty")

        Else
            datacon()
            If rb1.Checked = True Then
                If ch1.Checked = True Then
                    TabControl1.TabPages.Add("Google")
                    TabControl1.SelectTab(int)
                    b.Name = "Web Browser"
                    b.Dock = DockStyle.Fill
                    TabControl1.SelectedTab.Controls.Add(b)

                    CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://www.google.com/search?q=" + txt)
                    int = int + 1
                    claerbox()

                End If
                If ch2.Checked = True Then
                    TabControl1.TabPages.Add("Bing")
                    TabControl1.SelectTab(int)
                    b1.Name = "Web Browser"
                    b1.Dock = DockStyle.Fill
                    TabControl1.SelectedTab.Controls.Add(b1)

                    CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://www.bing.com/search?q=" + txt)
                    int = int + 1
                    claerbox()
                End If
                If ch3.Checked = True Then
                    TabControl1.TabPages.Add("Yahoo")
                    TabControl1.SelectTab(int)
                    b2.Name = "Web Browser"
                    b2.Dock = DockStyle.Fill
                    TabControl1.SelectedTab.Controls.Add(b2)

                    CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://in.search.yahoo.com/search?p=" + txt)
                    int = int + 1
                    claerbox()
                End If
                If ch4.Checked = True Then
                    TabControl1.TabPages.Add("DuckDuckGo")
                    TabControl1.SelectTab(int)
                    b3.Name = "Web Browser"
                    b3.Dock = DockStyle.Fill
                    TabControl1.SelectedTab.Controls.Add(b3)

                    CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://duckduckgo.com/?q=" + txt)
                    int = int + 1
                    claerbox()
                End If
            ElseIf rb2.Checked = True Then
                If ch1.Checked = True Then
                    TabControl1.TabPages.Add("Google News")
                    TabControl1.SelectTab(int)
                    b4.Name = "Web Browser"
                    b4.Dock = DockStyle.Fill
                    TabControl1.SelectedTab.Controls.Add(b4)

                    CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://news.google.com/search?q=" + txt)
                    int = int + 1
                    claerbox()
                End If
                If ch2.Checked = True Then
                    TabControl1.TabPages.Add("NDTV")
                    TabControl1.SelectTab(int)
                    b5.Name = "Web Browser"
                    b5.Dock = DockStyle.Fill
                    TabControl1.SelectedTab.Controls.Add(b5)

                    CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://www.ndtv.com/search?searchtext=" + txt)
                    int = int + 1
                    claerbox()
                End If
                If ch3.Checked = True Then
                    TabControl1.TabPages.Add("CNN News")
                    TabControl1.SelectTab(int)
                    b6.Name = "Web Browser"
                    b6.Dock = DockStyle.Fill
                    TabControl1.SelectedTab.Controls.Add(b6)

                    CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://edition.cnn.com/search?q=" + txt)
                    int = int + 1
                    claerbox()
                End If
                If ch4.Checked = True Then
                    TabControl1.TabPages.Add("BBC")
                    TabControl1.SelectTab(int)
                    b7.Name = "Web Browser"
                    b7.Dock = DockStyle.Fill
                    TabControl1.SelectedTab.Controls.Add(b7)

                    CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://www.bbc.co.uk/search?q=" + txt)
                    int = int + 1
                    claerbox()
                End If

            ElseIf rb3.Checked = True Then
                If ch1.Checked = True Then
                    TabControl1.TabPages.Add("Youtube")
                    TabControl1.SelectTab(int)
                    b8.Name = "Web Browser"
                    b8.Dock = DockStyle.Fill
                    TabControl1.SelectedTab.Controls.Add(b8)

                    CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://www.youtube.com/results?search_query=" + txt)
                    int = int + 1
                    claerbox()
                End If
                If ch2.Checked = True Then
                    TabControl1.TabPages.Add("Vimeo")
                    TabControl1.SelectTab(int)
                    b9.Name = "Web Browser"
                    b9.Dock = DockStyle.Fill
                    TabControl1.SelectedTab.Controls.Add(b9)

                    CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://vimeo.com/search?q=" + txt)
                    int = int + 1
                    claerbox()
                End If
                If ch3.Checked = True Then
                    TabControl1.TabPages.Add("Hotstar")
                    TabControl1.SelectTab(int)
                    b10.Name = "Web Browser"
                    b10.Dock = DockStyle.Fill
                    TabControl1.SelectedTab.Controls.Add(b10)

                    CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://www.hotstar.com/in/search?q=" + txt)
                    int = int + 1
                    claerbox()
                End If
                If ch4.Checked = True Then
                    TabControl1.TabPages.Add("Bing Video")
                    TabControl1.SelectTab(int)
                    b11.Name = "Web Browser"
                    b11.Dock = DockStyle.Fill
                    TabControl1.SelectedTab.Controls.Add(b11)

                    CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://www.bing.com/videos/search?q=" + txt)
                    int = int + 1
                    claerbox()
                End If

            ElseIf rb4.Checked = True Then
                If ch1.Checked = True Then
                    TabControl1.TabPages.Add("Google Play")
                    TabControl1.SelectTab(int)
                    b12.Name = "Web Browser"
                    b12.Dock = DockStyle.Fill
                    TabControl1.SelectedTab.Controls.Add(b12)

                    CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://play.google.com/music/listen?u=0#/sr/" + txt)
                    int = int + 1
                    claerbox()
                End If
                If ch2.Checked = True Then
                    TabControl1.TabPages.Add("Youtube Music")
                    TabControl1.SelectTab(int)
                    b13.Name = "Web Browser"
                    b13.Dock = DockStyle.Fill
                    TabControl1.SelectedTab.Controls.Add(b13)

                    CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://music.youtube.com/search?q=" + txt)
                    int = int + 1
                    claerbox()
                End If
                If ch3.Checked = True Then
                    TabControl1.TabPages.Add("JioSaavn")
                    TabControl1.SelectTab(int)
                    b14.Name = "Web Browser"
                    b14.Dock = DockStyle.Fill
                    TabControl1.SelectedTab.Controls.Add(b14)

                    CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://www.jiosaavn.com/search/" + txt)
                    int = int + 1
                    claerbox()
                End If
                If ch4.Checked = True Then
                    TabControl1.TabPages.Add("Gaana")
                    TabControl1.SelectTab(int)
                    b15.Name = "Web Browser"
                    b15.Dock = DockStyle.Fill
                    TabControl1.SelectedTab.Controls.Add(b15)

                    CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://gaana.com/search/" + txt)
                    int = int + 1
                    claerbox()
                End If

            ElseIf rb5.Checked = True Then
                If ch1.Checked = True Then
                    TabControl1.TabPages.Add("Amazon")
                    TabControl1.SelectTab(int)
                    b16.Name = "Web Browser"
                    b16.Dock = DockStyle.Fill
                    TabControl1.SelectedTab.Controls.Add(b16)

                    CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://www.amazon.in/s?k=" + txt)
                    int = int + 1
                    claerbox()
                End If
                If ch2.Checked = True Then
                    TabControl1.TabPages.Add("Flipkart")
                    TabControl1.SelectTab(int)
                    b17.Name = "Web Browser"
                    b17.Dock = DockStyle.Fill
                    TabControl1.SelectedTab.Controls.Add(b17)

                    CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://www.flipkart.com/search?q=" + txt)
                    int = int + 1
                    claerbox()
                End If
                If ch3.Checked = True Then
                    TabControl1.TabPages.Add("Shopclues")
                    TabControl1.SelectTab(int)
                    b18.Name = "Web Browser"
                    b18.Dock = DockStyle.Fill
                    TabControl1.SelectedTab.Controls.Add(b18)

                    CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://www.shopclues.com/search?q=" + txt)
                    int = int + 1
                    claerbox()
                End If
                If ch4.Checked = True Then
                    TabControl1.TabPages.Add("Myntra")
                    TabControl1.SelectTab(int)
                    b19.Name = "Web Browser"
                    b19.Dock = DockStyle.Fill
                    TabControl1.SelectedTab.Controls.Add(b19)

                    CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://www.myntra.com/" + txt)
                    int = int + 1

                    claerbox()

                End If
            End If
        End If
    End Sub

    Private Sub btnnewtab_Click(sender As Object, e As EventArgs) Handles btnnewtab.Click
        Dim b20 As New WebBrowser
        TabControl1.TabPages.Add("New Tab")
        TabControl1.SelectTab(int)
        b20.Name = "Web Browser"
        b20.Dock = DockStyle.Fill
        TabControl1.SelectedTab.Controls.Add(b20)
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Navigate("https://www.google.com/")
        int = int + 1


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        CType(TabControl1.SelectedTab.Controls.Item(0), WebBrowser).Refresh()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.SendToBack()
        Form2.Show()
    End Sub

    

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        claerbox()
    End Sub

    Private Sub datacon()


        lblrecent.Text = urltxt.Text
        conn.Open()
        cmd.Connection = conn
        cmd.CommandText = "INSERT INTO history(skey,dt)VALUES( '" & urltxt.Text & "', '" & txttime.Text & "')"
      
        cmd.ExecuteNonQuery()
        conn.Close()
        lblrecent.Visible = True
    End Sub

End Class
