Imports System.ComponentModel.DataAnnotations

Public Class ExternalLoginConfirmationViewModel
    <Required>
    <Display(Name:="Email")>
    Public Property Email As String
End Class

Public Class ExternalLoginListViewModel
    Public Property ReturnUrl As String
End Class

Public Class SendCodeViewModel
    Public Property SelectedProvider As String
    Public Property Providers As ICollection(Of System.Web.Mvc.SelectListItem)
    Public Property ReturnUrl As String
    Public Property RememberMe As Boolean
End Class

Public Class VerifyCodeViewModel
    <Required>
    Public Property Provider As String
    
    <Required>
    <Display(Name:="Código")>
    Public Property Code As String
    
    Public Property ReturnUrl As String

    <Display(Name:="Lembrar deste navegador?")>
    Public Property RememberBrowser As Boolean

    Public Property RememberMe As Boolean
End Class

Public Class ForgotViewModel
    <Required>
    <Display(Name:="Email")>
    Public Property Email As String
End Class

Public Class LoginViewModel
    <Required>
    <Display(Name:="Email")>
    <EmailAddress>
    Public Property Email As String

    <Required>
    <DataType(DataType.Password)>
    <Display(Name:="Senha")>
    Public Property Password As String

    <Display(Name:="Lembrar senha?")>
    Public Property RememberMe As Boolean
End Class

Public Class RegisterViewModel
    <Required(ErrorMessage:="O campo Nome é obrigatório.")>
    <Display(Name:="Nome")>
    Public Property FirstName As String

    <Required(ErrorMessage:="O campo Sobrenome é obrigatório.")>
    <Display(Name:="Sobrenome")>
    Public Property LastName As String

    <Required(ErrorMessage:="O campo Email é obrigatório.")>
    <EmailAddress(ErrorMessage:="Endereço de Email inválido.")>
    <Display(Name:="Email")>
    Public Property Email As String

    <Required(ErrorMessage:="O campo Senha é obrigatório.")>
    <StringLength(100, ErrorMessage:="A {0} deve ter pelo menos {2} caracteres.", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="Senha")>
    Public Property Password As String

    <DataType(DataType.Password)>
    <Display(Name:="Confirmar senha")>
    <Compare("Password", ErrorMessage:="Certifique-se de que as senhas informadas são idênticas.")>
    Public Property ConfirmPassword As String
End Class

Public Class ResetPasswordViewModel
    <Required>
    <EmailAddress>
    <Display(Name:="Email")>
    Public Property Email() As String

    <Required>
    <StringLength(100, ErrorMessage:="A {0} deve ter pelo menos {2} caracteres.", MinimumLength:=6)>
    <DataType(DataType.Password)>
    <Display(Name:="Senha")>
    Public Property Password() As String

    <DataType(DataType.Password)>
    <Display(Name:="Confirmar senha")>
    <Compare("Password", ErrorMessage:="Certifique-se de que as senhas informadas são idênticas")>
    Public Property ConfirmPassword() As String

    Public Property Code() As String
End Class

Public Class ForgotPasswordViewModel
    <Required>
    <EmailAddress>
    <Display(Name:="Email")>
    Public Property Email() As String
End Class
