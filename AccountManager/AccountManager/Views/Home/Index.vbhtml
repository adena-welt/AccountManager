@Code
    ViewData("Title") = "Página Inicial"
End Code

<div class="jumbotron text-center" style="background-color: #f8f9fa;">

    @If Not User.Identity.IsAuthenticated Then
        @<h1 style = "color: #343a40;" > Bem - vindo ao sistema de gerenciamento de usuários</h1>
        @<p Class="lead" style="color: #6c757d;">Essa aplicação permite que você crie uma conta, faça login, altere sua senha e exclua sua conta de forma segura e eficiente.</p>
            @<p><a class="btn btn-primary btn-lg" href="@Url.Action("Register", "Account")" role="button">Criar uma conta</a></p>
    Else
        @<h1 style = "color: #343a40;" > Bem - vindo a sua conta</h1>
        @<p Class="lead" style="color: #6c757d;">Aqui é permitido que você altere sua senha e exclua sua conta de forma segura e eficiente.</p>
        End If
</div>
