Imports System.Globalization
Imports System.Security.Claims
Imports System.Threading.Tasks
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.Owin
Imports Microsoft.Owin.Security
Imports Owin

<Authorize>
Public Class AccountController
    Inherits Controller
    Private _signInManager As ApplicationSignInManager
    Private _userManager As ApplicationUserManager

    Public Sub New()
    End Sub

    Public Sub New(appUserMan As ApplicationUserManager, signInMan As ApplicationSignInManager)
        UserManager = appUserMan
        SignInManager = signInMan
    End Sub

    Public Property SignInManager() As ApplicationSignInManager
        Get
            Return If(_signInManager, HttpContext.GetOwinContext().[Get](Of ApplicationSignInManager)())
        End Get
        Private Set
            _signInManager = value
        End Set
    End Property

    Public Property UserManager() As ApplicationUserManager
        Get
            Return If(_userManager, HttpContext.GetOwinContext().GetUserManager(Of ApplicationUserManager)())
        End Get
        Private Set
            _userManager = value
        End Set
    End Property

    '
    ' GET: /Account/Login
    <AllowAnonymous>
    Public Function Login(returnUrl As String) As ActionResult
        ViewData!ReturnUrl = returnUrl
        Return View()
    End Function

    '
    ' POST: /Account/Login
    <HttpPost>
    <AllowAnonymous>
    <ValidateAntiForgeryToken>
    Public Async Function Login(model As LoginViewModel, returnUrl As String) As Task(Of ActionResult)
        If Not ModelState.IsValid Then
            Return View(model)
        End If

        ' This doesn't count login failures towards account lockout
        ' To enable password failures to trigger account lockout, change to shouldLockout := True
        Dim result = Await SignInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, shouldLockout := False)
        Select Case result
            Case SignInStatus.Success
                Return RedirectToLocal(returnUrl)
            Case SignInStatus.LockedOut
                Return View("Lockout")
            Case SignInStatus.RequiresVerification
                Return RedirectToAction("SendCode", New With {
                    .ReturnUrl = returnUrl,
                    .RememberMe = model.RememberMe
                })
            Case Else
                ModelState.AddModelError("", "Tentativa de login inválida.")
                Return View(model)
        End Select
    End Function

    '
    ' GET: /Account/Register
    <AllowAnonymous>
    Public Function Register() As ActionResult
        Return View()
    End Function

    '
    ' POST: /Account/Register
    <HttpPost>
    <AllowAnonymous>
    <ValidateAntiForgeryToken>
    Public Async Function Register(model As RegisterViewModel) As Task(Of ActionResult)
        If ModelState.IsValid Then
            Dim user = New ApplicationUser() With {
                .FirstName = model.FirstName,
                .LastName = model.LastName,
                .UserName = model.Email,
                .Email = model.Email
            }
            Dim result = Await UserManager.CreateAsync(user, model.Password)
            If result.Succeeded Then
                Await SignInManager.SignInAsync(user, isPersistent := False, rememberBrowser := False)

                Return RedirectToAction("Index", "Home")
            End If
            AddErrors(result)
        End If

        ' If we got this far, something failed, redisplay form
        Return View(model)
    End Function

    '
    ' POST: /Account/LogOff
    <HttpPost>
    <ValidateAntiForgeryToken>
    Public Function LogOff() As ActionResult
        AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie)
        Return RedirectToAction("Index", "Home")
    End Function

#Region "Helpers"
    ' Used for XSRF protection when adding external logins
    Private Const XsrfKey As String = "XsrfId"

    Private ReadOnly Property AuthenticationManager() As IAuthenticationManager
        Get
            Return HttpContext.GetOwinContext().Authentication
        End Get
    End Property

    Private Sub AddErrors(result As IdentityResult)
        For Each [error] In result.Errors
            ModelState.AddModelError("", [error])
        Next
    End Sub

    Private Function RedirectToLocal(returnUrl As String) As ActionResult
        If Url.IsLocalUrl(returnUrl) Then
            Return Redirect(returnUrl)
        End If
        Return RedirectToAction("Index", "Home")
    End Function
#End Region
End Class