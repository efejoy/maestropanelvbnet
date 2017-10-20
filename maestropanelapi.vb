Public Class maestro
    Public Shared ApiKey As String = "1_885bd9d868494d078d4394809f5ca7ac"
    Public Shared apihostdomain As String = "localhost"
    Public Shared port As Integer = 9715
    Public Shared ssl As Boolean = False

    Public Shared Function domain_olustur(domain_adi As String, plan_adi As String, kullanici_adi As String, parola As String,
                                          ad As String, soyad As String, eposta As String) As Integer
        Dim target As New MaestroPanelApi.Client(ApiKey, apihostdomain, port, ssl)
        Dim islem As MaestroPanelApi.ApiResult = target.DomainCreate(domain_adi, plan_adi, kullanici_adi,
                                                                     parola, False, ad, soyad, eposta.ToString.ToLower)
        Return islem.Code
    End Function
    Public Shared Function domain_baslat(domain_adi As String) As Integer
        Dim target As New MaestroPanelApi.Client(ApiKey, apihostdomain, port, ssl)
        Dim islem As MaestroPanelApi.ApiResult = target.DomainStart(domain_adi)
        Return islem.Code
    End Function
    Public Shared Function domain_durdur(domain_adi As String) As Integer
        Dim target As New MaestroPanelApi.Client(ApiKey, apihostdomain, port, ssl)
        Dim islem As MaestroPanelApi.ApiResult = target.DomainStop(domain_adi)
        Return islem.Code
    End Function
End Class
