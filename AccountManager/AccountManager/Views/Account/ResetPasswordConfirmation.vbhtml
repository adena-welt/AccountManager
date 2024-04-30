@Code
    ViewBag.Title = "Reset password confirmation"
End Code

<hgroup class="title">
    <h1>@ViewBag.Title.</h1>
</hgroup>
<div>
    <p>
        Sua senha foi alterado. Por favor @Html.ActionLink("clique aqui para entrar", "Login", "Account", routeValues:=Nothing, htmlAttributes:=New With {Key .id = "loginLink"})
    </p>
</div>
