Public Class Form1

    Dim StopCall = False

    Dim itemOpened = False

    'Class level declorations
    Public Declare Auto Function SetCursorPos Lib "User32.dll" (ByVal X As Integer, ByVal Y As Integer) As Integer
    Public Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Integer, ByVal dx As Integer,
                                                                     ByVal dy As Integer, ByVal cButtons As Integer,
                                                                     ByVal dwExtraInfo As Integer)
    Public Const MOUSEEVENTF_LEFTDOWN = &H2 ' left button down
    Public Const MOUSEEVENTF_LEFTUP = &H4 ' left button up


    'Form Load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        WebBrowser1.Navigate("http://www.supremenewyork.com")
    End Sub

    'Open item Button
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim type As String = typeComboBox.Text
        AddHandler WebBrowser1.DocumentCompleted, New _
        WebBrowserDocumentCompletedEventHandler(AddressOf openItem)
        WebBrowser1.Navigate("http://www.supremenewyork.com/shop/all/" + type)
    End Sub

    'Open item method
    Private Sub openItem(sender As Object, e As EventArgs)
        AddHandler WebBrowser1.DocumentCompleted, New _
        WebBrowserDocumentCompletedEventHandler(AddressOf logIn_Click)

        Dim searchName As String = TextBox1.Text
        Dim colorName As String = colorTextBox.Text
        Dim itemHref = ""
        Dim colorHref = ""
        Dim itemList As New ArrayList
        Dim colorList As New ArrayList
        Dim found = False

        Dim allelements As HtmlElementCollection = WebBrowser1.Document.All

        If colorTextBox.Text <> "" Then
            For Each webpageelement As HtmlElement In allelements
                If webpageelement.InnerText = colorName Then
                    colorHref = webpageelement.GetAttribute("href")
                    If colorHref <> "" Then
                        colorList.Add(colorHref)
                    End If
                End If
            Next
            For Each webpageelement As HtmlElement In allelements
                If webpageelement.InnerText = searchName Then
                    itemHref = webpageelement.GetAttribute("href")
                    If itemHref <> "" Then
                        itemList.Add(itemHref)
                    End If
                End If
            Next
            For i As Integer = 0 To itemList.Count - 1
                itemHref = itemList(i)
                For x As Integer = 0 To colorList.Count - 1
                    If itemList(i) = colorList(x) Then
                        WebBrowser1.Navigate(itemHref)
                        itemOpened = True
                    End If
                Next
            Next
        Else
            For Each webpageelement As HtmlElement In allelements
                If webpageelement.InnerText = searchName Then
                    webpageelement.InvokeMember("click")
                End If
            Next
        End If
        'MsgBox("Open Item Called")
    End Sub

    'Set size / Commit button / Open checkout
    Private Sub logIn_Click(sender As Object, e As EventArgs)
        AddHandler WebBrowser1.DocumentCompleted, New _
        WebBrowserDocumentCompletedEventHandler(AddressOf PrintDocument)

        'Choose size
        'WebBrowser1.Document.GetElementById("s").SetAttribute("value", 49862)

        WebBrowser1.Document.GetElementById("commit").InvokeMember("Click")

        If StopCall = False Then
            checkoutStall.Start()
        End If
        'MsgBox("Set size / commit called")
    End Sub


    'Enter Info method
    Private Sub PrintDocument(ByVal sender As Object, ByVal e As EventArgs)
        Dim name As String = nameTextBox.Text
        Dim email As String = emailTextBox.Text
        Dim phone As String = telTextBox.Text
        Dim address As String = addTextBox.Text
        Dim zip As String = zipTextBox.Text
        Dim city As String = cityTextBox.Text
        Dim country As String = cntryTextBox.Text
        Dim cn As String = cnTextBox.Text
        Dim month As String = monthTextBox.Text
        Dim year As String = yearTextBox.Text
        Dim cvv As String = yearTextBox.Text

        If country = "CANADA" Then
            SetCursorPos(1050, 680)
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
        Else
            WebBrowser1.Document.GetElementById("order_billing_country").SetAttribute("value", "USA")
        End If

        WebBrowser1.Document.GetElementById("order_billing_name").SetAttribute("value", name)
        WebBrowser1.Document.GetElementById("order_email").SetAttribute("value", email)
        WebBrowser1.Document.GetElementById("order_tel").SetAttribute("value", phone)
        WebBrowser1.Document.GetElementById("bo").SetAttribute("value", address)
        WebBrowser1.Document.GetElementById("order_billing_zip").SetAttribute("value", zip)
        WebBrowser1.Document.GetElementById("order_billing_city").SetAttribute("value", city)
        WebBrowser1.Document.GetElementById("order_billing_state").SetAttribute("value", "BC")
        WebBrowser1.Document.GetElementById("nnaerb").SetAttribute("value", cn)
        WebBrowser1.Document.GetElementById("credit_card_month").SetAttribute("value", month)
        WebBrowser1.Document.GetElementById("credit_card_year").SetAttribute("value", year)
        WebBrowser1.Document.GetElementById("orcer").SetAttribute("value", cvv)
        WebBrowser1.Document.GetElementById("order_terms").SetAttribute("checked", "true")
        WebBrowser1.Document.GetElementById("commit").InvokeMember("Click")

        WebBrowser1.Stop()

        'MsgBox("Enter Info called")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        MsgBox(dropTime)
    End Sub

    Dim dropTime As New Date(2017, 11, 22, 4, 34, 0)

    Dim timeLeft = 5

    Dim Dys As Integer
    Dim Hrs As Integer
    Dim Min As Integer
    Dim Sec As Integer

    Dim checkoutTimeLeft = 1

    Private Sub Timer1_Tick() Handles Timer1.Tick
        Dim TimeRemaining As TimeSpan = dropTime.Subtract(DateTime.Now)
        Dys = TimeRemaining.Days
        Dim hrs4days As Integer = Dys * 24
        Hrs = TimeRemaining.Hours + hrs4days
        Min = TimeRemaining.Minutes
        Sec = TimeRemaining.Seconds
        Button1.Text = CType(Hrs, String) + " : " + CType(Min, String) + " : " + CType(Sec, String)
        If Sec = 0 Then
            Me.Button3.PerformClick()
            Button1.Text = "DONE!!!"
            Timer1.Stop()
        End If
    End Sub

    Private Sub checkoutStall_Tick() Handles checkoutStall.Tick
        If checkoutTimeLeft > 0 Then
            checkoutTimeLeft -= 1
        Else
            checkoutStall.Stop()
            'MsgBox("CheckoutStall")
            WebBrowser1.Navigate("https://www.supremenewyork.com/checkout")
            StopCall = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SetCursorPos(1600, 750)
    End Sub
End Class