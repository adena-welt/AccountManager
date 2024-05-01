Imports System.ComponentModel.DataAnnotations
Imports Microsoft.AspNet.Identity
Imports Microsoft.Owin.Security

Public Class IndexViewModel
    Public Property HasPassword As Boolean
    Public Property Logins As IList(Of UserLoginInfo)
    Public Property PhoneNumber As String
    Public Property TwoFactor As Boolean
    Public Property BrowserRemembered As Boolean
End Class

Public Class ManageLoginsViewModel
    Public Property CurrentLogins As IList(Of UserLoginInfo)
    Public Property OtherLogins As IList(Of AuthenticationDescription)
End Class

Public Class FactorViewModel
    Public Property Purpose As String
End Class

Public Class ChangePasswordViewModel
    <Required>
    <DataType(DataType.Password)>
    <Display(Name:="Senha atual")>
    Public Property OldPassword As String

    <Required>
    <StringLength(100, ErrorMessage:="A {0} deve ter pelo menos {2} caracteres.", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="Nova senha")>
    Public Property NewPassword As String

    <DataType(DataType.Password)>
    <Display(Name:="Confirme a nova senha")>
    <Compare("NewPassword", ErrorMessage:="Certifique-se de que a nova senha e a senha de confimação informadas são idênticas.")>
    Public Property ConfirmPassword As String
End Class