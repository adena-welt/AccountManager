Imports System.ComponentModel.DataAnnotations

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
