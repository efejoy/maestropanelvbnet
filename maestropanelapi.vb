Public Class Form1

    Public Shared ApiKey As String
    Public Shared apihostdomain As String
    Public Shared port As Integer
    Public Shared ssl As Boolean


    Public Sub DomainCreateTest()
        ApiKey = "1_885bd9d868494d078d4394809f5ca7ac"
        apihostdomain = "localhost"
        port = 9715
        ssl = False

        Dim target As New MaestroPanelApi.Client(ApiKey, apihostdomain, port, ssl)

        Dim api_result As Integer

        Dim name As String = "demo4.com"
        Dim planAlias As String = "default"
        Dim username As String = "demo1.com"
        Dim password As String = "kr3m@12!"
        Dim activedomainuser As Boolean = False
        Dim firstName As String = "Demo"
        Dim lastName As String = "Customer"
        Dim email As String = "demo@customer.com"

        Dim actual As MaestroPanelApi.ApiResult = target.DomainCreate(name, planAlias, username, password, activedomainuser, firstName,
            lastName, email)

        api_result = actual.Code.ToString

    End Sub
    Public Sub DomainStartTest()
        ApiKey = "1_885bd9d868494d078d4394809f5ca7ac"
        apihostdomain = "localhost"
        port = 9715
        ssl = False

        Dim target As New Client(ApiKey, apihostdomain, port, ssl)
        Dim name As String = "mustafaefe.me"
        Dim actual As ApiResult = target.DomainStart(name)
        Dim api_result As Integer = actual.Code.ToString
    End Sub

    Public Sub DomainStopTest()
        ApiKey = "1_885bd9d868494d078d4394809f5ca7ac"
        apihostdomain = "localhost"
        port = 9715
        ssl = False

        Dim target As New Client(ApiKey, apihostdomain, port, ssl)
        Dim name As String = "mustafaefe.me"
        Dim actual As ApiResult = target.DomainStop(name)
        Dim api_result As Integer = actual.Code.ToString
    End Sub

End Class
